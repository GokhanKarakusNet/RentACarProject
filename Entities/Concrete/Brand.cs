﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    public class Brand:IEntity
    {
        public int  BrandId { get; set; }
        public string BrandName { get; set; }
        public string Image { get; set; }

    }
}
