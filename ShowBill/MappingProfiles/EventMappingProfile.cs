using AutoMapper;
using ShowBill.Data;
using ShowBill.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowBill.MappingProfiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            CreateMap<Event, EventViewModel>()
               .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
               .ForMember(ev => ev.Seanses, m => m.MapFrom(e => FormatSeanses(e.Seanses).ToList()))
               .ForMember(ev => ev.Place, m => m.MapFrom(e => e.Place.Name))
               .ForMember(ev => ev.Type, m => m.MapFrom(e => GetEventType(e)))
               .ForMember(ev => ev.Photos, m => m.MapFrom(e => e.Photos.Select(p => p.Url)));

            CreateMap<Event, EventOnMapViewModel>()
                .ForMember(enm => enm.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
                .ForMember(enm => enm.Photo, m => m.MapFrom(e => e.Photos[0].Url))
                .ForMember(enm => enm.Position, m => m.MapFrom(e => new Position { Lat = e.Place.Latitude, Lng = e.Place.Longitude }));
        }

        public EventType GetEventType(Event @event)
        {
            switch (@event)
            {
                case Movie m: return EventType.Movie;
                case Exhibition e: return EventType.Exhibition;
                case Concert c: return EventType.Concert;
                case Performance p: return EventType.Performance;
                case Sport s: return EventType.Sport;
                default: throw new Exception();
            }
        }

        public string FormatDate(List<Date> dates)
        {
            switch (dates.Count())
            {
                case 0: return null;
                case 1: return dates[0].DateTime.ToString("MM.dd hh:mm");
                case 2: return dates[0].DateTime.ToString("MM.dd") + " - " + dates[1].DateTime.ToString("MM.dd");
                default: return dates[0].DateTime.ToString("MM.dd") + " - " + dates[1].DateTime.ToString("MM.dd");
            }
        }

        public List<string> FormatSeanses(List<TimePeriod> times)
        {
            return times.Count() > 0 ? times.Select(x => x.Time.ToString(@"hh\:mm")).ToList() : null;
        }
    }
}

