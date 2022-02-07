using AutoMapper;
using CFS.Data.Domains;
using CFS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS.BusinessLogic.AutoMapper
{
    public class DataMappingProfile : Profile
    {
        public DataMappingProfile()
        {
            CreateMap<AccountList, AccountListViewModel>();
        }
    }
}
