
/*
Convenções

- Camel Case: lastName(parâmetros de métodos, variáveis dentro de métodos)
- Pascal Case: LastName(namespaces, classe, properties e métodos)
- Padrão _lastName(atributos "internos" da classe)

Exemplo
*/

namespace Curso
{
    class ContaBancaria
    {
        public string Titular { get; set; }
        private double _saldo;

        public void Deposito(double quantia)
        {
            _saldo += quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }
    }
}
