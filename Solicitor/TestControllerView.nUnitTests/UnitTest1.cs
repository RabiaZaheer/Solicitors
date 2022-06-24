using NUnit.Framework;
using Solicitor.Controllers;
using System.Web.Mvc;

namespace TestControllerView.nUnitTests
{
    
    public class Tests
    {
        
        

        [Test]
        public void Index()
        {
            DefaultController controller =new DefaultController();

            ViewResult? result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }
    }
}