using AutoMapper;
using ShowBill.Web.Models;
using ShowBill.Models;
using ShowBill.Web.Models.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Web.MappingProfiles
{
    public class EventMappingProfile : Profile
    {
        public EventMappingProfile()
        {
            CreateMap<Event, EventViewModel>()
               .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
               .ForMember(ev => ev.Seanses, m => m.MapFrom(e => FormatSeanses(e.Seanses).ToList()))
               .ForMember(ev => ev.Type, m => m.MapFrom(e => GetEventType(e)))
               .ForMember(ev => ev.Photos, m => m.MapFrom(e => e.Photos.Select(p => p.Url)));

            CreateMap<Event, EventOnMapViewModel>()
                .ForMember(enm => enm.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
                .ForMember(enm => enm.Photo, m => m.MapFrom(e => e.Photos[0].Url))
                .ForMember(enm => enm.Position, m => m.MapFrom(e => new Position { Lat = e.Place.Latitude, Lng = e.Place.Longitude }));

            CreateMap<Event, EventListItemViewModel>()
               .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
               .ForMember(ev => ev.Place, m => m.MapFrom(e => e.Place.Name))
               .ForMember(ev => ev.Photo, m => m.MapFrom(e => e.Photos[0].Url));

            CreateMap<Movie, MovieViewModel>()
             .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
             .ForMember(ev => ev.Seanses, m => m.MapFrom(e => FormatSeanses(e.Seanses).ToList()))
             .ForMember(ev => ev.Type, m => m.MapFrom(e => GetEventType(e)))
             .ForMember(ev => ev.Photos, m => m.MapFrom(e => e.Photos.Select(p => p.Url)))
             .ForMember(ev => ev.Actors, m => m.MapFrom(e => e.Actors.Select(p => p.Name)))
             .ForMember(ev => ev.Director, m => m.MapFrom(e => e.Director.Name))
             .ForMember(ev => ev.Composers, m => m.MapFrom(e => e.Composers.Select(p => p.Name)))
             .ForMember(ev => ev.Screenwriters, m => m.MapFrom(e => e.Screenwriters.Select(p => p.Name)))
             .ForMember(ev => ev.Producers, m => m.MapFrom(e => e.Producers.Select(p => p.Name)));

            CreateMap<Performance, PerformanceViewModel>()
             .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
             .ForMember(ev => ev.Seanses, m => m.MapFrom(e => FormatSeanses(e.Seanses).ToList()))
             .ForMember(ev => ev.Type, m => m.MapFrom(e => GetEventType(e)))
             .ForMember(ev => ev.Photos, m => m.MapFrom(e => e.Photos.Select(p => p.Url)))
             .ForMember(ev => ev.Actors, m => m.MapFrom(e => e.Actors.Select(p => p.Name)))
             .ForMember(ev => ev.Director, m => m.MapFrom(e => e.Director.Name))
             .ForMember(ev => ev.Authors, m => m.MapFrom(e => e.Authors.Select(p => p.Name)));

            CreateMap<Exhibition, ArtistsEventViewModel>()
             .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
             .ForMember(ev => ev.Seanses, m => m.MapFrom(e => FormatSeanses(e.Seanses).ToList()))
             .ForMember(ev => ev.Type, m => m.MapFrom(e => GetEventType(e)))
             .ForMember(ev => ev.Photos, m => m.MapFrom(e => e.Photos.Select(p => p.Url)))
             .ForMember(ev => ev.Artists, m => m.MapFrom(e => e.Artists.Select(p => p.Name)));

            CreateMap<Concert, ArtistsEventViewModel>()
            .ForMember(ev => ev.Date, m => m.MapFrom(e => FormatDate(e.Dates)))
            .ForMember(ev => ev.Seanses, m => m.MapFrom(e => FormatSeanses(e.Seanses).ToList()))
            .ForMember(ev => ev.Type, m => m.MapFrom(e => GetEventType(e)))
            .ForMember(ev => ev.Photos, m => m.MapFrom(e => e.Photos.Select(p => p.Url)))
            .ForMember(ev => ev.Artists, m => m.MapFrom(e => e.Artists.Select(p => p.Name)));
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
                default: throw new ArgumentException();
            }
        }

        public string FormatDate(IList<Date> dates)
        {
            switch (dates.Count())
            {
                case 0: return null;
                case 1: return dates[0].DateTime.ToString("MM.dd hh:mm");
                case 2: return dates[0].DateTime.ToString("MM.dd") + " - " + dates[1].DateTime.ToString("MM.dd");
                default: return dates[0].DateTime.ToString("MM.dd") + " - " + dates[1].DateTime.ToString("MM.dd");
            }
        }

        public List<string> FormatSeanses(IList<TimePeriod> times)
        {
            return times.Count() > 0 ? times.Select(x => x.Time.ToString(@"hh\:mm")).ToList() : null;
        }
    }
}

