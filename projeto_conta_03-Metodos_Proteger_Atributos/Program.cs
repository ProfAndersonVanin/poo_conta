namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Conta Bancária");Conta conta = new Conta();

        conta.Limite = 500;

        conta.Deposita(1500); 
        conta.Deposita(2500);
        conta.Deposita(4500);
          
        double saldo = conta.ConsultaSaldo();
        
        Console.WriteLine("Seu saldo é de: " + saldo); //Aqui como ele está usando o método traz o saldo + limite
        Console.WriteLine("Seu saldo é de: " + conta.Saldo); //Aqui ele só pega o valor do saldo sem limite

        //Aqui temos um problema:
        //Projeto Conta Bancária
        //Seu saldo é de: 9000
        //Seu saldo é de: 8500

        //SOLUÇÃO: DEIXAR O ATRIBUTO SALDO DA CLASSE TODO PRIVATE.


                
    }
}
