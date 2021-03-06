﻿using Microsoft.AspNetCore.Mvc;
using RedditWebApp.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RedditWebApp.Controllers
{
    public class RedditController : Controller
    {
        RedditRepository redditRepository;

        public RedditController(RedditRepository redditRepository)
        {
            this.redditRepository = redditRepository;
        }

        [HttpGet]
        [Route("")]
        [Route("/post")]
        public IActionResult Post()
        {
            return View(redditRepository.GetList());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string content)
        {
            redditRepository.AddReddit(content);
            return RedirectToAction("Post");
        }

        [Route("/delete/{id}")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            redditRepository.Delete(id);
            return RedirectToAction("Post");
        }

        [Route("/vote/up/{id}")]
        public IActionResult UpVote(int id)
        {
            redditRepository.Vote("up", id);
            return RedirectToAction("Post");
        }

        [Route("/vote/down/{id}")]
        public IActionResult DownVote(int id)
        {
            redditRepository.Vote("down", id);
            return RedirectToAction("Post");
        }
    }
}
