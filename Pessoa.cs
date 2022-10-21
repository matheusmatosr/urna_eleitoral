using System;

class Pessoa{

  //atributos
  private string nome;
  private string cpf;
  private int idade;

  public Pessoa(string nome, string cpf, int idade){
    this.nome = nome.ToUpper();
    
    if(cpf.Length!=11){
      this.cpf = "Inválido";
    } else {
      this.cpf = cpf;
    }

    if(idade>=16){
      this.idade = idade;
    } 
  }

  public string getNome(){
    return nome;
  }
  public void setNome(string n){
    nome = n.ToUpper();
  }

  public string getCpf(){
    return cpf;
  }
  public bool ValidaCpf(){
    if(cpf.Length == 11){
      return true;
    } 
    return false;
  }

  public int getIdade(){
    return idade;
  }
  public bool ValidaIdade(){
    if(idade >= 16){
      return true;
    } 
    return false;
  }
}