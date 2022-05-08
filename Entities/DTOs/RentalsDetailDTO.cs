using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalsDetailDTO
    {
        public int Id { get; set; }
        public string CustomerCompany { get; set; }
        public int CarBrand { get; set; }
        public int CardColor { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
