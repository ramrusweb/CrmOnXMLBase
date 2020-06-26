using System.Windows.Forms;

namespace Worldyachts.Visual.Elements
{
    public class MyPhoneLabel : Label
    {
        public MyPhoneLabel(AddNewClientForm form)
        {
            Label phoneLabel = form.GetPhoneLabel();

            AutoSize = phoneLabel.AutoSize;
            Location = phoneLabel.Location;
            Name = phoneLabel.Name;
            Size = phoneLabel.Size;
            TabIndex = phoneLabel.TabIndex;
            Text = phoneLabel.Text;
        }
    }
}
