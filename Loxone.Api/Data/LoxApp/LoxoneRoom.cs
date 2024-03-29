﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Loxone.Api.Data.LoxApp
{
    public class LoxoneRoom
    {
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int DefaultRating { get; set; }
        public bool IsFavorite { get; set; }
        public int Type { get; set; }
    }
}
