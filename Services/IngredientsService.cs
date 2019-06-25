using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Barkeeper2.Models;
using Barkeeper2.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Barkeeper2.Services
{
    public class IngredientsService
    {
        private readonly IngredientsRepository _ingredientsRepository;
        public IngredientsService(IngredientsRepository repository)
        {
            _ingredientsRepository = repository;
        }

        public async Task<IEnumerable<Ingredient>> GetAllIngredients()
        {
            return await _ingredientsRepository.GetAllAsync();
        }

        //public async Task<ActionResult<Ingredient>> GetIngredientById(long Id)
        //{
        //    return await _ingredientsRepository.GetIngredientById(Id);
        //}


    }
}
