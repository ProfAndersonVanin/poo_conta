namespace projeto_conta;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto Conta Bancária");Conta conta = new Conta();

        //conta.Limite = 500; //Aqui também podemos criar um método na classe que adiciona este limite

        conta.AdicionarLimite(500);

        conta.Deposita(1500); 
        conta.Deposita(2500);
        conta.Deposita(4500);

        conta.Sacar(7000);
          
        double saldo = conta.ConsultaSaldo();
        
        Console.WriteLine("Seu saldo com limite é de: " + saldo);
        //Console.WriteLine("Seu saldo é de: " + conta.Saldo); //Aqui não temos mais acesso direto ao atributo Saldo

        Console.WriteLine("Seu limite é de: " + conta.Limite);

                        
    }
}
