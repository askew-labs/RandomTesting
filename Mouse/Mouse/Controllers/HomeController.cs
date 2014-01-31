using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace Mouse.Controllers
{
    public class Entity
    {
        public ObjectId Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class HomeController : Controller
    {
        public ActionResult Load(string name)
        {
            //some operations goes here
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("members");
            var collection = database.GetCollection<Entity>("name");

            var entity = new Entity { FirstName = firstname, Email = email };



            return View(); //return some view to the user
        }
        public ActionResult Index()
        {
            /*var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("members");
            var collection = database.GetCollection<Entity>("name");

            string name;
            string email;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name: ");
                name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter email: ");
                email = Convert.ToString(Console.ReadLine());

                var entity = new Entity { Name = name, Email = email };
                collection.Insert(entity);
                var id = entity.Id;
            }
            */



            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
