using AutoMapper;
using CustomerRelations.Model;
using CustomerRelations.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerRelations.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new MapProfile());
            });
        }
    }

    internal class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<StringResource, StringResourceViewModel>().ReverseMap();
        }
    }
}