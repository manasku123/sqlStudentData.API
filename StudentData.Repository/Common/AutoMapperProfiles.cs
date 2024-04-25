using AutoMapper;
using StudentData.Entity.Models;
using StudentData.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData.Repository.Common
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<StudentMaster, StudentModel>().ForMember(dest => dest.StudentSheet, opt => opt.MapFrom(src => src.SheetMasters));
            CreateMap<StudentMaster, StudentModel>().ForMember(dest => dest.StudentSheet, opt => opt.MapFrom(src => src.SheetMasters)).ReverseMap();

            CreateMap<SheetMaster, SheetModel>();
            CreateMap<SheetMaster, SheetModel>().ReverseMap();
        }
    }
}



