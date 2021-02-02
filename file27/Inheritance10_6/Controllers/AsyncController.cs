using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Inheritance13.Controllers
{
    public class AsyncController : Controller
    {

        List<string> NameList = new List<string>();
        int counter = 0;
        public IActionResult Index()
        {
            FirstFuction();
            SecondFunction();
            return View(NameList);
        }
        public async void FirstFuction()
        {
            await Task.Run(() =>
            {
                for (; counter <= 100000; counter++)
                {
                    NameList.Add("FirstFuction Functon Execution");
                }
            }
            );
        }
        public void SecondFunction()
        {
            for(;counter<=100000;counter++)
            {
                NameList.Add("Second Function Exection");
            }
        }
    }
}
