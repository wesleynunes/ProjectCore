using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCore.Domain.Eventos.Commands
{
    public class BaseEventoCommand
    {
        public string Nome { get; private set; }

        public DateTime DataInicio { get; private set; }

        public DateTime DataFim { get; private set; }

        public bool Gratuito { get; private set; }

        public decimal Valor { get; private set; }

        public bool Online { get; private set; }

        public string NomeEmpresa { get; private set; }
    
    }
}
