﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //Çıplak Class Kalmasın
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
