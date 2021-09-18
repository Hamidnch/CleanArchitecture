using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Commands
{
    public class CreateCourseCommand: CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            this.Name = name;
            this.Description = description;
            this.ImageUrl = imageUrl;
        }
    }
}
