﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___ByteBank.Exception
{
    public class SaldoInsuficienteException : System.Exception
    {
         public SaldoInsuficienteException() : base () { }
         public SaldoInsuficienteException(string menssagem) : base(menssagem) { }
    }
}
