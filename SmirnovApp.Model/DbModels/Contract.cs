using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Text;

namespace SmirnovApp.Model.DbModels
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
        public virtual Client Client { get; set; }
        public int ClientId { get; set; }

        /// <summary>
        /// Сотрудник.
        /// </summary>
        public virtual Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        ///// <summary>
        ///// Владелец.
        ///// </summary>
        //public Owner Owner { get; set; }
        //public int OwnerId;

        /// <summary>
        /// Услуга.
        /// </summary>
        public virtual Service Service { get; set; }
        public int ServiceId { get; set; }
        
        /// <summary>
        /// Имущество.
        /// </summary>
        public virtual Estate Estate { get; set; }
        public int EstateId { get; set; }
    }
}
