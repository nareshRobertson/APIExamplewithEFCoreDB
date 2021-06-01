using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using APIExamplewithEFCoreDB.Models;

namespace APIExamplewithEFCoreDB.DTO
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Course, CourseDTO>(); // means you want to map from Course to CourseDTO
            
        }
    }
}
