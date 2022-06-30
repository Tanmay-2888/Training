using System.Collections.Generic;
using WebAPIDemo1.Entities;
using WebAPIDemo1.Model;
using System;

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
                    context.Course.Remove(Cour);
                    context.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            public IEnumerable<Course> GetAllProducts()
            {
                return context.Course.ToList();
            }

            public int ModifyProduct(Course Cour)
            {
                var Course = context.Course.Where(p => p.Id == Cour.Id).SingleOrDefault();
                if (Course != null)
                {
                    Course.Name = Cour.Name;
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
