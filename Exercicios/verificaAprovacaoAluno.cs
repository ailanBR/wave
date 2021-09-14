using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Informe a nota do primeiro semestre: "); //Imprime na tela a mensagem : Informe a nota do primeiro semestre: 
		string nota_primeiro_semestre_texto = Console.ReadLine(); //Recebe o que foi digitado pelo usuario
		int nota_primeiro_semestre = int.Parse(nota_primeiro_semestre_texto); //Transforma o texto recebido do usuario no tipo inteiro
		
		Console.WriteLine("Informe a nota do segundo semestre: ");
		string nota_segundo_semestre_texto = Console.ReadLine();
		int nota_segundo_semestre = int.Parse(nota_segundo_semestre_texto);
		
		Console.WriteLine("Informe a nota do terceiro semestre: ");
		string nota_terceiro_semestre_texto = Console.ReadLine();
		int nota_terceiro_semestre = int.Parse(nota_segundo_semestre_texto);
		
		float total = nota_primeiro_semestre + nota_segundo_semestre + nota_terceiro_semestre; //Atribuindo a variável total a soma das notas
		float media = total / 3; //Calculando a média que é o resultado da divisão do total pela quantidade de notas recebidas
		
		Console.WriteLine("Média do aluno = " + media);
		
		if (media >= 5)
		{
			Console.WriteLine("Aluno Aprovado");
		}
		else 
		{
			Console.WriteLine("Aluno Reprovado");
		}
	}
}
