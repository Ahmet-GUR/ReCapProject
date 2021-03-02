﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Rental : IEntity
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDeta { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
