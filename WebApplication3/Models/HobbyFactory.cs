using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class HobbyFactory
    {
        public static IEnumerable<Hobby> CreateHobbies()
        {
            List<Hobby> hobbies = new List<Hobby>();
            hobbies.Add(new Hobby()
            {
                HobbyName = "играть на гитаре",
                StartYear = "2009",
            });
            hobbies.Add(new Hobby()
            {
                HobbyName = "рисование (как в графичеких редакторах, так и на бумаге)",
                StartYear = "2012",
            });
            hobbies.Add(new Hobby()
            {
                HobbyName = "английский язык",
                StartYear = "2013",
            });
            return hobbies;
        }
    }
}