using System.Windows.Forms;
using Worldyachts.Visual.Elements;

namespace Worldyachts.Visual.MyPanels
{
    public class MyPhonePanel : Panel
    {
        public MyPhoneTextBox MyPhoneTextBox { get; set; }
        public MyPhonePanel(AddNewClientForm form)
        {
            Panel phonesPanel = form.GetPhonePanel();

            Location = phonesPanel.Location;
            Name = phonesPanel.Name;
            Size = phonesPanel.Size;
            TabIndex = phonesPanel.TabIndex;

            MyPhoneTextBox = new MyPhoneTextBox(form);
            var myMorePhonesButton = new MyMorePhonesButton(form);
            var myPhoneLabel = new MyPhoneLabel(form);

            Controls.Add(myMorePhonesButton);
            Controls.Add(MyPhoneTextBox);
            Controls.Add(myPhoneLabel);
        }
    }
}
