using System;
using System.Collections.Generic;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Вид недвижимости.
    /// </summary>
    public class EstateType
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
