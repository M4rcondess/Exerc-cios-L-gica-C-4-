using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

    Double salarioporhora, salariototal, salario, valorHoraextra, salariosExtras, qtdHorasextras, nrohorastrabalhadasmes;

    Console.WriteLine("Digite as horas trabalhadas no mês");
    nrohorastrabalhadasmes = Double.Parse( Console.ReadLine());
    
    Console.WriteLine("Digite o salario por hora");
    salarioporhora = Double.Parse( Console.ReadLine());

    if (nrohorastrabalhadasmes < 160);

    {
     salario = nrohorastrabalhadasmes * salarioporhora;
     salariototal = salario;
      valorHoraextra = 0;
       }
    
     {
      salario = 160.0 * salarioporhora;
      qtdHorasextras = nrohorastrabalhadasmes - 160.0;
      valorHoraextra = salarioporhora + (salario + salarioporhora + 50)/100;
      salariosExtras = valorHoraextra + qtdHorasextras;
      salariototal = salario + salariosExtras;
      }
    Console.WriteLine("O salário do funcionario com hora extra foi de : " + salariototal + " reais ");
  }
}