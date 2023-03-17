namespace projeto_conta;
class Conta
{
    public double Saldo {get; private set;}  //alterando o set para private - O private é um modificador de acesso
    //Atributo Saldo é público, mas somente para get (consulta)
    //Assim apenas a classe Conta consegue setar um valor
    public double Limite {get;set;}
    public int Numero {get;set;}
    
    public void Deposita(double valor){
        this.Saldo += valor; 
    }
    
    public double ConsultaSaldo(){
        return this.Saldo + this.Limite;
    }
}
