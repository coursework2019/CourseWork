﻿using AutoMapper;
using BAL.Interfaces;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Managers
{
    public class OrderCommoditiesManager: BaseManager,IOrderCommoditiesManager
    {
        public OrderCommoditiesManager(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {

        }
    }
}