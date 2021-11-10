using Microsoft.AspNetCore.Mvc;
using PracticaSegundoParcial_CFBQ.Dominio;
using PracticaSegundoParcial_CFBQ.Models.ViewModel;
using PracticaSegundoParcial_CFBQ.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Repository
{
    public class CourseController : Controller
    {
        private ICourse icourse;
        public CourseController(ICourse icourse)
        {
            this.icourse = icourse;
        }
        public IActionResult CourseList()
        {
            var list = icourse.ListOfCourses();
            return View(list);
        }
        public IActionResult PreCourses(int id)
        {
            int Id = Convert.ToInt32(id);
            Course c = icourse.RegistryFindById(Id);
            CourseViewModel CastCourse = new CourseViewModel(c);
            return View("RegisterCourse", CastCourse);
        }

        public IActionResult RegisterCourse()
        {
            return View();
        }

        public IActionResult Ins_mod_Course(CourseViewModel courseView)
        {
            if (!ModelState.IsValid)
            {
                return View("RegisterCourse", courseView);
            }
            else
            {
                if (courseView.Id == 0)
                {
                    Course c = new Course
                    {
                        Title = courseView.Title,
                        Credits = courseView.Credits,
                        
                    };
                    icourse.InsertCourse(c);
                }
                else
                {
                    Course OneRegistryOfCourse = icourse.RegistryFindById(courseView.Id);
                    OneRegistryOfCourse.Title = courseView.Title;
                    OneRegistryOfCourse.Credits = courseView.Credits;
                    icourse.UpdateCourse(OneRegistryOfCourse);
                }
            }
            return RedirectToAction("CourseList");
        }
    }
}
