﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Сотрудник.
    /// </summary>
    [Table("Employees")]
    public class Employee : Person
    {
        /// <summary>
        /// Зарплата.
        /// </summary>
        [DataType("money")]
        public decimal Salary { get; set; }

        /// <summary>
        /// Номер телефона.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Должность.
        /// </summary>
        public Position Position { get; set; }
        public int PositionId;

        ///// <summary>
        ///// Клиент.
        ///// </summary>
        //public Client Client { get; set; }
        //public int? ClientId;

        ///// <summary>
        ///// Владелец.
        ///// </summary>
        //public Owner Owner { get; set; }
        //public int? OwnerId;
    }
}
