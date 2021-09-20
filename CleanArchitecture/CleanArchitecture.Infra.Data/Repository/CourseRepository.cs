using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Domain.Models;
using CleanArchitecture.Infra.Data.Context;

namespace CleanArchitecture.Infra.Data.Repository
{
    public class CourseRepository: ICourseRepository
    {
        private readonly UniversityDbContext _universityDbContext;

        public CourseRepository(UniversityDbContext universityDbContext)
        {
            _universityDbContext = universityDbContext;
        }

        public IQueryable<Course> GetCourses()
        {
            return _universityDbContext.Courses;
        }

        public void Add(Course course)
        {
            _universityDbContext.Courses.Add(course);
            _universityDbContext.SaveChanges();
        }
    }
}
