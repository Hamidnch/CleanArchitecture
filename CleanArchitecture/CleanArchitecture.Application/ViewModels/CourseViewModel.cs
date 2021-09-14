using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
