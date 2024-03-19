using Json_Veri.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Json_Veri.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            // Json veri tipi : Hızlı, anlaşılabilir, oluşturmak kolay, transfer etmesi kolay
            // Json metin tabanlı bir veri tipidir.

            #region Object To Json
            Student stu = new Student();
            stu.Age = 10;
            stu.Surname = "Aktan";
            stu.Name = "Bahadır";
            stu.Toys = new string[] { "Car", "Ship", "Animal", "Soldier" };

            // Bir Tip'i Json'a çevirmek için NewtonSoft paketini kullanırız.

            var jsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(stu);
            #endregion

            #region Json To Object

            string json = @"{
                                
                             'Name':'Fırat',
                             'Surname' : 'Aşıcı',
                             'Age' : 40

                          }";

            // Json To Object

           Person p = JsonConvert.DeserializeObject<Person>(json);

            #endregion
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
    }
}