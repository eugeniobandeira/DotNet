

namespace ModificadorRef
{
    class Calculator
    {
        //Sem o ref, a variável vai perder o valor na memória e não trará o resultado, vai acabar trazendo o melhor valor de x
        public static void Triple(ref int x)
        {
            x *= 3;
        }

        /*Modificador out
        O modificador out é similar ao ref (faz o parâmetro ser uma referência para a variável original), mas não exige que
        a variável original seja iniciada.
        O resultado é guardado em outra variável e não na original.
        */
        public static void Doublee(int origin, out int result)
        {
            result = origin * 2;
        }

    }
}
