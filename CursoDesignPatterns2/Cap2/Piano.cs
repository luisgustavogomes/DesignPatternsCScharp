﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns2.Cap2
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
