using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace Projekt151.Data
{
    public class SqlConnectionConfiguration
    {
        public SqlConnectionConfiguration(string value) => Value = value;
        public string Value { get; }
    }
}
