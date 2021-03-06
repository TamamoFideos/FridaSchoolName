﻿using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;
using System.Text;
using FridaSchoolWeb.Models;

namespace FridaSchoolWeb.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        FridaSchool db;
        Teacher teacher {get; set;}

        public AdminController(ILogger<AdminController> logger, FridaSchool injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult Index(string message)
        {
            if (ControllerContext.HttpContext.User.Identity.Name != "0000")
            {
                return RedirectToAction("Index","Home");
            }
            IQueryable<Teacher> teachers = db.Teachers;
            return View(teachers);
        }
        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(string names, string middleName, string lastName, string birthDate, string genre, string password, string type, string isBase){
            Teacher teacher;
            if (type == "true")
            {
                teacher = new Cordinator();
                teacher.IsBase = true;
            }else
            {
                teacher = new Teacher();
                teacher.IsBase = Boolean.Parse(isBase);
            }
            teacher.Names = names.ToUpper();
            teacher.MiddleName = middleName.ToUpper();
            teacher.LastName = lastName.ToUpper();
            teacher.BirthDate = DateTime.Parse(birthDate);
            teacher.Gender = genre[0];
            teacher.Password = Encrypt(password);
            teacher.KeysGenerator();
            db.Teachers.Add(teacher);
            db.SaveChanges();
            teacher.Roaster = (1000 + teacher.ID).ToString();
            db.Update(teacher);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

        public ActionResult Delete(int ID){
            Teacher teacher = db.Teachers.First(t => t.ID == ID);
            db.Teachers.Remove(teacher);
            db.SaveChanges();
            return RedirectToAction("Index","Admin");
        }

        private string Encrypt(string password){
            using (SHA256 sha256Hash = SHA256.Create()){
                byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                var sBuilder = new StringBuilder();
                // Loop through each byte of the hashed data
                // and format each one as a hexadecimal string.
                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                // Return the hexadecimal string.
                return sBuilder.ToString();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
