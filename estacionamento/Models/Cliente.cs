using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_dapper.Models
{
    public class Cliente
    {
        public int Id { get; set; } = default!;
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        
    }
}