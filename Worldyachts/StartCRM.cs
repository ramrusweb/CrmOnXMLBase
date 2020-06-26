using Worldyachts.Control;
using Worldyachts.Model;
using Worldyachts.Visual;

namespace Worldyachts
{
    public class StartCRM
    {
        static void Main(string[] args)
        {
            var controller = new Controller();
            var myVisual = new MainScreenForm(controller);
            var myModel = new MyModel(controller);
            controller.Start(myModel, myVisual);
        }
    }
}
