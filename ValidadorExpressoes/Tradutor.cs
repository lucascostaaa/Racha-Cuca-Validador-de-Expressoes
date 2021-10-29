using System;
using System.Collections.Generic;

namespace ValidadorExpressoes
{
    public class Tradutor
    {
        public static Queue<Simbolo> Decodificar(string expressao)
        {
            var simbolos = new Queue<Simbolo>();
            int count = 0;
            var enumerator = expressao.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var caracter = enumerator.Current;
                if (caracter == ' ')
                    continue;

                int numberIndex = 0;
                bool IsNumero() => double.TryParse($"{caracter}", out _);
                while (IsNumero())
                {
                    count++;
                    enumerator.MoveNext();
                }

                if (numberIndex != 0)
                    simbolos.Enqueue(new Numero(Convert.ToDouble(expressao.Substring(count, count + numberIndex))));
                if (Operacoes.IsOperador(caracter))
                    simbolos.Enqueue(Operacoes.ToOperador(caracter));
                if (caracter == ')')
                    simbolos.Enqueue(Simbolo.ParentesesFecha);
                if (caracter == '(')
                    simbolos.Enqueue(Simbolo.ParentesesAbre);

                count++;

                //if (char.IsLetter(caracter))
                //    return new Incognita();
            }
            return simbolos;
        }
    }
}
