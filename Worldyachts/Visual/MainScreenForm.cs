using System.Windows.Forms;
using Worldyachts.Control;

namespace Worldyachts.Visual
{
    public partial class MainScreenForm : Form
    {
        private Controller _controller;

        // Формы диалогов.
        public NewProjectsForm NewProjectsForm { get; set; }
        public AddNewClientForm AddNewClientForm { get; set; }
        public AllProjectsForm AllProjectsForm { get; set; }

        // Панели.
        public MyAllProjectsFlowLayoutPanel MyAllProjectsFlowLayoutPanel { get; set; }
        public MyClientsPanel MyClientsPanel { get; set; }

        public Panel CurrentPanel { get; set; }

        public MainScreenForm(Controller controller)
        {
            _controller = controller;
            InitializeComponent();
        }

        private void addNewCompanyButton_Click(object sender, System.EventArgs e)
        {
            _controller.ShowAddNewCompanyDialog();
        }
    }
}
