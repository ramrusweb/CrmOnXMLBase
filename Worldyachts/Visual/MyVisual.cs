using Worldyachts.Control;

namespace Worldyachts.Visual
{
    public class MyVisual
    {
        private Controller _controller;

        public MyVisual(Controller controller)
        {
            _controller = controller;
        }

        // TODO открыть стартовое окно
        void SetUpStartWindow()
        {
            // TODO set the properties of the main window
        }

        public void ShowMainScreenDialog()
        {
            MainScreenForm = new MainScreenForm(_controller);
            MainScreenForm.ShowDialog();
        }

        public void ShowAddNewCompanyDialog()
        {
            AddNewClientForm = new AddNewClientForm(_controller);
            AddNewClientForm.ShowDialog();
        }
    }
}
