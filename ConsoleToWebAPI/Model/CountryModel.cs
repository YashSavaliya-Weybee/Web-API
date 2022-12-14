using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Model
{
    public class CountryModel
    {
        [ModelBinder(typeof(CustomBinderCountryDetails))]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public int Area { get; set; }
    }
}
