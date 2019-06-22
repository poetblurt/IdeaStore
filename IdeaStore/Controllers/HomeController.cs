﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IdeaStore.EntityFramework.Data;
using Microsoft.AspNetCore.Mvc;
using IdeaStore.Models;

namespace IdeaStore.Controllers
{
   public class HomeController : Controller
   {
      private readonly ApplicationDbContext _dbContext;

      public HomeController(ApplicationDbContext dbContext)
      {
         _dbContext = dbContext;
      }

      public IActionResult Index()
      {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
