using Italian.API.Models;

namespace Italian.API.Mapping
{
    public class PostModelsMappingProfile : Profile
    {
        public PostModelsMappingProfile() 
        {
            CreateMap<UserPostModel, User>();
        }
    }
}
