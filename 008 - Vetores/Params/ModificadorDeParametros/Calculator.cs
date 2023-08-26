

namespace ModificadorDeParametros
{
    class Calculator
    {
        //Solução com vetor
        //Ao acrescentar o params antes do int na função, estamos dizendo que receberemos uma quantia variável de valores
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
