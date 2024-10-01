using AutoMapper;
using FashionStore.Application.DTOs;
using FashionStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionStore.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Product, ProductDTO>();
            CreateMap<Review, ReviewDTO>();
        }
    }
}
