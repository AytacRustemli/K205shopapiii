﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entitties.Concrete;

namespace DataAccess.Abstract
{
    public interface IOrderTrackingDal : IEntityRepository<OrderTracking>
    {
    }
}
