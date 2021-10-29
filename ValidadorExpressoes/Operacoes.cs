using System;

namespace ValidadorExpressoes
{
    public class Operacoes : Simbolo
    {
        public EOperador Operador;

        public Operacoes(EOperador operador)
        {
            Operador = operador;
        }

        public Numero Resolver(Numero n1, Numero n2)
        {
            switch (Operador)
            {
                case EOperador.Divisao: return new Numero(n1.numero / n2.numero);
                case EOperador.Multiplacacao: return new Numero(n1.numero * n2.numero);
                case EOperador.Adicao: return new Numero(n1.numero + n2.numero);
                case EOperador.Subtracao: return new Numero(n1.numero - n2.numero);
                case EOperador.Potenciacao: return new Numero(Math.Pow(n1.numero, n2.numero));
                default: throw new ArgumentException("Impossivel");
            }
        }

        public enum EOperador
        {
            Potenciacao,
            Multiplacacao,
            Divisao,
            Adicao,
            Subtracao
        }

        public static Operacoes ToOperador(char caracter)
        {
            switch (caracter)
            {
                case '/':
                    return new Operacoes(EOperador.Divisao);
                case '*':
                    return new Operacoes(EOperador.Multiplacacao);
                case '-':
                    return new Operacoes(EOperador.Subtracao);
                case '+':
                    return new Operacoes(EOperador.Adicao);
                case '^':
                    return new Operacoes(EOperador.Potenciacao);

                default: throw new ArgumentException("Exprodiu");
            }
        }
        public static bool IsOperador(char caracter)
        {
            try
            {
                ToOperador(caracter);
                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }
    }
}