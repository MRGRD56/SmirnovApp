using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmirnovApp.Model.DbModels
{
    /// <summary>
    /// Человек.
    /// </summary>
    public abstract class Person
    {
        public int Id { get; set; }

        /// <summary>
        /// Фамилия.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество.
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения.
        /// </summary>
        [DataType("date")]
        public DateTime BirthDate { get; set; }

        public string FullName => $"{LastName} {FirstName} {Patronymic}";
    }
}
