﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for(int i =0; i<tab.linhas; i++)
            {
                for (int j = 0; j < tab.colunas; j++)
                {
                    if(tab.peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.WriteLine(tab.peca(i, j) + " ");
                    }                   
                }
                Console.WriteLine();
            }
        }
    }
}