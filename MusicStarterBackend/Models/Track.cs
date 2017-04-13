﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStarterBackend.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime DateTime { get; set; }
        public float Rating { get; set; }
        
        public Author Author { get; set; }
    }
}
