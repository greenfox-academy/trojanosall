﻿using CalorieTableWebApp.Models;
using CalorieTableWebApp.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalorieTableWebApp.Controllers
{
    public class CalorieTableController : Controller
    {
        CalorieTableRepository CalorieTableRepository;


        public CalorieTableController(CalorieTableRepository calorieTableRepository)
        {
            CalorieTableRepository = calorieTableRepository;

        }

        [Route("/table")]
        [HttpGet]
        public IEnumerable<Food> GetAll()
        {
            return CalorieTableRepository.GetAllFood();
        }

        [Route("/table/{id}")]
        [HttpGet]
        public IActionResult GetById(int id)
        {

            var food = CalorieTableRepository.GetById(id);

            if (food == null)
            {
                return NotFound();
            }

            return new ObjectResult(food);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddFood([FromBody] Food food)
        {
            if (food.Name == null)
            {
                return BadRequest();
            }
            CalorieTableRepository.AddFood(food);

            return Ok(food);
        }

        [Route("/remove/{id}")]
        [HttpDelete]
        public IActionResult RemoveFood(int id)
        {
            var food = CalorieTableRepository.GetById(id);

            if (food == null)
            {
                return NotFound();
            }
            else
            {
                CalorieTableRepository.RemoveFood(food);
                return new NoContentResult();
            }
        }

        [HttpPut]
        [Route("/update/{id}")]
        public IActionResult UpdateAmount(int id, [FromBody] Food food, int amount)
        {
            if (food == null)
            {
                return BadRequest();
            }

            var foodToUpdate = CalorieTableRepository.GetById(id);
            if (foodToUpdate == null)
            {
                return NotFound();
            }
            else
            {
                CalorieTableRepository.UpdateFood(foodToUpdate, amount);
                return new NoContentResult();
            }
        }
    }
}
