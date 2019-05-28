using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WłasnyProjekt
{
    public class User 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Training> listOfTrainings = new List<Training>();
        public List<Food> listOfFood = new List<Food>();

    }
}
