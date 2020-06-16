﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAJAX.Models
{
    public class StudentModel
    {
        
            public int ID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string NameAddress { get; set; }
            public string Title { get; set; }
            public string LastName { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaModificacion { get; set; }
    }
}