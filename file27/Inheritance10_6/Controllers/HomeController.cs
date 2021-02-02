using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Inheritance13.Models;

namespace Inheritance13.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IConfiguration _iConfig;
        private IWebHostEnvironment _env;
        public HomeController(ILogger<HomeController> logger, IConfiguration iConfig, IWebHostEnvironment env)
        {
            _logger = logger;
            _iConfig = iConfig;
            _env = env;
        }


        public IActionResult Index()
        {
            ViewBag.MyKey = _iConfig["MyKey"];
            return View();

        }
        public IActionResult AboutMe()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Persons()
        {
            return View(PersonMemory.GetPersons());
        }
        public IActionResult PersonalDetail(int personDetailId)
        {
            PersonalDetail pdetail = new PersonalDetail();
            pdetail = PersonMemory.GetPersons().Where(x => x.PersonalDetailId == personDetailId).FirstOrDefault();
            return View(pdetail);
            //return new ObjectResult(pdetail);
        }
        public ViewResult PersonalDetailEdit(int personDetailId)
        {
            PersonalDetail pdetail = new PersonalDetail();
            pdetail = PersonMemory.GetPersons().Where(x => x.PersonalDetailId == personDetailId).FirstOrDefault();
            return View(pdetail);
        }

        [HttpPost]
        public  async Task<ActionResult> PersonalDetailEdit(PersonalDetail pd)
        {
            if (ModelState.IsValid)
            {
                if (Request.Form.Files["profile-image"] != null)
                {
                    //saving
                    if (Request.Form.Files["profile-image"].Length > 10 * 1024 * 1024)
                    {
                        pd.ErrorMsg = "File Size not valid !!";
                        return View(pd);
                    }
                    string pathToFolder = Path.Combine(_env.WebRootPath, "uploadedfiles", Request.Form.Files["profile-image"].FileName);

                    var fileStream = new FileStream(pathToFolder, FileMode.Create);
                    await Request.Form.Files["profile-image"].CopyToAsync(fileStream);
                    pd.ImageLocation = "uploadedfiles/" + Request.Form.Files["profile-image"].FileName;
                }
                //reference type variable
                var personInList = PersonMemory.GetPersons().Where(x => x.PersonalDetailId == pd.PersonalDetailId).FirstOrDefault();
                personInList.FirstName = pd.FirstName;
                personInList.Occupation = pd.Occupation;
                personInList.Age = pd.Age;
                personInList.Address = pd.Address;
                personInList.ImageLocation = pd.ImageLocation;
                return RedirectToAction("Persons");
            }
            else
            {
                return View(pd);
            }

        }
        public IActionResult CreatePersonDetail()
        {
            PersonalDetail pd = new PersonalDetail();
            return View(pd);
        }

        [HttpPost]
        public async Task<ActionResult> CreatePersonDetail(PersonalDetail pd)
        {

            if (Request.Form.Files["profile-image"] != null)
            {
                //saving
                if (Request.Form.Files["profile-image"].Length > 10 * 1024 * 1024)
                {
                    pd.ErrorMsg = "File Size not valid !!";
                    return View(pd);
                }
                string pathToFolder = Path.Combine(_env.WebRootPath,"uploadedfiles", Request.Form.Files["profile-image"].FileName);

                var fileStream = new FileStream(pathToFolder, FileMode.Create);
               await Request.Form.Files["profile-image"].CopyToAsync(fileStream);
                pd.ImageLocation = pathToFolder;
            }
            var persondetailList = PersonMemory.GetPersons();
            int currentPersonCount = persondetailList.Count;
            currentPersonCount = currentPersonCount + 1;
            pd.PersonalDetailId = currentPersonCount;
            persondetailList.Add(pd);
            return RedirectToAction("Persons");
        }
        public FileResult DownloadFile(int personId)
        {
            string downloadPath = PersonMemory.GetPersons().Where(x => x.PersonalDetailId == personId).FirstOrDefault().ImageLocation;
            string pathToFolder = Path.Combine(_env.WebRootPath,downloadPath);
            var fileStream = new FileStream(pathToFolder, FileMode.Create);
            return File(fileStream, "image/jpeg","downloadedfiles");
            

        }
        public IActionResult PersonalDetailDelete(int personDetailId)
        {
            var person = PersonMemory.GetPersons().Where(x => x.PersonalDetailId == personDetailId).FirstOrDefault();
            PersonMemory.GetPersons().Remove(person);
            return RedirectToAction("Persons");
        }

        //20201005
        #region 2020105

        public IActionResult GetSumOfNumbers(PersonalDetail pd)
        {
            Int16 firstNumber;
            Int16 secondNumber;
            Int16 sumOfNumbers = 0;
            Int16 divisor = 1;
            Int16 dividend = 0;
            string stringNumber = "125a";
            //PersonalDetail pd;
            //max 32767
            try
            {
                List<Int16> integerList = new List<Int16>();
                integerList.Add(1234);

                firstNumber = Convert.ToInt16(1234);
                secondNumber = integerList[0];
                sumOfNumbers = Convert.ToInt16(firstNumber + secondNumber);
                dividend = Convert.ToInt16(firstNumber / divisor);
                divisor = Convert.ToInt16(stringNumber);
                string name = pd.Address;
            }
            catch (IndexOutOfRangeException ex)
            {
                return Json(new { ExceptionMessage = ex.Message });
            }
            catch (NullReferenceException ex)
            {
                return Json(new { ExceptionMessage = ex.Message });
            }
            catch (OutOfMemoryException ex)
            {
                //we have 4 gb
                //current process consuming 2 gb
                //clean

                return Json(new { ExceptionMessage = ex.Message });
            }

            catch (DivideByZeroException ex)
            {
                return Json(new { ExceptionMessage = ex.Message });
            }
            catch (FormatException ex)
            {
                return Json(new { ExceptionMessage = "Please enter valid age !!" });
            }
            catch (InvalidCastException ex)
            {
                return Json(new { ExceptionMessage = ex.Message });
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return Json(new { ExceptionMessage = ex.Message });
            }
            catch (Exception ex)
            {
                return Json(new { ExceptionMessage = ex.Message });

            }
            finally
            {
                sumOfNumbers += 10;
            }

            return Json(new { sum = sumOfNumbers });
        }
        public ActionResult CheckPerformanceOfTryCatch()
        {
            TimeSpan a;
            TimeSpan b;
            Stopwatch w = new Stopwatch();
            double d = 0;

            w.Start();

            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    d = Math.Sin(Convert.ToInt32("abcd"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            w.Stop();
            a = w.Elapsed;
            w.Reset();
            w.Start();

            for (int i = 0; i < 10000000; i++)
            {
                d = Math.Sin(1);
            }

            w.Stop();
            b = w.Elapsed;
            return Json(new { withtrycatch = a, withouttrycatch = b });
        }
        #endregion
    }

}

