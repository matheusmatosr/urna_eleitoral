using System;
using System.Collections.Generic;

class Urna{
  private string cor;
  private int numero_identificador;
  private int ano;
  private string opcao;

  public Urna(){
    cor = "Branco";
    numero_identificador = 0;
    ano = 2022;
  }
  
  public Urna(string cor, int numero_identificador, int ano, string opcao){
    this.cor = cor;
    this.numero_identificador = numero_identificador;
    this.ano = ano;
    this.opcao = opcao;
  }

  public string getCor(){
    return cor;
  }
  public void setCor(string cor){
    this.cor = cor;
  }

  public int getNumero_identificador(){
    return numero_identificador;
  }
  public void setNumero_identificador(int numero_identificador){
    Random aleatorio = new Random();
    this.numero_identificador = aleatorio.Next();
  }

  public int getAno(){
    return ano;
  }
  public void setAno(int ano){
    this.ano = ano;
  }
  
  public void ImprimeCaracteresUrna(){
    Console.WriteLine($"Urna nº{numero_identificador} fabricada em {ano} de cor {cor}.", numero_identificador, ano, cor);
  }
  
  int bolsonaro = 0;
  int lula = 0;
  int simone = 0;
  int total_votos = 0;
  
  public void computaVotos(){
    Console.WriteLine("Informe o candidato desejado: ");
    string opcao = Console.ReadLine();
    switch (opcao){
      case "1":
        bolsonaro++;
        total_votos++;
      break;
      case "2":
        lula++;
        total_votos++;
      break;
      case "3":
        simone++;
        total_votos++;
      break;
    }
  }

  public void ImprimeResultado(){
    Console.WriteLine();
    Console.WriteLine("========== RESULTADO ELEIÇÃO ELEITORAL 2022 ==========");
    Console.WriteLine("------- Apuração de votos -------");
    Console.WriteLine();
    Console.WriteLine($"Total de votos => {total_votos}", total_votos);
    Console.WriteLine();
    Console.WriteLine($"Bolsonaro: {bolsonaro}", bolsonaro);
    Console.WriteLine($"Lula: {lula}", lula);
    Console.WriteLine($"Simone: {simone}", simone);
    Console.WriteLine();
    if(bolsonaro > lula && bolsonaro > simone){
      Console.WriteLine("✅ Vencedor da eleição >> Bolsonaro ✅");
    } else if(lula > bolsonaro && lula > simone){
      Console.WriteLine("✅ Vencedor da eleição >> Lula ✅");
    } else if(simone > lula && simone > bolsonaro){
      Console.WriteLine("✅ Vencedora da eleição >> Simone ✅");
    }
  }
}