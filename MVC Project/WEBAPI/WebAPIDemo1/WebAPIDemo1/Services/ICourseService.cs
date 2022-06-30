using System.Collections.Generic;
using WebAPIDemo1.Model;

namespace WebAPIDemo1.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllProducts();
        int AddCourse(Course Cour);
        int ModifyCourse(Course Cour);
        int DeleteCourse(int id);
    }
}
