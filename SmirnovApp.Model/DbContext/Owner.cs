using System;
using System.Collections.Generic;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Владелец.
    /// </summary>
    public class Owner : Person
    {
        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Дата обращения.
        /// </summary>
        public DateTime ApplicationDate { get; set; }
    }
}
