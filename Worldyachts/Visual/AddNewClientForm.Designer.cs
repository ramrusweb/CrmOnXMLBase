namespace Worldyachts.Visual
{
    partial class AddNewClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.companySiteTextBox = new System.Windows.Forms.TextBox();
            this.companySiteLabel = new System.Windows.Forms.Label();
            this.contactInfoPanel = new System.Windows.Forms.Panel();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phonesFlowLayoutPanel = new System.Windows.Forms.Panel();
            this.morePhonesButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addOfficeButton = new System.Windows.Forms.Button();
            this.contactPersonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.contactPersonLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.contactPersonsLabel = new System.Windows.Forms.Label();
            this.allOfficesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.contactInfoPanel.SuspendLayout();
            this.phonesFlowLayoutPanel.SuspendLayout();
            this.contactPersonTableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.allOfficesFlowLayoutPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companyNameLabel.Location = new System.Drawing.Point(124, 39);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(207, 19);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Название компании:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(354, 40);
            this.companyNameTextBox.Multiline = true;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(230, 19);
            this.companyNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(23, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // companySiteTextBox
            // 
            this.companySiteTextBox.Location = new System.Drawing.Point(147, 168);
            this.companySiteTextBox.Multiline = true;
            this.companySiteTextBox.Name = "companySiteTextBox";
            this.companySiteTextBox.Size = new System.Drawing.Size(240, 24);
            this.companySiteTextBox.TabIndex = 6;
            // 
            // companySiteLabel
            // 
            this.companySiteLabel.AutoSize = true;
            this.companySiteLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.companySiteLabel.Location = new System.Drawing.Point(33, 173);
            this.companySiteLabel.Name = "companySiteLabel";
            this.companySiteLabel.Size = new System.Drawing.Size(108, 19);
            this.companySiteLabel.TabIndex = 5;
            this.companySiteLabel.Text = "Веб-сайт:";
            // 
            // contactInfoPanel
            // 
            this.contactInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfoPanel.Controls.Add(this.cityLabel);
            this.contactInfoPanel.Controls.Add(this.cityTextBox);
            this.contactInfoPanel.Controls.Add(this.countryComboBox);
            this.contactInfoPanel.Controls.Add(this.addressTextBox);
            this.contactInfoPanel.Controls.Add(this.companySiteTextBox);
            this.contactInfoPanel.Controls.Add(this.countryLabel);
            this.contactInfoPanel.Controls.Add(this.companySiteLabel);
            this.contactInfoPanel.Controls.Add(this.addressLabel);
            this.contactInfoPanel.Location = new System.Drawing.Point(3, 3);
            this.contactInfoPanel.Name = "contactInfoPanel";
            this.tableLayoutPanel1.SetRowSpan(this.contactInfoPanel, 2);
            this.contactInfoPanel.Size = new System.Drawing.Size(476, 225);
            this.contactInfoPanel.TabIndex = 9;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityLabel.Location = new System.Drawing.Point(33, 79);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(75, 19);
            this.cityLabel.TabIndex = 11;
            this.cityLabel.Text = "Город:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(122, 79);
            this.cityTextBox.Multiline = true;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(265, 24);
            this.cityTextBox.TabIndex = 12;
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Белоруссия",
            "Россия",
            "Казахстан",
            "Украина"});
            this.countryComboBox.Location = new System.Drawing.Point(122, 27);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(265, 24);
            this.countryComboBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(122, 123);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(265, 24);
            this.addressTextBox.TabIndex = 10;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.Location = new System.Drawing.Point(30, 24);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(86, 19);
            this.countryLabel.TabIndex = 10;
            this.countryLabel.Text = "Страна:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.Location = new System.Drawing.Point(33, 125);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(75, 19);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Адрес:";
            // 
            // phonesFlowLayoutPanel
            // 
            this.phonesFlowLayoutPanel.Controls.Add(this.morePhonesButton);
            this.phonesFlowLayoutPanel.Controls.Add(this.phoneLabel);
            this.phonesFlowLayoutPanel.Controls.Add(this.phoneTextBox);
            this.phonesFlowLayoutPanel.Location = new System.Drawing.Point(3, 234);
            this.phonesFlowLayoutPanel.Name = "phonesFlowLayoutPanel";
            this.phonesFlowLayoutPanel.Size = new System.Drawing.Size(471, 81);
            this.phonesFlowLayoutPanel.TabIndex = 11;
            // 
            // morePhonesButton
            // 
            this.morePhonesButton.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.morePhonesButton.Location = new System.Drawing.Point(319, 24);
            this.morePhonesButton.Name = "morePhonesButton";
            this.morePhonesButton.Size = new System.Drawing.Size(60, 27);
            this.morePhonesButton.TabIndex = 12;
            this.morePhonesButton.Text = "Ещё";
            this.morePhonesButton.UseVisualStyleBackColor = true;
            this.morePhonesButton.Click += new System.EventHandler(this.morePhonesButton_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLabel.Location = new System.Drawing.Point(36, 28);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(64, 19);
            this.phoneLabel.TabIndex = 10;
            this.phoneLabel.Text = "Тел.:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(114, 29);
            this.phoneTextBox.Multiline = true;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(195, 19);
            this.phoneTextBox.TabIndex = 10;
            // 
            // addOfficeButton
            // 
            this.addOfficeButton.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addOfficeButton.Location = new System.Drawing.Point(609, 23);
            this.addOfficeButton.Name = "addOfficeButton";
            this.addOfficeButton.Size = new System.Drawing.Size(198, 36);
            this.addOfficeButton.TabIndex = 13;
            this.addOfficeButton.Text = "Добавить офис";
            this.addOfficeButton.UseVisualStyleBackColor = true;
            // 
            // contactPersonTableLayoutPanel
            // 
            this.contactPersonTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.contactPersonTableLayoutPanel.ColumnCount = 3;
            this.contactPersonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.97382F));
            this.contactPersonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.02618F));
            this.contactPersonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.contactPersonTableLayoutPanel.Controls.Add(this.label2, 2, 0);
            this.contactPersonTableLayoutPanel.Controls.Add(this.contactPersonLinkLabel, 0, 0);
            this.contactPersonTableLayoutPanel.Controls.Add(this.label1, 1, 0);
            this.contactPersonTableLayoutPanel.Location = new System.Drawing.Point(545, 120);
            this.contactPersonTableLayoutPanel.Name = "contactPersonTableLayoutPanel";
            this.contactPersonTableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel1.SetRowSpan(this.contactPersonTableLayoutPanel, 2);
            this.contactPersonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contactPersonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contactPersonTableLayoutPanel.Size = new System.Drawing.Size(536, 112);
            this.contactPersonTableLayoutPanel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(341, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 53);
            this.label2.TabIndex = 17;
            this.label2.Text = "Моб.: +7 928 051 12 95";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactPersonLinkLabel
            // 
            this.contactPersonLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.contactPersonLinkLabel.AutoSize = true;
            this.contactPersonLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.contactPersonLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.contactPersonLinkLabel.Location = new System.Drawing.Point(20, 2);
            this.contactPersonLinkLabel.Name = "contactPersonLinkLabel";
            this.contactPersonLinkLabel.Size = new System.Drawing.Size(143, 53);
            this.contactPersonLinkLabel.TabIndex = 16;
            this.contactPersonLinkLabel.TabStop = true;
            this.contactPersonLinkLabel.Text = "Пример примерович примеров";
            this.contactPersonLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(209, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 53);
            this.label1.TabIndex = 17;
            this.label1.Text = "Менеджер";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.contactPersonsLabel);
            this.panel1.Location = new System.Drawing.Point(545, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 111);
            this.panel1.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(226, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить нового";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // contactPersonsLabel
            // 
            this.contactPersonsLabel.AutoSize = true;
            this.contactPersonsLabel.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactPersonsLabel.Location = new System.Drawing.Point(96, 53);
            this.contactPersonsLabel.Name = "contactPersonsLabel";
            this.contactPersonsLabel.Size = new System.Drawing.Size(119, 19);
            this.contactPersonsLabel.TabIndex = 17;
            this.contactPersonsLabel.Text = "Сотрудники";
            // 
            // allOfficesFlowLayoutPanel
            // 
            this.allOfficesFlowLayoutPanel.Controls.Add(this.tableLayoutPanel1);
            this.allOfficesFlowLayoutPanel.Location = new System.Drawing.Point(15, 72);
            this.allOfficesFlowLayoutPanel.Name = "allOfficesFlowLayoutPanel";
            this.allOfficesFlowLayoutPanel.Size = new System.Drawing.Size(1090, 424);
            this.allOfficesFlowLayoutPanel.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(301, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 90);
            this.panel2.TabIndex = 20;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.phonesFlowLayoutPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.contactPersonTableLayoutPanel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.contactInfoPanel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 338);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // AddNewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1122, 632);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.allOfficesFlowLayoutPanel);
            this.Controls.Add(this.addOfficeButton);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.companyNameLabel);
            this.Name = "AddNewClientForm";
            this.Text = "AddNewClientForm";
            this.contactInfoPanel.ResumeLayout(false);
            this.contactInfoPanel.PerformLayout();
            this.phonesFlowLayoutPanel.ResumeLayout(false);
            this.phonesFlowLayoutPanel.PerformLayout();
            this.contactPersonTableLayoutPanel.ResumeLayout(false);
            this.contactPersonTableLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.allOfficesFlowLayoutPanel.ResumeLayout(false);
            this.allOfficesFlowLayoutPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox companySiteTextBox;
        private System.Windows.Forms.Label companySiteLabel;
        private System.Windows.Forms.Panel contactInfoPanel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel phonesFlowLayoutPanel;
        private System.Windows.Forms.Button morePhonesButton;
        private System.Windows.Forms.Button addOfficeButton;
        private System.Windows.Forms.TableLayoutPanel contactPersonTableLayoutPanel;
        private System.Windows.Forms.LinkLabel contactPersonLinkLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label contactPersonsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel allOfficesFlowLayoutPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}