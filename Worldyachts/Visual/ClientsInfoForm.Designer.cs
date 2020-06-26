namespace Worldyachts.Visual
{
    partial class ClientsInfoForm
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
            this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
            this.CompanyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanySiteColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsDataGridView
            // 
            this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyNameColumn,
            this.CompanySiteColumn});
            this.ClientsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClientsDataGridView.Name = "ClientsDataGridView";
            this.ClientsDataGridView.RowHeadersWidth = 51;
            this.ClientsDataGridView.RowTemplate.Height = 24;
            this.ClientsDataGridView.Size = new System.Drawing.Size(306, 353);
            this.ClientsDataGridView.TabIndex = 0;
            // 
            // CompanyNameColumn
            // 
            this.CompanyNameColumn.HeaderText = "Название компании";
            this.CompanyNameColumn.MinimumWidth = 6;
            this.CompanyNameColumn.Name = "CompanyNameColumn";
            this.CompanyNameColumn.Width = 125;
            // 
            // CompanySiteColumn
            // 
            this.CompanySiteColumn.HeaderText = "Веб-сайт";
            this.CompanySiteColumn.MinimumWidth = 6;
            this.CompanySiteColumn.Name = "CompanySiteColumn";
            this.CompanySiteColumn.Width = 125;
            // 
            // ClientsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 353);
            this.Controls.Add(this.ClientsDataGridView);
            this.Name = "ClientsInfoForm";
            this.Text = "ClientsInfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanySiteColumn;
    }
}