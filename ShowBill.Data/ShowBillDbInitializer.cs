using Microsoft.EntityFrameworkCore;
using ShowBill.Models;
using System;
using System.Collections.Generic;

namespace ShowBill.Data
{
    public static class ShowBillDbInitializer
    {
        public static void Initialize(ShowBillDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();
            context.AddRange(
                new Exhibition
                {
                    Title = "In infinity ",
                    Descriprion = "Taking over the south wing of the louisiana museum of modern art, legendary japanese artist yayoi kusama presents her first comprehensive retrospective exhibition in scandinavia. ‘in infinity’ unfolds the artist’s oeuvre in chronological order, offering multiple works that embody her thematic and enduring fascination with cosmological and psychological spaces. visitors are welcomed into an artistic experience replete with polka-dotted rooms, inflatable habitats, mirrored dwellings and a pumpkin-lined courtyard, forming an immersive series of all-encompassing installations. entire rooms, walls, floors and ceilings of the louisiana are canvassed in soft forms and starkly contrasting dots in black, yellow, white and red, wrapping viewers within kusama’s boundless visual universe.",
                    Place = new Place
                    {
                        Latitude = 52.374131,
                        Longitude = 4.897950,
                        Name = "De Oude Kerk"
                    },
                    Cost = 300,
                    Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/exhibition1.jpeg"
                    },
                      new Photo
                    {
                        Url="/images/exhibition2.jpeg"
                    }
                },
                    Raiting = 1,
                    Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,08,11)
                    },
                     new Date
                    {
                         DateTime = new DateTime(2018,08,12)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2018,08,13)
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
                },
                new Exhibition
            {
                Title = "Dismaland",
                Descriprion = "At the end of august, british artist banksy opened a new exhibition called ‘dismaland’, set in the british seaside town of weston-super-mare. the sinister and immersive show, featuring work by damien hirst, jenny holzer and david shrigley — to name a few, occupied the remote site for a total of only five weeks. the ‘bemusement’ park’s official site warns of uneven floor surfaces, imagery unsuitable for small children and swearing. additionally, dismaland boasts three large galleries, a hand crafted miniature world by artist jimmy cauty and a gothic sculpture park in a tiny big top tent. installations include a masked figure sitting on carousel; an armour-plated riot control vehicle equipped with sniper posts, grenade launchers and now – a children’s slide; and an immersive sculpture of paparazzi photographing a dead cinderella after a  pumpkin coach crash.",
                Place = new Place
                {
                    Latitude = 52.375568,
                    Longitude = 4.893189,
                    Name = "INK Hotel Amsterdam MGallery by Sofitel"
                },
                Cost = 250,
                Photos = new List<Photo>
                 {
                    new Photo
                    {
                        Url="/images/exhibition3.jpg"
                    }
                 },
                Raiting = 1,
                Dates = new List<Date>
                 {
                    new Date
                    {
                         DateTime = new DateTime(2018,09,1)
                    },
                     new Date
                    {
                         DateTime = new DateTime(2018,09,2)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2018,09,3)
                    },
                       new Date
                    {
                         DateTime = new DateTime(2018,09,6)
                    },
                     new Date
                    {
                         DateTime = new DateTime(2018,09,7)
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
                        Time=new TimeSpan(17,30,0)
                    }
                 },
                Artists = new List<Person>
                 {
                    new Person
                    {
                        Name="Adam Ciolkovsky"
                    },
                      new Person
                    {
                        Name="Olafur Eliasson"
                    }
                 }
            },
                new Exhibition
            {
                Title = "Baroque baroque",
                Descriprion = "Within one of the most magnificent baroque edifices in vienna, olafur eliasson presents a significant selection of artworks from the private collections of thyssen-bornemisza art contemporary (TBA21) and juan and patricia vergez. the exhibition ‘baroque baroque’ — hosted inside the winter palace of prince eugene of savoy in the austrian capital — is sited beneath stunning gold-clad ceilings and within intricately ornamented rooms, offering a unique pairing of art, aesthetics, and world views from two vastly different time frames. surprising similarities between the danish-icelandic artist’s installations and their ornate surroundings become subtly evident; through the use of projections, shadows, and reflections, the artworks invite the viewer’s active participation by mirroring, fragmenting, and inverting their position within space.",
                Place = new Place
                {
                    Latitude = 52.375297,
                    Longitude = 4.887119,
                    Name = "Stichting August Kemme Fonds/ August Kemme Foundation"
                },
                Cost = 450,
                Photos = new List<Photo>
                 {
                    new Photo
                    {
                        Url="/images/exhibition4.jpg"
                    },
                       new Photo
                    {
                        Url="/images/exhibition5.jpg"
                    },
                       new Photo
                    {
                        Url="/images/exhibition6.jpg"
                    }
                 },
                Raiting = 1,
                Dates = new List<Date>
                 {
                    new Date
                    {
                         DateTime = new DateTime(2018,09,1)
                    },
                     new Date
                    {
                         DateTime = new DateTime(2018,09,2)
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
                        Time=new TimeSpan(17,30,0)
                    }
                 },
                Artists = new List<Person>
                 {
                      new Person
                    {
                        Name="Ela Bialkowska"
                    }
                 }
            },
                new Concert
              {
                  Title = "St. Lucia",
                  Descriprion = "St. Lucia puts on an incredible concert. It is always a coin toss on how awesome a band will sound live. They sound AMAZING. We traveled 4 hours to the concert and it was definitely not disappointing.",
                  Place = new Place
                  {
                      Latitude = 52.375056,
                      Longitude = 4.872561,
                      Name = "Amsterdam, Hugo de Grootplein"
                  },
                  Cost = 400,
                  Photos = new List<Photo>
                 {
                    new Photo
                    {
                        Url="/images/concert1.jpg"
                    },
                      new Photo
                    {
                        Url="/images/concert2.jpg"
                    },
                       new Photo
                    {
                        Url="/images/concert3.jpg"
                    }
                 },
                  Raiting = 2,
                  Dates = new List<Date>
                 {
                    new Date
                    {
                         DateTime = new DateTime(2018,09,21)
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
                        Name="St. Lucia"
                    }
                 }
              },
                new Concert
              {
                  Title = "Chris Young",
                  Descriprion = "Tennessee country crooner Chris Young got his start singing in the high school choir and performing at local clubs, but his career skyrocketed in 2006 thanks to reality television—more specifically, the fourth season of USA Network's Nashville Star. Upon winning the country-centric singing competition, Young walked away with an RCA Records contract and released a self-titled major label debut produced by Buddy Cannon later that same year. The neotraditional country singer and rhythm guitarist, who's also the grandson of 'Louisiana Hayride' performer Richard Yates, possesses a clear twang that can deliver a smooth ballad like his Top 40 single Tomorrow just as easily as it ...",
                  Place = new Place
                  {
                      Latitude = 52.372113,
                      Longitude = 4.863112,
                      Name = "Stichting Mimosa"
                  },
                  Cost = 400,
                  Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/concert4.jpg"
                    },
                      new Photo
                    {
                        Url="/images/concert5.jpg"
                    },
                       new Photo
                    {
                        Url="/images/concert6.jpg"
                    }
                },
                  Raiting = 2,
                  Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,09,24)
                    }
                },
                  Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(21,30,0)
                    }
                },
                  Artists = new List<Person>
                {
                    new Person
                    {
                        Name="Chris Young"
                    }
                }
              },
                new Sport
            {
                Title = "The 24 Hours of Le Mans",
                Descriprion = "Skill, speed, and stamina are the three s’s that mark the world’s best automobile race, the 24 Hours of Le Mans. The race, organized by Automobile Club de L’Ouest, bridges past and present on the automotive circuit.The competition is set on a non-permanent track at Circuit de la Sarthe near the city of Le Mans on the Sarthe River. Roughly 46 cars start the race, in a series of classes that include prototype high-performance vehicles, dedicated race cars, and street cars. The diversity of autos gives the race a mix of old-fashioned and modern competitors. The winner is the car, driven by a team of three drivers, that covers the greatest distance in 24 hours.The first Le Mans contest took place in May 1923; today it is held every June. The race begins at 4 p.m., and for 24 hours the sound of roaring engines fills 8 miles (13 kilometers) of French countryside",
                Place = new Place
                {
                    Latitude = 52.360378,
                    Longitude = 4.876091,
                    Name = "Vondelpark"
                },
                Cost = 0,
                Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/sport1.jpg"
                    },
                      new Photo
                    {
                        Url="/images/sport2.jpg"
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
                        Time=new TimeSpan(11,30,0)
                    }
                }
            },
                new Sport
           {
               Title = "World Cup Soccer",
               Descriprion = "Thirty-two nations play, but billions of people in countries all around the world drop everything they’re doing for a month every four years to see who claims the title of World Cup soccer champion.The teams that compete in the World Cup finals are those that emerge from a series of qualifying rounds played out over the prior three years. The tournament of tournaments is therefore a showcase of the finest squads from across the continents and hemispheres.It’s during the finals that the intense challenge begins. First, in a series of first-round games, each team plays the three rivals in its opening bracket. Teams get three points for each win, one point for a tie, and zero for a loss. ",
               Place = new Place
               {
                   Latitude = 52.377491,
                   Longitude = 4.886395,
                   Name = "The Pancake Bakery"
               },
               Cost = 10,
               Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/sport3.jpg"
                    },
                      new Photo
                    {
                        Url="/images/sport5.jpg"
                    }
                },
               Raiting = 4,
               Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,07,10)
                    }
                },
               Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(11,30,0)
                    }
                }
           },
                new Performance
          {
              Title = "People, Places & Things",
              Descriprion = "Rumors about Denise Gough’s Olivier Award–winning performance as the addict Emma — the center of Duncan Macmillan’s searing story of rehab, self-destruction, and self-deception — preceded her to Brooklyn. The words “tour de force” seemed attached to her name; comparisons to Mark Rylance’s performance-of-a-generation in Jerusalem abounded. The rumors were true. Gough was astounding. She gave a gut-wrenching unstable reaction of a performance — vulnerable, ugly, chaotic, desperate, almost mythic. Surrounded by top-notch fellow actors, and bolstered by the electric direction of Jeremy Herrin, she ripped open Macmillan’s clever play and created a real emotional masterpiece.",
              Place = new Place
              {
                  Latitude = 52.364015,
                  Longitude = 4.855018,
                  Name = "AH Postjesweg Albert Heijn"
              },
              Cost = 300,
              Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/performance1.jpg"
                    },
                      new Photo
                    {
                        Url="/images/performance2.jpg"
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
          },
                new Performance
         {
             Title = "Of Government / What the Constitution Means to Me",
             Descriprion = "Okay, so I’m cheating here, but these two pieces from Clubbed Thumb’s 2017 Summerworks series have stuck with me long into the colder months, engaged in a conversation with each other in my mind. Both Alex Borinsky’s soulful, searching Of Government (with its cast of almost 20 women of all ages and backgrounds) and Heidi Schreck’s witty, vulnerable, mostly monologue play tackled big questions by staying persistently small. Borinsky created a kind of civic pageant — a meditation on how we take care of ourselves as individuals and as societies — out of tinsel and craft paper, and Schreck grappled with ideas of inalienable rights and painful repression by taking a deep dive into her own history (as a child she used to give speeches about the Constitution to win prize money in American Legion Hall rhetoric competitions). In both pieces, the room was abuzz with both curiosity and compassion. Schreck and Borinsky found the political, and the powerful, in the personal.",
             Place = new Place
             {
                 Latitude = 52.366890,
                 Longitude = 4.896004,
                 Name = "De Kleine Komedie"
             },
             Cost = 310,
             Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/performance3.jpg"
                    },
                      new Photo
                    {
                        Url="/images/performance4.jpg"
                    },
                      new Photo
                    {
                        Url="/images/performance5.jpg"
                    }
                },
             Raiting = 2,
             Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,09,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,09,12)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,09,13)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,09,14)
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
         },
                new Performance
         {
             Title = "The Band’s Visit",
             Descriprion = "It just broke box-office records at the Barrymore, so it would seem that this avowedly different and delicate musical is getting the audiences it deserves. Adapted by Itamar Moses from the bittersweet indie film by Eran Kolirin (and with an exquisite score and lyrics by David Yazbek), The Band’s Visit tells the story of an Egyptian military band that, due to some mistranslation and a mistaken bus, ends up spending a single night in a sleepy little Israeli town. Unlikely material for a musical? Perhaps, but the show is all the more powerful for its intimacy, its lack of traditional glamour and glitz, and its gorgeous, unique musical idiom — a lush, playful homage to Arabic classical music that feels utterly fresh in the halls of Broadway.",
             Place = new Place
             {
                 Latitude = 52.369496,
                 Longitude = 4.893516,
                 Name = "TOBACCO Theater"
             },
             Cost = 118,
             Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/performance6.jpg"
                    },
                      new Photo
                    {
                        Url="/images/performance7.jpg"
                    },
                      new Photo
                    {
                        Url="/images/performance8.jpg"
                    }
                },
             Raiting = 3,
             Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,10,08)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,09)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,10)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,12)
                    }
                },
             Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(18,0,0)
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
         },
                new Performance
         {
             Title = "Frontiéres sans Frontières",
             Descriprion = "In a year and a country so committed to deadly earnestness, Phillip Howze’s delightfully dark satire of our penchant for tragedy porn — and our self-important desire to feel like morally superior global citizens — felt like a bracing gust of wind. This story of three young siblings living in the rubble of an unnamed war-torn country was at once visually striking (director Dustin Wills and scenic designer Mariana Sanchez Hernandez made magic out of literal trash), brilliantly acted (Emma Ramos as the oldest sibling, Win, was a revelation), linguistically acrobatic, and piercingly funny. Frontiéres is a whip-smart modern burlesque that deserves a wider audience.",
             Place = new Place
             {
                 Latitude = 52.369496,
                 Longitude = 4.893516,
                 Name = "TOBACCO Theater"
             },
             Cost = 122,
             Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/performance9.jpg"
                    },
                      new Photo
                    {
                        Url="/images/performance10.jpg"
                    },
                },
             Raiting = 1,
             Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,10,08)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,09)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,10)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,10,12)
                    }
                },
             Seanses = new List<TimePeriod>
                {
                    new TimePeriod
                    {
                        Time=new TimeSpan(18,0,0)
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
         },
                new Movie
        {
            Title = "UNDERWORLD: BLOOD WARS",
            Descriprion = "Focuses on a new and younger generation of vampires and werewolves who are locked in a seemingly never-ending battle between supernatural races.",
            Place = new Place
            {
                Latitude = 52.374730,
                Longitude = 4.861009,
                Name = "Stichting Cinema Sans Coeur"
            },
            Cost = 300,
            Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/movie1.jpg"
                    },
                      new Photo
                    {
                        Url="/images/movie2.jpg"
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
        },
                new Movie
        {
            Title = "GOD OF WAR",
            Descriprion = "The film is the story of how a Chinese general defeated Japanese pirates by using unique stratagems and maverick tactics.",
            Place = new Place
            {
                Latitude = 52.363373,
                Longitude = 4.883946,
                Name = "Pathé City"
            },
            Cost = 110,
            Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/movie3.jpg"
                    },
                      new Photo
                    {
                        Url="/images/movie4.jpg"
                    },
                      new Photo
                    {
                        Url="/images/movie5.jpg"
                    }
                },
            Raiting = 3,
            Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,11,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,11,12)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,11,13)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,11,14)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2018,11,15)
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
        },
                new Movie
        {
            Title = "THE GREATEST SHOWMAN",
            Descriprion = "Showman P.T. Barnum (Hugh Jackman) creates the Barnum & Bailey circus in 1881",
            Place = new Place
            {
                Latitude = 52.364946,
                Longitude = 4.881694,
                Name = "Cinecenter"
            },
            Cost = 150,
            Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/movie6.jpg"
                    },
                      new Photo
                    {
                        Url="/images/movie7.jpg"
                    },
                      new Photo
                    {
                        Url="/images/movie8.jpg"
                    }
                },
            Raiting = 3,
            Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2018,11,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,11,12)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,11,13)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2018,11,14)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2018,11,15)
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
        },
                new Movie
         {
             Title = "JIGSAW Make America Bleed Again.",
             Descriprion = "Bodies are turning up around the city, each having met a uniquely gruesome demise. As the investigation proceeds, evidence points to one man: John Kramer. But how can this be? The man known as Jigsaw",
             Place = new Place
             {
                 Latitude = 52.363063,
                 Longitude = 4.883073,
                 Name = "De Balie"
             },
             Cost = 150,
             Photos = new List<Photo>
                {
                    new Photo
                    {
                        Url="/images/movie9.jpg"
                    },
                      new Photo
                    {
                        Url="/images/movie10.jpg"
                    }
                },
             Raiting = 3,
             Dates = new List<Date>
                {
                    new Date
                    {
                         DateTime = new DateTime(2019,01,11)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2019,01,12)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2019,01,13)
                    },
                    new Date
                    {
                         DateTime = new DateTime(2019,01,14)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2019,01,15)
                    },
                      new Date
                    {
                         DateTime = new DateTime(2019,01,16)
                    }
                },
             Seanses = new List<TimePeriod>
                {

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
            context.SaveChanges();
        }
    }
}
