using System;
using System.Collections.Generic;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Имущество.
    /// </summary>
    public class Estate
    {
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стоимость.
        /// </summary>
        public decimal Cost { get; set; }

        /// <summary>
        /// Площадь в м^2.
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// Количество этажей.
        /// </summary>
        public int FloorsCount { get; set; }

        /// <summary>
        /// Этаж.
        /// </summary>
        public int Floor { get; set; }

        /// <summary>
        /// Адрес, включая квартиру, если дом многоквартирный.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Вид недвижимости.
        /// </summary>
        public EstateType Type { get; set; }

        /// <summary>
        /// Владелец.
        /// </summary>
        public Owner Owner { get; set; }
        public int OwnerId;
    }
}
