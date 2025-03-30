using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_dapper.Models
{
    public class Vaga
    {
        public int Id { get; set; } = default!;
        public string CodigoLocalizacao { get; set; } = default!;
        public bool Ocupada { get; set; } = default!;
    }
}