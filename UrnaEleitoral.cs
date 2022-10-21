using System;
using System.Collections.Generic;

class UrnaEleitoral{
  
  Urna minha_urna;

  public UrnaEleitoral(){
    minha_urna = new Urna();
    minha_urna.setCor("branca");
    minha_urna.setAno(2022);
    minha_urna.setNumero_identificador(2);
  }

  public void MenuEleitoral(){
    
    int votos = 0;
    int idade;
    string nome, cpf;
    List<Pessoa> pessoas = new List<Pessoa>();

    Console.WriteLine("Bem vindo as eleições 2022!");
    Console.WriteLine("Informe a quantidade de pessoas que irão votar: ");
    votos = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= votos; i++){
      Console.WriteLine("Nome: ");
      nome = Console.ReadLine();
      Console.WriteLine("Cpf: ");
      cpf = Console.ReadLine();
      Console.WriteLine("Idade: ");
      idade = Convert.ToInt32(Console.ReadLine());
      Pessoa p = new Pessoa(nome, cpf, idade);
      pessoas.Add(p);
        
      if(p.ValidaIdade() == true && p.ValidaCpf() == true){
        Console.WriteLine("--------------- Eleições 2022 ---------------");
        Console.WriteLine("Características da urna:");
        minha_urna.ImprimeCaracteresUrna();
        Console.WriteLine("============== Urna eleitoral ===============");
        Console.WriteLine("Escolha o candidato para presidência da república.");
        Console.WriteLine("1 - Bolsonaro");
        Console.WriteLine("2 - Lula");
        Console.WriteLine("3 - Simone");
        minha_urna.computaVotos();
      } else{
        Console.WriteLine("500 | Internal error: pessoa com idade insuficiente ou cpf inválido!");
      }
    }
    minha_urna.ImprimeResultado();
  }
  
  public static void Main(string[] args){
    UrnaEleitoral votacao = new UrnaEleitoral();
    votacao.MenuEleitoral();
  }
}