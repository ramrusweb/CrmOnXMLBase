using System.Windows.Forms;

namespace Worldyachts.Visual
{
    public partial class ClientsInfoForm : Form
    {
        public ClientsInfoForm(string[] clientInfo)
        {
            InitializeComponent();
            ClientsDataGridView.Rows.Add(clientInfo);
        }
    }
}
