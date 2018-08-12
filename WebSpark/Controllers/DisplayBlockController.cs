using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSpark.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSpark
{
    [Route("api/[controller]")]
    public class DisplayBlockController : Controller
    {


        DisplayBlock[] displayBlocks = {
            new DisplayBlock { Id = 1, Title = "Why smart people build better societies", Description = "How intelligence sparks cooperation", CategoryName = "Capital", ImageUrl = "https://finland.fi/wp-content/uploads/2018/07/DSC03655B.Hoang-Minh-Trang-1200x740.jpg", RedirectUrl = "https://bbc.com" },
            new DisplayBlock { Id = 2, Title = "How Harry Potter became a rallying cry", Description = "How JK rowlings novel have influenced the march for our live movements", CategoryName = "Culture", ImageUrl = "https://www.purefandom.com/wp-content/uploads/2017/04/636013879527247628-567764177_0a4de910-687c-0133-4d4a-0e3f8b958f63.jpg", RedirectUrl = "https://bbc.com"  },
            new DisplayBlock { Id = 3, Title = "When art meets Jewellery", Description = "Dali and Picasso are among the surprising names featured in Paris Exhibition", CategoryName = "Designed", ImageUrl = "http://www.bcn.cat/museupicasso/imatges/exposicions/Futures/pablo-picasso-contemplant-torre-eiffel-th.jpg", RedirectUrl = "https://bbc.com" }
      };

        // GET: api/displayBlock
        [HttpGet]
        public IEnumerable<DisplayBlock> Get()
        {
            return displayBlocks;
        }

    }
}
