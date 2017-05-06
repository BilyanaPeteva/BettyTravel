﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Vacation;

namespace BettyTravel.Services
{
    public class HomeService : Service
    {
        public IEnumerable<AllVacationsViewModel> GetAllVacations()
        {
            IEnumerable<Vacation> vacations = this.Context.Vacations;
            IEnumerable<AllVacationsViewModel> allVacations =
                Mapper.Map<IEnumerable<Vacation>, IEnumerable<AllVacationsViewModel>>(vacations);
            return allVacations;

        }
    }
}