using System;

namespace ValidadorExpressoes
{
    public class Expressao : Simbolo
    {
        public Simbolo Esquerda;
        public Simbolo Direita;

        public Operacoes Operador;
    }
}