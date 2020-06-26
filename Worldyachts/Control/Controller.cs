using System.Windows.Forms;
using Worldyachts.Model;
using Worldyachts.Visual;
using Worldyachts.Visual.MyPanels;

namespace Worldyachts.Control
{
    public class Controller
    {
        enum TestStep
        {
            AddCompanyForm,
            MainScreen,
            API,
            AllProjectsForm
        }
        private MyModel _myModel;
        private MainScreenForm MainScreenForm;

        public void Start(MyModel myModel, MainScreenForm myVisual)
        {
            _myModel = myModel;
            MainScreenForm = myVisual;

            switch(TestStep.AddCompanyForm)
            {
                case TestStep.MainScreen:
                    ShowMainScreenDialog();

                case TestStep.AddCompanyForm:
                    ShowAddNewCompanyDialog();
                    break;
            }
        }

        public void ShowMainScreenDialog()
        {
            MainScreenForm = new MainScreenForm(_controller);
            MainScreenForm.ShowDialog();
        }

        public void ShowAddNewCompanyDialog()
        {
            MainScreenForm.ShowAddNewCompanyDialog();
        }

        public void SaveNewCompanyData()
        {
            _myModel.NewCompany = GetCompanyDataFromForm();
            if (_myModel.NewCompany.Name.Equals(""))
            {
                MessageBox.Show("Вы не ввели название компании!");
                return; 
            }

            // TODO: в форме добавить возможность вписывать название компании на другом языке.
            // TODO: добавить в форму поле email.
            // TODO: добавить проверку компании на уникальность.
            // TODO: проверить компанию по названию, по телефону, по имейлу

            // TODO: присвоить компании уникальный id для получения последнего id.
            _myModel.NewCompany.Id = _myModel.XmlHelper.GetBigestCompanyId() + 1;

            // new ClientsInfoForm(clientInfo).ShowDialog();
            _myModel.XmlHelper.AddNewCompanyInfo(_myModel.NewCompany);

            // TODO: автоматически поставилась задача на проработку компании менеджеру по какому-то принципу.

            _myVisual.AddNewClientForm.Dispose();
        }

        private Company GetCompanyDataFromForm()
        {
            var company = new Company();
            company.Name = _myVisual.AddNewClientForm.NewCompanyNameTextBox.Text;
            var newOffice = new Office();
            foreach (MyPhonePanel panel in _myVisual.AddNewClientForm.MyPhonesFlowLayout.MyPhonePanels)
            {
                newOffice.Phones.Add(panel.MyPhoneTextBox.Text);
            }
            company.Offices.Add(newOffice);
            return company;
        }
    }
}
