using System;
using System.Collections.Generic;
using System.Text;

namespace SmirnovApp.Model.DbContext
{
    public enum ContractStatus
    {
        /// <summary>
        /// Услуга ещё не была оказана.
        /// </summary>
        NotPerformed,
        /// <summary>
        /// Услуга по договору оказана.
        /// </summary>
        ServiceProvided,
        /// <summary>
        /// Договор расторгнут.
        /// </summary>
        Terminated
    }
}
