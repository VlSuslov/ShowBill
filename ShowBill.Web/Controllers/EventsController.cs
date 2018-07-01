using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowBill.Data;
using ShowBill.Models;
using ShowBill.Web.Models;
using ShowBill.Web.Models.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Web.Controllers
{
    public class EventsController : Controller
    {
        private IShowBillUnitOfWork uoW;
        private IMapper mapper;
        private IEventMetaRepository metaRepository;
        private readonly int _pageSize;

        public EventsController(IShowBillUnitOfWork uoW, IMapper mapper)
        {
            this.uoW = uoW;
            this.metaRepository = uoW.MetaRepository;
            this.mapper = mapper;
            this._pageSize = 10;
        }

        public IActionResult Main()
        {
            IQueryable<Event> data = this.metaRepository.GetAll();
            List<EventListItemViewModel> events = data.OrderBy(e => e.Raiting)
                .Take(_pageSize)
                .ProjectTo<EventListItemViewModel>()
                .ToList();

            ViewData["Filter"] = new Filter();
            ViewData["Pagination"] = new Pagination(data.Count(), 0, _pageSize);

            return View("Main", events);
        }

        [Route("Events/EventList")]
        public IActionResult EventList(Filter filter = null, int page = 0)
        {
            if (filter == null)
            {
                filter = new Filter();
            }
            IQueryable<Event> data = metaRepository.Get(filter.Type);
            if (!string.IsNullOrWhiteSpace(filter.Place))
            {
                data = data.Where(p => p.Place.Name.Contains(filter.Place));
            }
            if (filter.Date != null)
            {
                data = data.Where(p => p.Dates.Any(x => DateTime.Equals(x.DateTime.Date, filter.Date.Value.Date)));
            }
            List<EventListItemViewModel> events = data.OrderBy(e => e.Raiting)
                .Skip(page * _pageSize)
                .Take(_pageSize)
                .ProjectTo<EventListItemViewModel>()
                .ToList();

            ViewData["Filter"] = filter;
            ViewData["Pagination"] = new Pagination(data.Count(), page, _pageSize);

            return View("EventList", events);
        }

        [HttpGet]
        [Route("Events/{eventType}")]
        public IActionResult GetEventsByType([FromRoute]string eventType)
        {
            try
            {
                EventType type = GetEventCollectionType(eventType);
                IQueryable<Event> data = metaRepository.Get(GetEventCollectionType(eventType));
                List<EventListItemViewModel> events = data.OrderBy(e => e.Raiting)
                    .Take(_pageSize)
                    .ProjectTo<EventListItemViewModel>()
                    .ToList();

                ViewData["Filter"] = new Filter() { Type = type };
                ViewData["Pagination"] = new Pagination(data.Count(), 0, _pageSize);

                return View("EventList", events);
            }
            catch (ArgumentException)
            {
                return View("../Shared/Error");
            }
        }

        [Route("Events/Details/{id}")]
        public IActionResult Details(Guid id)
        {
            Event @event = this.metaRepository.FindById(id);
            EventViewModel model = ConvertEvent(@event);

            return View("Details", model);
        }

        [Route("Events/Map")]
        public IActionResult EventMap()
        {
            var events = this.metaRepository.GetAll()
                .Where(e => e.Dates.Any(d => d.DateTime >= DateTime.Now))
                .OrderBy(e => e.Raiting)
                .ProjectTo<EventOnMapViewModel>()
                .ToList();

            string serializedModel = JsonConvert.SerializeObject(events);

            return View("EventMap", serializedModel);
        }

        private EventViewModel ConvertEvent(Event @event)
        {
            switch (@event)
            {
                case Movie m: return this.mapper.Map<Movie, MovieViewModel>(@event as Movie);
                case Exhibition e: return this.mapper.Map<Exhibition, ArtistsEventViewModel>(@event as Exhibition);
                case Concert c: return this.mapper.Map<Concert, ArtistsEventViewModel>(@event as Concert);
                case Performance p: return this.mapper.Map<Performance, PerformanceViewModel>(@event as Performance);
                case Sport s: return this.mapper.Map<Event, EventViewModel>(@event);
                default: throw new ArgumentException();
            }
        }

        private EventType GetEventCollectionType(string type)
        {
            switch (type)
            {
                case "Movies": return EventType.Movie;
                case "Concerts": return EventType.Concert;
                case "Performances": return EventType.Performance;
                case "Exhibitions": return EventType.Exhibition;
                case "Sport": return EventType.Sport;
                default: throw new ArgumentException();
            }
        }       
    }
}