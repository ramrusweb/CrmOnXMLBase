using System;
using System.Drawing.Text;
using System.IO;
using System.Xml.Linq;

namespace Worldyachts.Model
{
    public class XmlHelper
    {
        private const string TEST_BASE_DIRECTORY = "..\\..\\Model\\XMLBase";
        private const string BASE_DIRECTORY = "Model\\XMLBase";
        private const string COMPANY_FILE_NAME = "companies.xml";

        public int GetBigestCompanyId()
        {
            string path = GetXmlDocumentPath();
            XDocument xDoc = XDocument.Load(path);
            int id = 0;
            
            foreach (var element in xDoc.Element("companies").Elements("company"))
            {
                if (id < Int32.Parse(element.Attribute("id").Value))
                {
                    id = Int32.Parse(element.Attribute("id").Value);
                }
            }
            return id;
        }

        public void AddNewCompanyInfo(Company company)
        {
            string path = GetXmlDocumentPath();
            XDocument xDoc = XDocument.Load(path);

            var companyNameAttribute = new XAttribute("name", company.Name);
            var companyIdAttribute = new XAttribute("id", company.Id);
            var companyElement = new XElement("company");
            companyElement.Add(companyNameAttribute);
            companyElement.Add(companyIdAttribute);

            foreach (Office office in company.Offices)
            {
                var officeElement = new XElement("office");
                foreach (string phone in office.Phones)
                {
                    var phoneElement = new XElement("phone", phone);
                    officeElement.Add(phoneElement);
                }
                companyElement.Add(officeElement);
            }

            xDoc.Element("companies").Add(companyElement);
            xDoc.Save(path);
        }

        private string GetXmlDocumentPath()
        {
            string path = "";
            var xDoc = new XDocument();
            try
            {
                path = Path.Combine(TEST_BASE_DIRECTORY, COMPANY_FILE_NAME);
                xDoc = XDocument.Load(path);
            }
            catch(DirectoryNotFoundException)
            {
                path = Path.Combine(BASE_DIRECTORY, COMPANY_FILE_NAME);
                xDoc = XDocument.Load(path);
            }

            return path;
        }
    }
}
