﻿using ChaisPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaisPieShop.ViewModels
{
    public class PieListViewModel
    {
      public  IEnumerable<Pie> Pies { get; set; }
      public  string CurrentCategory { get; set; }
    }
}
