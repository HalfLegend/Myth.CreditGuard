using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Myth.CreditGuard.Sharp.Model.Entity
{
    [Table("Bank")]
    public class BankEntity
    {
        [PrimaryKey, AutoIncrement]
        public uint BankId { get; set; }
        public string BankName { get; set; }
        public string BankAbbr { get; set; }

    }
}
