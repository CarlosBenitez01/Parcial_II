using Microsoft.AspNetCore.Mvc;
using PracticaSegundoParcial_CFBQ.Dominio;
using PracticaSegundoParcial_CFBQ.Models.ViewModel;
using PracticaSegundoParcial_CFBQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Controllers
{
    public class StudentsController : Controller
    {
        private IStudents istudents;
        public StudentsController(IStudents istudents)
        {
            this.istudents = istudents;
        }
        public IActionResult Index()
        {
            var list = istudents.ListOfStudents();
            return View(list);
        }
        public IActionResult PreStudents(int id)
        {

            StudentsViewModel CastStudent = new StudentsViewModel();
            int Id = Convert.ToInt32(id);
            Students s = istudents.RegistryFindById(Id);
            CastStudentViewModel StudentUp = new CastStudentViewModel(s);
            if (!(StudentUp.LastName is "" or null))
            {
                CastStudent.LastName = StudentUp.LastName;
                CastStudent.FirstMidName = StudentUp.FirstMidName;
                CastStudent.EnrollementsDate = StudentUp.EnrollementsDate;
            }           
            return View("Students", CastStudent);
        }
        public IActionResult Students()
        {
            return View();
        }      

        public IActionResult Ins_mod_student(StudentsViewModel studentView)
        {
            if (!ModelState.IsValid)
            {
                return View("Students", studentView);
            }
            else
            {
                if (studentView.Id == 0)
                {
                    Students s = new Students
                    {
                        LastName = studentView.LastName,
                        FirtsMidName = studentView.FirstMidName,
                        Status = 1,
                        EnrollementsDate = studentView.EnrollementsDate
                    };
                    istudents.InsertStudent(s);
                }
                else
                {
                    Students OneRegistryOfStudents = istudents.RegistryFindById(studentView.Id);
                    OneRegistryOfStudents.LastName = studentView.LastName;
                    OneRegistryOfStudents.FirtsMidName = studentView.FirstMidName;
                    OneRegistryOfStudents.Status = 1;
                    OneRegistryOfStudents.EnrollementsDate = studentView.EnrollementsDate;
                    istudents.UpdateStudent(OneRegistryOfStudents);
                }
            }
            return RedirectToAction("Index");
        }
    }
}
