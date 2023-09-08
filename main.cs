using System;

class Program {
  public static void Main (string[] args) {
    double  Nota1;
    double  Nota2;
    double  Nota3;
    double  Nota4;
    double  Nota5;
    double  media;
    double  final;
    double  recuperacao;
    double frequencia;
    // const double frequencia1 = 75;
    const double recuperacao1 = 0.25;

  

    string nome;

    Console.Write("Escreva seu nome: ");
    nome = Console.ReadLine(); 
    Console.WriteLine("Olá " + nome + "!!");
    Console.ReadKey();

    Console.WriteLine("Informe o primeiro valor da sua nota utilizando (.):");
    Nota1 = double.Parse( (Console.ReadLine() ));

    Console.WriteLine("Informe o segundo valor da sua nota utilizando o (.):");
    Nota2 = double.Parse( (Console.ReadLine() ));

    Console.WriteLine("Informe o terceiro valor da sua nota utilizando o (.):");
    Nota3 = double.Parse( (Console.ReadLine() ));
    
    Console.WriteLine("Informe o quarto valor da sua nota utilizando o (.):");
    Nota4 = double.Parse( (Console.ReadLine() ));

    Console.WriteLine("Informe o quinto valor da sua nota utilizando o (.):");
    Nota5 = double.Parse( (Console.ReadLine() ));

    media = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5)/5;

    recuperacao = recuperacao1 + media;
    final = recuperacao + media;
    
    Console.WriteLine("Resultado da media: " + media.ToString("0.0"));

    Console.WriteLine("Informe o valor da sua frequencia: ");
    frequencia = double.Parse( (Console.ReadLine() ));

    //frequencia = frequencia1 * frequencia;

    Console.WriteLine("Resultado da frequencia: " + frequencia.ToString("0.0") + "%");
    
    if((media > 5) && (frequencia >= 75)){
      Console.WriteLine("Aluno (a) " + nome + " aprovado (a)!! Com media de: "  + media.ToString("0.0") + "!! Com a frequencia de: " + frequencia + "%"); 
    }
    else{
      Console.WriteLine("Informe o valor da nota de recuperação utilizando o (.) ");
      recuperacao = double.Parse((Console.ReadLine() ));
      if((final < 5)  && (frequencia >= 75)){
        Console.WriteLine("Aluno (a) " + nome + " aprovado (a)!! Com media de: "  + media.ToString("0.0") + "!! Com a frequencia de: " + frequencia + "%");
      }
      else{
       Console.WriteLine("Aluno (a) " + nome + " reprovado (a)!! Com media de: " + media.ToString("0.0") + "!! Com a frequencia de: " + frequencia + "%");
        }
    }
  }
}