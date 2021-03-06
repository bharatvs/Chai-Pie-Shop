﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChaisPieShop.Models;
using ChaisPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChaisPieShop.Controllers
{
    public class HomeController : Controller
    {
        //change to check git 
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
