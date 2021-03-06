using System.Collections.Generic;
using WebAPIDemo1.Model;
using WebAPIDemo1.Repositories;

namespace WebAPIDemo1.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _iCourseRepo;
        // Injecition of Dependancy using constructor
        public CourseService(ICourseRepository iCourseRepo)
        {
            _iCourseRepo = iCourseRepo;
        }
        public int AddCourse(Course Cour)
        {
            return _iCourseRepo.AddCourse(Cour);
        }
        public int DeleteCourse(int id)
        {
            return _iCourseRepo.DeleteCourse(id);
        }
        public IEnumerable<Course> GetAllCourse()
        {
            return _iCourseRepo.GetAllCourse();
        }
        public int ModifyCourse(Course Cour)
        {
            return _iCourseRepo.ModifyCourse(Cour);
        }
    }
}
