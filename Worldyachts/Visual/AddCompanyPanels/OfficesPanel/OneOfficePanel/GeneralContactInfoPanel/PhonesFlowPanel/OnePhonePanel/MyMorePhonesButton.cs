using System;
using System.Windows.Forms;
using Worldyachts.Control;

namespace Worldyachts.Visual.Elements
{
    public class MyMorePhonesButton : Button
    {
        private AddNewClientForm _form;
        public MyMorePhonesButton(AddNewClientForm form)
        {
            _form = form;
            Button morePhonesButton = form.GetMorePhonesButton();

            Location = morePhonesButton.Location;
            Name = morePhonesButton.Name;
            Size = morePhonesButton.Size;
            TabIndex = morePhonesButton.TabIndex;
            Text = morePhonesButton.Text;
            UseVisualStyleBackColor = morePhonesButton.UseVisualStyleBackColor;

            Click += new EventHandler(IsClicked);
        }

        public void IsClicked(object sender, EventArgs e)
        {
            _form.AddOneMorePhonePanel();
        }
    }
}
