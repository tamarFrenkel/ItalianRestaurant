using Italian.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Italian.Core.Mapping
{
    public class MappingProfile : Profile
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}
