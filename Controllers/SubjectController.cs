﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;  
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

using Microsoft.Extensions.Logging;
using FridaSchoolWeb.Models;

namespace FridaSchoolWeb.Controllers
{
    public class SubjectController : Controller
    {
        private readonly ILogger<SubjectController> _logger;
        FridaSchool db;
        Teacher teacher {get; set;}

        public SubjectController(ILogger<SubjectController> logger, FridaSchool injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }

        public IActionResult MySubjects(string message)
        {
            int id = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "ID")?.Value);
            List<AsignaturePerTeacher> mySubjects = db.AsignaturesPerTeacher.Where(a => a.ID_Teacher == id).ToList();
            SubjectsList subjects = new SubjectsList();
            foreach (var item in mySubjects)
            {
                subjects.SubjectsPerTeacher.Add(db.Subjects.First(x => x.ID == item.ID_Subject));
            }
            List<Subject> allSubjects = db.Subjects.ToList();
            Erased:
            foreach (var item in allSubjects)
            {
                foreach (var item2 in subjects.SubjectsPerTeacher)
                {
                    if(item2.ID == item.ID){
                        allSubjects.Remove(item);
                        goto Erased;
                    }
                }
            }
            subjects.SubjectsAvaiable = allSubjects;
            return View(subjects);
        }
        public IActionResult AddSubject(int id){
            int idUser = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "ID")?.Value);
            AsignaturePerTeacher asignatureRegister = new AsignaturePerTeacher{
                ID_Subject = id,
                ID_Teacher = idUser
            };
            db.AsignaturesPerTeacher.Add(asignatureRegister);
            db.SaveChanges();
            return RedirectToAction("MySubjects");
        }
        public IActionResult RemoveSubject(int id){
            int idUser = Int32.Parse(HttpContext.User.Claims.FirstOrDefault(c => c.Type == "ID")?.Value);
            AsignaturePerTeacher asignatureRegister = db.AsignaturesPerTeacher.First(a => a.ID_Teacher == idUser && a.ID_Subject == id);
            db.AsignaturesPerTeacher.Remove(asignatureRegister);
            db.SaveChanges();
            return RedirectToAction("MySubjects");
        }

        public IActionResult Subjects(string message)
        {
            IQueryable<Subject> Subjects = db.Subjects;
            return View(Subjects);
        }

        [HttpPost]
        public IActionResult EditSubject(int id, string name, string theoryH, string practiceH)
        {
            sbyte theoryHours = sbyte.Parse(theoryH);
            sbyte practiceHours = sbyte.Parse(practiceH);
            if((theoryHours + practiceHours) < 7 && (theoryHours + practiceHours) >0){
                Subject subject = db.Subjects.First(s => s.ID == id);
                subject.Name = name.ToUpper();
                subject.TheoryHours = theoryHours;
                subject.PracticeHours = practiceHours;
                db.Subjects.Update(subject);
                db.SaveChanges();
            }else{
                return RedirectToAction("Subjects", new {mesage = "The hours are incorrect"});
            }
            return RedirectToAction("Subjects");
        }

        public IActionResult Delete(int id){
            Subject subject = db.Subjects.First(s => s.ID == id); 
            db.Subjects.Remove(subject);
            db.SaveChanges();
            return RedirectToAction("Subjects");
        }



        public IActionResult Create(string name, string theoryH, string practiceH){
            sbyte theoryHours = sbyte.Parse(theoryH);
            sbyte practiceHours = sbyte.Parse(practiceH);

            if((theoryHours + practiceHours) < 7 && (theoryHours + practiceHours) >0){
                Subject subject = new Subject{
                    Name = name.ToUpper(),
                    TheoryHours = theoryHours,
                    PracticeHours = practiceHours
                };         
                db.Subjects.Add(subject);
                db.SaveChanges();
                subject.GenerateKey(subject.ID);
                db.Update(subject);
                db.SaveChanges();
            }else{
                return RedirectToAction("Subjects", new {mesage = "The hours are incorrect"});
            }
            return RedirectToAction("Subjects");
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
