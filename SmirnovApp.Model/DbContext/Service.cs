﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Услуга.
    /// </summary>
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType("money")]
        public decimal Cost { get; set; }
    }
}
