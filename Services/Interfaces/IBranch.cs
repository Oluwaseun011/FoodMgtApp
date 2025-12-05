using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryApp.Models.Entities;
using FoodMgtApp.Dtos;
using FoodMgtApp.Repositories.Interfaces;

namespace FoodMgtApp.Services.Interfaces
{
    public interface IBranchService
    {

        public RegisterBranchResponse? Create(RegisterBranchRequest registerBranchRequest);

    }
}