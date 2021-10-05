using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente

    {
        public string Nome { get; set; }
        public string CPF 
        {
            get
            {
                return _cpf;
            }
                set
            {
                _cpf = value;
            }

        public string Profissao { get; set; }

    }
}
