﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public  void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salva");
        }
    }
}
