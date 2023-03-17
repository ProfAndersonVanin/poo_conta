namespace projeto_conta;
class Conta
{
    private double Saldo {get; set;}  //Tudo private
    public double Limite {get;private set;} //só set private
    public int Numero {get;set;}
    
    public void Deposita(double valor){
        this.Saldo += valor; 
    }
    
    public double ConsultaSaldo(){
        return this.Saldo + this.Limite;
    }

    //Adicionando método para atualizar um limite
    public void AdicionarLimite(double valor){
        this.Limite = valor; 
    }

    //Adicionando um método para Sacar
    public void Sacar(double valor){
        this.Saldo -= valor; 
        //Aqui ainda temos um problema que é o caso de sacar um valor que seja maior do que o disponível!!!
    }
}
