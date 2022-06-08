using Calulater.Core.Bal;
using Calulater.Core.Contracts;
using Calulater.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculator.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Accounts()
        {      
            return View();
        }

        public JsonResult Operation(UserEnterdDetails details)
        {
            GenericOperationFactory factary = new GenericOperationFactory();
            IOperater operation = factary.GetOperationType(details.OperationSelected);
            float result = operation.Calculate(details.ValueOne, details.ValueTwo);
            var jsonReader = default(dynamic);
            jsonReader = new
            {
                Value = result,               
            };
            return Json(jsonReader, JsonRequestBehavior.AllowGet); 
        }
    }   
}