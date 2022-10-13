﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho_3
{
    internal class Ordena
    {
        public static void bolha(List<int> lista)
        {
            int i, tmp;
            bool houveTroca;

            do
            {
                houveTroca = false;
                for (i = 0; i < lista.Count - 1; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
            } while (houveTroca);
        }


        public static void selecao(List<int> lista)
        {
            int i, j, tmp;
            int posMenor;

            for (i = 0; i < lista.Count - 1; i++)
            {
                posMenor = i;
                for (j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j] < lista[posMenor])
                    {
                        posMenor = j;
                    }
                }

                if (i != posMenor)
                {
                    tmp = lista[i];
                    lista[i] = lista[posMenor];
                    lista[posMenor] = tmp;
                }
            }
        }

        public static void insercao(List<int> lista)
        {
            int i, j;
            int tmp;

            for (i = 1; i < lista.Count; i++)
            {
                tmp = lista[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (tmp < lista[j])
                    {
                        lista[j + 1] = lista[j];
                    }
                    else break;
                }
                lista[j + 1] = tmp;
            }
        }

        public static void agitacao(List<int> lista)
        {
            bool houveTroca;
            int tmp;
            int i, ini = 0, fim = lista.Count - 1;

            do
            {

                houveTroca = false;
                for (i = ini; i < fim; i++)
                {
                    if (lista[i] > lista[i + 1])
                    {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + 1];
                        lista[i + 1] = tmp;
                    }
                }
                fim--;

                if (!houveTroca)
                {
                    break;
                }


                houveTroca = false;
                for (i = fim; i > ini; i--)
                {
                    if (lista[i] < lista[i - 1])
                    {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i - 1];
                        lista[i - 1] = tmp;
                    }
                }
                ini++;

            } while (houveTroca && ini <= fim);
        }

        public static void pente(List<int> lista)
        {
            int i, tmp, distancia = lista.Count;
            bool houveTroca;

            do
            {
                distancia = (int)((float)distancia / 1.3);
                if (distancia < 1) distancia = 1;

                houveTroca = false;
                for (i = 0; i < lista.Count - distancia; i++)
                {
                    if (lista[i] > lista[i + distancia])
                    {
                        houveTroca = true;
                        tmp = lista[i];
                        lista[i] = lista[i + distancia];
                        lista[i + distancia] = tmp;
                    }
                }
            } while (distancia > 1 || houveTroca);
        }

        public static void shell(List<int> lista)
        {
            int i, j, distancia = 1;
            int tmp;
            int referenciaTamanho = 3;

            do
            {
                distancia = referenciaTamanho * distancia + 1;
            } while (distancia < lista.Count);

            do
            {
                distancia = (int)((float)distancia / referenciaTamanho);

                for (i = distancia; i < lista.Count; i++)
                {
                    tmp = lista[i];
                    for (j = i - distancia; j >= 0; j = j - distancia)
                    {
                        if (tmp < lista[j])
                        {
                            lista[j + distancia] = lista[j];
                        }
                        else break;
                    }
                    lista[j + distancia] = tmp;
                }

            } while (distancia > 1);
        }

        private static int posicionaPivo(List<int> lista, int ini, int fim)
        {
            int pivo;
            int tmp;
            Random r = new Random();
            pivo = r.Next(ini, fim);
            while (fim > ini)
            {

                for (; fim > pivo && lista[fim] > lista[pivo]; fim--) ;

                if (fim > pivo)
                {
                    tmp = lista[pivo];
                    lista[pivo] = lista[fim];
                    lista[fim] = tmp;
                    pivo = fim;
                }

                for (ini++; ini < pivo && lista[ini] < lista[pivo]; ini++) ;

                if (ini < pivo)
                {
                    tmp = lista[pivo];
                    lista[pivo] = lista[ini];
                    lista[ini] = tmp;
                    pivo = ini;
                }
            }
            return pivo;
        }
        public static void heapSort(List<int> lista)
        {
            int tmp;
            int i;
            int n = lista.Count;


            while (n > 1)
            {
                for (i = (int)n / 2; i > 0; i--)
                {
                    if (lista[i] < lista[i * 2])
                    {
                        tmp = lista[i];
                        lista[i] = lista[i * 2];
                        lista[i * 2] = tmp;
                    }
                    if (i * 2 + 1 <= n)
                    {
                        if (lista[i] < lista[i * 2 + 1])
                        {
                            tmp = lista[i];
                            lista[i] = lista[i * 2 + 1];
                            lista[i * 2 + 1] = tmp;
                        }
                    }
                }
                tmp = lista[1];
                lista[1] = lista[n - 1];
                lista[n - 1] = tmp;
                n--;
            }

        }
        public static void quick(List<int> lista, int ini, int fim)
        {
            int pivo;

            pivo = posicionaPivo(lista, ini, fim);

            if (ini < pivo - 1)
                quick(lista, ini, pivo - 1); //se existe lado esq do pivo, executa lado esq
            if (pivo + 1 < fim)
                quick(lista, pivo + 1, fim); //se existe lado dir do pivo, executa lado dir
        }

        
    }
}
