using Worldyachts.Control;

namespace Worldyachts.Model
{
    public class MyModel
    {
        private Controller _controller;
        public Company NewCompany { get; set; }
        public MyModel() {}

        // public ApiClient ApiClient { get; } = new ApiClient();

        public MyModel(Controller controller)
        {
            _controller = controller;
        }

        public XmlHelper XmlHelper { get; set; } = new XmlHelper();
    }
}
