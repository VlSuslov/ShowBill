using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShowBill.Data;
using ShowBill.Logic;
using ShowBill.Models;
using ShowBill.Models.EventModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowBill.Controllers
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
            List<Event> events = data.OrderBy(e => e.Raiting).Take(_pageSize).ToList();
            List<EventListItemViewModel> model = this.mapper.Map<List<Event>, List<EventListItemViewModel>>(events);

            ViewData["Filter"] = new Filter();
            ViewData["Pagination"] = new Pagination(data.Count(), 0, _pageSize);

            return View("Main", model);
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
            List<Event> events = data.OrderBy(e => e.Raiting).Skip(page * _pageSize).Take(_pageSize).ToList();
            List<EventListItemViewModel> model = this.mapper.Map<List<Event>, List<EventListItemViewModel>>(events);

            ViewData["Filter"] = filter;
            ViewData["Pagination"] = new Pagination(data.Count(), page, _pageSize);

            return View("EventList", model);
        }

        [HttpGet]
        [Route("Events/{eventType}")]
        public IActionResult GetEventsByType([FromRoute]string eventType)
        {
            try
            {
                EventType type = GetEventCollectionType(eventType);
                IQueryable<Event> data = metaRepository.Get(type);
                List<Event> events = data.OrderBy(e => e.Raiting).Take(_pageSize).ToList();
                List<EventListItemViewModel> model = this.mapper.Map<List<Event>, List<EventListItemViewModel>>(events);

                ViewData["Filter"] = new Filter() { Type = type };
                ViewData["Pagination"] = new Pagination(data.Count(), 0, _pageSize);

                return View("EventList", model);
            }
            catch (ArgumentException)
            {
                return View("../Shared/Error");
            }
        }

        [Route("Events/Details/{id}")]
        public IActionResult Details(Guid id)
        {
            Event data = this.metaRepository.FindById(id);
            EventViewModel model = ConvertEvent(data);

            return View("Details", model);
        }

        [Route("Events/Map")]
        public IActionResult EventMap()
        {
            IQueryable<Event> events = this.metaRepository.GetAll().Where(e => e.Dates.Any(d => d.DateTime >= DateTime.Now)).OrderBy(e => e.Raiting);
            List<EventOnMapViewModel> model = this.mapper.Map<List<Event>, List<EventOnMapViewModel>>(events.ToList());
            string serializedModel = JsonConvert.SerializeObject(model);

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

        private void Initialize()
        {
            metaRepository.ExhibitionRepository.Create(new Exhibition
            {
                Title = "Exhibition",
                Descriprion = "Exhibition",
                Place = new Place
                {
                    Latitude = 1.256,
                    Longitude = 0.457,
                    Name = "Place"
                },
                Cost = 300,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url=@".\wwwroot\images\banner1.svg"
                    },
                      new Photo
                    {
                        Url=@".\wwwroot\images\banner1.svg"
                    }
                },
                Raiting = 1,
                Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,07,11)
                    },
                     new Date
                    {
                         DateTime = new DateTime(2018,07,12)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2018,07,13)
                    },
                       new Date
                    {
                         DateTime = new DateTime(2018,07,14)
                    },
                     new Date
                    {
                         DateTime = new DateTime(2018,07,15)
                    }
                },
                Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(10,0,0)
                    },
                     new TimePeriod
                    {
                        Time=new TimeSpan(18,0,0)
                    }
                },
                Artists = new List<Person>
                {
                    new Person
                    {
                        Name="Adam Ciolkovsky"
                    }
                }
            });
            metaRepository.ConcertRepository.Create(new Concert
            {
                Title = "Concert",
                Descriprion = "Concert",
                Place = new Place
                {
                    Latitude = 1.456,
                    Longitude = 1.27,
                    Name = "Place"
                },
                Cost = 400,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url=@".\wwwroot\images\banner2.svg"
                    },
                      new Photo
                    {
                        Url=@".\wwwroot\images\banner1.svg"
                    },
                       new Photo
                    {
                        Url=@".\wwwroot\images\banner3.svg"
                    }
                },
                Raiting = 2,
                Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,06,21)
                    }
                },
                Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(19,30,0)
                    }
                },
                Artists = new List<Person>
                {
                    new Person
                    {
                        Name="Band"
                    }
                }
            });
            metaRepository.SportRepository.Create(new Sport
            {
                Title = "Sport",
                Descriprion = "Sport",
                Place = new Place
                {
                    Latitude = 0.446,
                    Longitude = 1.127,
                    Name = "Place"
                },
                Cost = 0,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url=@".\wwwroot\images\banner2.svg"
                    },
                      new Photo
                    {
                        Url=@".\wwwroot\images\banner1.svg"
                    }
                },
                Raiting = 4,
                Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,08,11)
                    }
                },
                Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(12,30,0)
                    }
                }
            });
            metaRepository.PerformanceRepository.Create(new Performance
            {
                Title = "Performance",
                Descriprion = "Performance",
                Place = new Place
                {
                    Latitude = 0.546,
                    Longitude = 1.127,
                    Name = "Place"
                },
                Cost = 300,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url=@".\wwwroot\images\banner1.svg"
                    },
                      new Photo
                    {
                        Url=@".\wwwroot\images\banner1.svg"
                    }
                },
                Raiting = 4,
                Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2012,08,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2012,08,12)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2012,08,13)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2012,08,14)
                    }
                },
                Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(19,30,0)
                    }
                },
                Actors = new List<Person>
                {
                    new Person
                    {
                        Name="Jhon Howard"
                    },
                    new Person
                    {
                        Name="Michael Brighton"
                    },
                    new Person
                    {
                        Name="Phillipe Delacroix"
                    }
                },
                Director = new Person
                {
                    Name = "Stuart Hordon"
                },
                Authors = new List<Person>
                {
                    new Person
                    {
                        Name="Jean-Marie La Platière"
                    },
                    new Person
                    {
                        Name="Louis Philipson"
                    }
                }
            });
            metaRepository.MovieRepository.Create(new Movie
            {
                Title = "Movie",
                Descriprion = "Movie",
                Place = new Place
                {
                    Latitude = 0.236,
                    Longitude = 2.113,
                    Name = "Place"
                },
                Cost = 300,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url=@".\wwwroot\images\banner3.svg"
                    },
                      new Photo
                    {
                        Url=@".\wwwroot\images\banner2.svg"
                    }
                },
                Raiting = 3,
                Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,08,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2012,08,12)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2012,08,13)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2012,08,14)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2012,08,15)
                    },
                        new Date
                    {
                         DateTime = new DateTime(2012,08,16)
                    }
                },
                Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(11,30,0)
                    },
                    new TimePeriod
                    {
                        Time=new TimeSpan(13,30,0)
                    },
                    new TimePeriod
                    {
                        Time=new TimeSpan(15,30,0)
                    },
                     new TimePeriod
                    {
                        Time=new TimeSpan(17,30,0)
                    },
                       new TimePeriod
                    {
                        Time=new TimeSpan(19,30,0)
                    }
                },
                Actors = new List<Person>
                {
                    new Person
                    {
                        Name="Hugh Robinson"
                    },
                    new Person
                    {
                        Name="Michael Pierce"
                    },
                    new Person
                    {
                        Name="Daniel Jefferson"
                    },
                    new Person
                    {
                        Name="Christopher Warren"
                    }
                },
                Director = new Person
                {
                    Name = "Samuel Lee"
                },
                Composers = new List<Person>
                {
                    new Person
                    {
                        Name="David Cartman"
                    }
                },
                Screenwriters = new List<Person>
                {
                    new Person
                    {
                        Name="Garry Bronson"
                    },
                    new Person
                    {
                        Name="Carl McKCinton"
                    }
                },
                Producers = new List<Person>
                {
                    new Person
                    {
                        Name="Jason Coleman"
                    },
                    new Person
                    {
                        Name="Andrew Garcia Marquez"
                    }
                }
            });
            uoW.Save();
        }
    }
}