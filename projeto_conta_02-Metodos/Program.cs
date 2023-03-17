namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Conta Bancária");

        //Aqui vamos instanciar um objeto chamado conta1 a partir da Classe Conta
        Conta conta = new Conta();

        //Vamos atribuir um valor de limite para essa conta
        conta.Limite = 500;

        //Para começar vamos chamar o método Deposita para depositar um valor na conta e o saldo dela já ser atualizado
        conta.Deposita(1500); 
        conta.Deposita(2500);
        conta.Deposita(4500);

        //Depois que uma classe possui um método que seta e consulta valores dos atributos, não é mais necessário fazer a atribuição de um determinado atributo diretamente como foi feito na aula anterior. Ex:
        //conta.Saldo = 1500; ==> isso não é mais necessário
        //utilizamos os métodos para fazer as validações necessárias

        //veja o que acontece:
        conta.Saldo = 10; //ERRADO!!!      

        //Vamos chamar o método ConsultaSaldo e receber em uma variável local chamada saldo o valor disponível em saldo desse cliente
        double saldo = conta.ConsultaSaldo();
        //Agora para visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);

        

        
    }
}
