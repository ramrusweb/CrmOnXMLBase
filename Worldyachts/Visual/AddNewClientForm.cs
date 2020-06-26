using Worldyachts.Control;
using System;
using System.Windows.Forms;
using System.Drawing;
using Worldyachts.Visual.MyPanels;

namespace Worldyachts.Visual
{
    public partial class AddNewClientForm : Form
    {
        public Controller _controller;

        public MyPhonesFlowLayout MyPhonesFlowLayout { get; set; }
        public TextBox NewCompanyNameTextBox;

        public AddNewClientForm(Controller controller)
        {
            InitializeComponent();
            _controller = controller;
            ResetForms();
        }
        #region Getters
        public Panel GetPhonePanel() { return phonesFlowLayoutPanel; }
        public TextBox GetPhoneTextBox() { return phoneTextBox; }
        public Button GetMorePhonesButton() { return morePhonesButton; }
        public Label GetPhoneLabel() { return phoneLabel; }
        #endregion

        void ResetForms()
        {
            // todo поменять дефолтные классы на мои и добавить переменные с данными.
            MyPhonesFlowLayout = new MyPhonesFlowLayout(this);
            phonesFlowLayoutPanel.AutoSize = true;
            allOfficesFlowLayoutPanel.AutoSize = true;
        }

        public void AddOneMorePhonePanel()
        {
            MyPhonesFlowLayout.Add(new MyPhonePanel(this));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCompanyNameTextBox = companyNameTextBox;
            _controller.SaveNewCompanyData();
        }

        // Button handler - Ещё.
        private void morePhonesButton_Click(object sender, EventArgs e)
        {
            phonesFlowLayoutPanel.Controls.Add(CreateNewPhonePanel());
        }
        private Panel CreateNewPhonePanel()
        {
            var PhonePanel = new Panel();
            PhonePanel.Controls.Add(CreateNewPhoneLabel());
            PhonePanel.Controls.Add(CreateNewPhoneTextBox());
            PhonePanel.Controls.Add(CreateNewMorePhonesButton());
            PhonePanel.Location = new Point(3, 3);
            PhonePanel.Name = "PhoneLabel";
            PhonePanel.Size = new Size(254, 51);
            PhonePanel.TabIndex = 9;
            return PhonePanel;
        }
        private Label CreateNewPhoneLabel()
        {
            var PhoneLabel = new Label();
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(5, 18);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(29, 13);
            PhoneLabel.TabIndex = 6;
            PhoneLabel.Text = "Тел.:"; 
            return PhoneLabel;
        }
        private TextBox CreateNewPhoneTextBox()
        {
            var PhoneTextBox = new TextBox();
            PhoneTextBox.Location = new Point(61, 15);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(100, 20);
            PhoneTextBox.TabIndex = 7;
            return PhoneTextBox;
        }
        private Button CreateNewMorePhonesButton()
        {
            var MorePhonesButton = new Button();
            MorePhonesButton.Location = new Point(187, 12);
            MorePhonesButton.Name = "MorePhonesButton";
            MorePhonesButton.Size = new Size(47, 23);
            MorePhonesButton.TabIndex = 8;
            MorePhonesButton.Text = "Ещё";
            MorePhonesButton.UseVisualStyleBackColor = true;
            MorePhonesButton.Click += new EventHandler(morePhonesButton_Click);
            return MorePhonesButton;
        }
    }
}
