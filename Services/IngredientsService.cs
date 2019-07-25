using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Barkeeper2.Models;
using Barkeeper2.Repositories;
using Barkeeper2.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Barkeeper2.Services
{
    public class IngredientsService : BaseService<Ingredient>
    {
        private readonly IngredientsRepository _ingredientsRepository;

        public IngredientsService(IngredientsRepository ingredientsRepository) : base(ingredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository;
        }

    }
}
