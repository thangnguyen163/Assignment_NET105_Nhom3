﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_NET105_Nhom3_Shared.ViewModels
{
    public class ProductViewModels_Show
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int Status { get; set; }

    }
}
