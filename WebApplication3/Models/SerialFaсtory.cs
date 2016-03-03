﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class SerialFaсtory
    {
        public static IEnumerable<Serial> CreateSerials()
        {
            List<Serial> serials = new List<Serial>();
            serials.Add(new Serial()
            {
                Name = "Как избежать наказания за убийство",
                About =
                    "Профессор Эннализ Китинг — блестящий адвокат. Она преподает у студентов дисциплину под названием: «Как избежать наказания за убийство». Но те даже не подозревают, что в скором времени им придется применить свои знания в этой области в реальной жизни…",
                StartTime = "С 25 сентября 2014",
                Photo = "http://cdn2.thr.com/sites/default/files/2014/09/how_to_get_away_with_murder_cast.jpg",
            });
            serials.Add(new Serial()
            {
                Name = "Ходячие мертвецы",
                About =
                    "Сериал рассказывает историю жизни семьи шерифа после того, как «зомби» — эпидемия апокалиптических масштабов захлестнула земной шар. Шериф Рик Граймс путешествует со своей семьей и небольшой группой выживших в поисках безопасного места для жизни. Но постоянный страх смерти каждый день приносит тяжелые потери, заставляя героев почувствовать глубины человеческой жестокости. Рик пытается спасти свою семью, и открывает для себя, что всепоглощающий страх тех, кто выжил, может быть опаснее бессмысленных мертвецов, бродящих по земле.",
                StartTime = "С 31 октября 2010",
                Photo = "http://cdn.playbuzz.com/cdn/e553f8b7-d9c2-45f3-b585-116e75dac4a0/b23bb893-4790-4b6e-bac9-552ad3d0a099.jpeg"
            });
            serials.Add(new Serial()
            {
                Name = "Шерлок",
                About =
                    "События разворачиваются в наши дни. Он прошел Афганистан, остался инвалидом. По возвращении в родные края встречается с загадочным, но своеобразным гениальным человеком. Тот в поиске соседа по квартире. Лондон, 2010 год. Происходят необъяснимые убийства. Скотланд-Ярд без понятия, за что хвататься. Существует лишь один человек, который в силах разрешить проблемы и найти ответы на сложные вопросы.",
                StartTime = "С 25 июля 2010",
                Photo = "http://www.planetclaire.tv/wp-content/uploads/2014/01/sherlock-sherlock-holmes-season-3.jpg"
            });
            serials.Add(new Serial()
            {
                Name = "Доктор Кто",
                About =
                    "Сериал отображает приключения мистического инопланетянина-гуманоида называющего себя Доктор, без цели путешествующего через время и пространство в космическом корабле, который снаружи выглядит как полицейская будка 60-х годов. Доктор чрезвычайно эксцентричен и имеет невероятные знания в областях технологии, истории и науки. Он путешествует вместе со своими компаньонами, попутно борясь против космических злодеев и спасая Землю от бесчисленных врагов.",
                StartTime = "С 26 марта 2005",
                Photo = "http://johnlandondesigns.com/doctor_whoniverse/images/doctors/4.jpg"
            });
            serials.Add(new Serial()
            {
                Name = "Как я встретил вашу маму",
                About =
                    "«Как я встретил вашу маму» — комедия про Теда и про то, как он влюбился. Все неприятности начинаются с того, что лучший друг Теда, Маршалл, вдруг неожиданно сообщил, что он хочет сделать предложение своей давней подруге, Лили, воспитательнице детского сада. К тому времени Тед понимает, что ему нужно прилагать больше усилий, если он действительно надеется найти свою настоящую любовь. Помогает ему в этих поисках его друг Барни, убежденный холостяк, вечно со своим, иногда чересчур, мнением на все происходящее, со склонностью к костюмам и верным способом познакомиться с девушками. Когда Тед встречает Робин, он решает, что это любовь с первого взгляда, но у судьбы в запасе есть кое-что еще.",
                StartTime = "С 19 сентября 2005",
                Photo = "http://felixbird.com/wp-content/uploads/2015/10/how_2-1024x5761-1024x576.jpg"
            });

            return serials;
        }
    }
}