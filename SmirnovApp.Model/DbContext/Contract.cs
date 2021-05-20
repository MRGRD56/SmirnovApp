using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    /// <summary>
    /// Договор.
    /// </summary>
    public class Contract
    {
        public int Id { get; set; }

        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Сумма.
        /// </summary>
        [DataType("money")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Дата сделки.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Статус договора.
        /// </summary>
        public ContractStatus Status { get; set; }

        /// <summary>
        /// Клиент.
        /// </summary>
        public Client Client { get; set; }
        public int? ClientId;

        /// <summary>
        /// Сотрудник.
        /// </summary>
        public Employee Employee { get; set; }
        public int? EmployeeId;

        /// <summary>
        /// Владелец.
        /// </summary>
        public Owner Owner { get; set; }
        public int? OwnerId;

        /// <summary>
        /// Услуга.
        /// </summary>
        public Service Service { get; set; }
        public int? ServiceId;

        //???
    }
}
