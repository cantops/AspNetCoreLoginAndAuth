﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreLoginAndAuth.Models.ViewModels
{
    public class TreeModel
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Parent { get; set; }
    }
}
