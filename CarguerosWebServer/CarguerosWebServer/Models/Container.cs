﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarguerosWebServer.Models
{
    public class Container
    {
        public int idContainer { get; set; }

        public int route { get; set; }

        public int containerArrive { get; set; }
        
        public int maxWeight { get; set; }

        public int uses { get; set; }

        public String routeName { get; set; }

        public int idContainer_Manager { get; set; }
        
    }
}