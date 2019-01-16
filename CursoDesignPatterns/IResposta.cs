﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public interface IResposta
    {
        void Responde(Requisicao requisicao, Conta conta);
        IResposta OutraResposta { get; set; }
    }
}
