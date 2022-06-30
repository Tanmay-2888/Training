using System.Collections.Generic;
using WebAPIDemo1.Model;

namespace WebAPIDemo1.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourse();
        int AddCourse(Course Cour);
        int ModifyCourse(Course Cour);
        int DeleteCourse(int id);
    }
}
