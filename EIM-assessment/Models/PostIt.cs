﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EIM_assessment.Models
{
    public class PostIt
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }
    }
}
