using System.Collections.Generic;
using System.Windows.Forms;

namespace Worldyachts.Visual.MyPanels
{
    public class MyPhonesFlowLayout : FlowLayoutPanel
    {
        public List<MyPhonePanel> MyPhonePanels { get; } = new List<MyPhonePanel>();
        public MyPhonesFlowLayout(AddNewClientForm form)
        {
            //FlowLayoutPanel flowPanel = form.GetPhonesFlowLayoutPanel();

            //AutoSize = true;
            //BorderStyle = flowPanel.BorderStyle;
            //FlowDirection = flowPanel.FlowDirection;
            //Location = flowPanel.Location;
            //Name = flowPanel.Name;
            //Size = flowPanel.Size;
            //TabIndex = flowPanel.TabIndex;

            var MyPhonePanel = new MyPhonePanel(form);
            Add(MyPhonePanel);
        }

        public void Add(MyPhonePanel panel)
        {
            MyPhonePanels.Add(panel);
            Controls.Add(panel);
        }
    }
}
