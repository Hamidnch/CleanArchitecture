using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses()
                .ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = _mapper.Map<CreateCourseCommand>(courseViewModel);
                //new CreateCourseCommand(
                //courseViewModel.Name,
                //courseViewModel.Description,
                //courseViewModel.ImageUrl);
            _bus.SendCommand(createCourseCommand);
        }
    }
}
