using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Insurance_Drill.ViewModels
{
    public class InsuranceVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int? Total { get; set; }
    }
}