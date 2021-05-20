using System;
using System.Collections.Generic;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client : Person
    {
        /// <summary>
        /// Дата обращения.
        /// </summary>
        public DateTime ApplicationDate { get; set; }
    }
}
