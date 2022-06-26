using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solicitor.Models
{
    public class Country
    {
        public Country()
        {
            HashSet<Country> country = new HashSet<Country>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CountryID { get; set; }

        [StringLength(2)]
        public string Iso { get; set; }

        [StringLength(80)]
        public string Name { get; set; }

        [StringLength(80)]
        public string NiceName { get; set; }

        [StringLength(3)]
        public string Iso3 { get; set; }

        public short? NumCode { get; set; }

        public int? PhoneCode { get; set; }

    }
}