using System.Windows.Forms;

namespace Worldyachts.Visual.MyPanels
{
    public class MyPhoneTextBox : TextBox
    {
        public MyPhoneTextBox(AddNewClientForm form)
        {
            TextBox phoneTextBox = form.GetPhoneTextBox();

            Location = phoneTextBox.Location;
            Name = phoneTextBox.Name;
            Size = phoneTextBox.Size;
            TabIndex = phoneTextBox.TabIndex;
        }
    }
}
