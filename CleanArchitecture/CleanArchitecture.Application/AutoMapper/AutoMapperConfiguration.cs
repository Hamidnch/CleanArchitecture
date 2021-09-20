﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CleanArchitecture.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMapping()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ViewModelToDomainProfile());
                cfg.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
