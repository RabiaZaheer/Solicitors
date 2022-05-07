using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapper.Configuration;
using Solicitor.Models;

namespace Solicitor.App_Start
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
           
            Mapper.Initialize(cfg =>
            {
              
            });
        }
    }
}