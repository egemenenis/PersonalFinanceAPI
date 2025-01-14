using AutoMapper;
using PersonalFinanceAPI.Core.DTOs;
using PersonalFinanceAPI.Core.Entities;

namespace PersonalFinanceAPI.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Login, LoginDto>().ReverseMap();
            CreateMap<Transaction, TransactionDto>().ReverseMap();
            CreateMap<TransactionCategory, TransactionCategoryDto>().ReverseMap();
            CreateMap<Budget, BudgetDto>().ReverseMap();
            CreateMap<Saving, SavingDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}