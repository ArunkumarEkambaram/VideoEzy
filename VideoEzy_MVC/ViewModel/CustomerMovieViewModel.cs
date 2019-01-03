using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VideoEzy_MVC.Models;

namespace VideoEzy_MVC.ViewModel
{
    public class CustomerMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}