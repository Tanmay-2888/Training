using System.Collections.Generic;
using WebAPIDemo1.Model;

namespace WebAPIDemo1.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllProducts();
        int AddCourse(Course Cour);
        int ModifyProduct(Course Cour);
        int DeleteProduct(int id);
    }
}
