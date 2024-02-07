using AutoMapper;
using EmployeeAPI.Models;

namespace EmployeeAPI.Mapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() { 
        
        CreateMap<Employee,EmployeeDto>().ReverseMap();
        CreateMap<Department,DepartmentDto>().ReverseMap();
        CreateMap<Employee, EmployeeViewDto>().ReverseMap();

        }
    }
}
