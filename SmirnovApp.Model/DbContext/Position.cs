﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Должность.
    /// </summary>
    public class Position
    {
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }
    }
}
