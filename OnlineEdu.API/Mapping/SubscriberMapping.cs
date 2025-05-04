using AutoMapper;
using OnlineEdu.DTO.DTOs.SubscriberDtos;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class SubscriberMapping:Profile
    {
        public SubscriberMapping()
        {
            CreateMap<UpdateSubscriberDto, Subscriber>().ReverseMap();
            CreateMap<CreateSubscriberDto, Subscriber>().ReverseMap();
        }
    }
}
