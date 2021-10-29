using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidadorExpressoes
{
    public class Agrupador
    {
        public static Expressao Agrupar(List<Simbolo> Simbolos)
        {
            var expressao = new Expressao();

            int count = 0;

            while (!Simbolos.All(s => s is Expressao))
            {
                List<Simbolo> simbolos = new(Simbolos);
                for (int i = 0; i < simbolos.Count; i++)
                {
                    var maiorPrioridade = simbolos.Find(s => s is not Expressao && simbolos.IsMax(s));
                    //A IDEIA AGORA É PROCURARMOS O INDEX DO SIMBOLO DE MAIOR PRIORIDADE DA ESQUERDA PRA DIREITA
                    //E TRATARMOS ELA PRIMEIRO (PEGAR O -1 E +1)
                    //
                    var slice = simbolos.ToList().GetRange(count, 3);
                    expressao.Esquerda = slice[0];
                    expressao.Operador = (Operacoes)slice[1];
                    expressao.Direita = slice[2];

                    Simbolos = new(Simbolos.Except(slice));

                    Simbolos.Insert(0, expressao);
                    i += 3;
                }
            }
        }
    }
    public static class Extensions
    {
        public static bool IsMax<T>(this IEnumerable<T> collection, T Item) where T : class
        {
            return collection.Max() == Item;
        }
    }
}