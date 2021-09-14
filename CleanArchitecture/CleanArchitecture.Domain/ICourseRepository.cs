using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
