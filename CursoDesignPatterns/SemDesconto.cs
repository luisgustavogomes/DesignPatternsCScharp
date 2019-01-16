﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double Descontar(Orcamento orcamento)
        {
            return 0;
        }
    }
}
