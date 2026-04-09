using InterfaceMethods;
using MethodImplementation;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dependency.Controllers
{
    public class HarshController : Controller
    {
        private readonly StudentInterface _studntInterface;

        //Constructor injection
        public HarshController(StudentInterface studntInterface)
        {
            _studntInterface = studntInterface;
        }
   
              
        public IActionResult Display()
        {
            //StudentImplementation obj = new StudentImplementation();

            //long DATA = obj.Add(10, 20);
             
            
            long DATA = _studntInterface.Add(10, 20);
            return View(DATA);

        }
    }
}
