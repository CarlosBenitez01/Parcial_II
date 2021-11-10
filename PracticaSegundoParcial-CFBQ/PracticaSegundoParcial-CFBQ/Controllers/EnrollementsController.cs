using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PracticaSegundoParcial_CFBQ.Dominio;
using PracticaSegundoParcial_CFBQ.Models.ViewModel;
using PracticaSegundoParcial_CFBQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Controllers
{
    public class EnrollementsController : Controller
    {
        private IEnrollements ienroll;
        private ICourse icourse;
        private IStudents istudents; 

        public EnrollementsController(IEnrollements ienroll, ICourse icourse, IStudents istudents)
        {
            this.ienroll = ienroll;
            this.icourse = icourse;
            this.istudents = istudents;
        }
        public IActionResult EnrollementsList()
        {
    
            var listado = ienroll.UnionDeTablas();
            return View(listado);
        }

        public IActionResult EnrollStudents()
        {
            var InformationOftheComboBox = icourse.ListOfCourses();
            var InformationOftheComboBoxForStudents = istudents.ListOfStudents();

            List<SelectListItem> listCourse = new List<SelectListItem>();
            List<SelectListItem> listStudents = new List<SelectListItem>();
            List<SelectListItem> listEnrollements = new List<SelectListItem>();

            foreach (var iterarinformacion in InformationOftheComboBox)
            {
                listCourse.Add(new SelectListItem
                {
                    Text = iterarinformacion.Title,
                    Value = Convert.ToString(iterarinformacion.CourseId)
                }

                    );
                ViewBag.estadoListCourse = listCourse;

            }
            foreach (var iterarinformacion in InformationOftheComboBoxForStudents)
            {
                listStudents.Add(new SelectListItem
                {
                    Text = iterarinformacion.FirtsMidName,
                    Value = Convert.ToString(iterarinformacion.StudentId)
                }

                    );
                ViewBag.estadoListStudents = listStudents;

            }
            
            String[] array = new String[4] { "A", "B", "C", "D" };
            for (int i = 0; i <= 3; i++)
            {
                listEnrollements.Add(new SelectListItem
                {
                    Text = array[i],
                    Value = Convert.ToInt32(i+1).ToString()
                });
                ViewBag.estadoListGrade = listEnrollements;
            }
            

            return View();
        }

        public IActionResult Enroll(EnrollementViewModel viewModel)
        {
            var grade = viewModel.Grade-1;
            
            Enrollements e = new Enrollements
            {
                CourseID = viewModel.CourseID,
                StudentsID = viewModel.StudentsID,
                Grade = (Grade?)grade
            
            };
            
            ienroll.InsertEnrollements(e);
            return RedirectToAction("EnrollementsList");
        }
    }
}
