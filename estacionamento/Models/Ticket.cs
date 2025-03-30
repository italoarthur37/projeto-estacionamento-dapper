using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento_dapper.Models
{
    public class Ticket
    {
        public int Id { get; set; } = default!;
        public DateTime DataEntrada { get; set; } = default!;
        public DateTime? DataSaida { get; set; }
        public float Valor { get; set; } = default!;
        public int VeiculoId { get; set; } = default!;
        public int VagaId { get; set; } = default!;
    }
}