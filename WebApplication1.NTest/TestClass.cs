using NUnit.Framework;
using WebApplication1.Controllers;

namespace WebApplication1.NTest
{
    [TestFixture]
    public class HomeControllerNTest

    {
        [TestCase]
        public void ControllerTest() { 
            // Arrange
            HomeController controller = new HomeController();            

            // Assert
            Assert.IsNotNull(controller);
        }
    }
}
