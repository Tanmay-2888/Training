using System.Collections.Generic;
using WebAPIDemo1.Entities;
using WebAPIDemo1.Model;
using System;
using System.Linq;

namespace WebAPIDemo1.Repositories
{
    public class CourseReporsitory
    {
        public class CourseRepositoy : ICourseRepository
        {
            RepositoriesContext context;
            public CourseRepositoy(RepositoriesContext context) //DI
            {
                this.context = context;
            }

            public int AddCourse(Course Cour)
            {
                context.Courses.Add(Cour);
                context.SaveChanges(); // update the data in DB
                return 1;
            }

            public int DeleteCourse(int id)
            {
                var Cour = context.Courses.Where(c => c.Id == id).SingleOrDefault();
                if (Cour != null)
                {
                    context.Courses.Remove(Cour);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            public IEnumerable<Course> GetAllCourse()
            {
                return context.Courses.ToList();
            }

            public int ModifyCourse(Course Cour)
            {
                var Course = context.Courses.Where(p => p.Id == Cour.Id).SingleOrDefault();
                if (Course != null)
                {
                    Course.CourseName = Cour.CourseName;
                    Course.Fee = Cour.Fee;
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
        }

    }
}
