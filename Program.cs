using System;

namespace Projetos_CursoAlura_Csharp_Introdutorio
{
    public class Program
    {
        static void Main (string[] agrs)
        {
            Console.WriteLine("Olá mundo, projeto 1 do curso do Alura yaaay");

            // sobre operações de matemática
            double idade;
            
            idade = 28;
            Console.WriteLine("Sua idade é " + idade);

            idade = 28 + 1;
            Console.WriteLine("Sua próxima idade será " + idade);

            idade = 28 + 1 * 2;
            Console.WriteLine("Daqui 2 anos você téra " + idade);

            idade = 29.0 / 2;
            Console.WriteLine("Sua próxima idade dividido por 2.0 será " + idade);

            idade = 29 / 2;
            Console.WriteLine("Sua próxima idade dividido por 2 será " + idade);

            idade = 28;
            Console.WriteLine("Sua próxima idade será " + idade + +1); // aqui ele dá o resultaod "281" porque ele junta "28"+"1"


            // sobre "casting" de uma varável (transformar um tipo de var em outra "na marra")
            double salario;
            salario = 1200.70;
            Console.WriteLine("Salário " + salario);

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine("Salário em inteiro " + salarioEmInteiro);

            // pode usar Float para Double de até 1 casa depois da vírgula Ex: 1.6 mas não 1.68 a não ser que coloque um "f" no fim (de float)
            // float alturaa = 1.68;
            float altura = 1.68f;
            Console.WriteLine("Minha altura é " + altura);


            // character    "char"   e como fazer o casting de un int e resultar em ASCII table
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Curso de Tecnologia " + 2022;
            string cursosProgramação = @" - .NET
- Java
- Javascript";  // por conta do @ antes da " " na linha 56
            Console.WriteLine(titulo);
            Console.WriteLine(cursosProgramação);


            // loops com if e boll
            int idadePedro = 16;
            int quantidadePessoas = 2;
            bool acompanhado = quantidadePessoas >= 2;
            // tbm poderia ser 'bool acompanhado = true'

            if ((idadePedro >= 18) && (acompanhado == true))
            {
                Console.WriteLine("Pode entrar na festa.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Está acompanhado, então pode entrar,");
                }
                else
                {
                    Console.WriteLine("Não pode entrar.");
                }
            }

            // controles de fluxo com if
            bool estaAcompanhado = false;
            string mensagemAdicional;
            if  (estaAcompanhado == true)
            {
                mensagemAdicional = "Pedro está acompanhado!";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "Pedro não está acompanhado e não pode entrar na festa.";
            }

            if (idadePedro >= 18 || estaAcompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine("Está acompanhado");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }


            // Laços de Repetição com While
            double valorInvestido = 1000;

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após um mês você terá " + valorInvestido);

            valorInvestido = valorInvestido + valorInvestido * 0.0036;
            Console.WriteLine("Após 2 meses você terá " + valorInvestido);

            // como fazer quando tem 12 meses?
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine($"Após {contadorMes} meses você terá R$ {valorInvestido} reais.");

                // contadorMes = contadorMes + 1;
                // contadorMes += 1;
                contadorMes++;
            }


            // Laços de Repetição com For
            double valorInvestido2 = 1000;

            for (int contadorMes2 = 1; contadorMes2 <= 12; contadorMes2 = contadorMes2 + 1)
            {
                valorInvestido2 = valorInvestido2 *= 1.0036;
                Console.WriteLine($"Após {contadorMes2} meses, você terá R$ {valorInvestido2} reais.");
            }

            //e quando o investimento dá um bônus por ano completo ?
            double valorInvestido3 = 1000;
            double fatorDeRendimento = 1.0036;

            for (double contadorAno =1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes2 = 1; contadorMes2 <= 12; contadorMes2 = contadorMes2 + 1)
                {
                    valorInvestido3 *= fatorDeRendimento;
                   
                }
                fatorDeRendimento += 0.0010;

            }
            Console.WriteLine("Ao término do investimento você terá R$" + valorInvestido3);


            // vamos usar a palabra 'break'
            //**
            ///***
            ////****
            /////*****
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                        break;
                }
                Console.WriteLine();
            }

            // o break tbm pode entrar direto na condição do if e tirar a necessidade dele dentro do { } onde criamos outro if
            // ajuda a deixar o código mais limpo e eficiente
            // matriz triangular com '*'
            for (int contadorLinha2 = 0; contadorLinha2 < 10; contadorLinha2++)
            {
                for (int contadorColuna2 = 0; contadorColuna2 <= contadorLinha2; contadorColuna2++)
                {
                    Console.Write("*");
                    //if (contadorColuna2 >= contadorLinha2) 
                        // break 
                }
                Console.WriteLine();
            }

            // Laço de Repetição For - taboada de cada número
            for (int multiplicador =1; multiplicador <=10; multiplicador++)
            {
                for (int contador = 0; contador <=10; contador++)
                {
                    Console.WriteLine(multiplicador + "*" + contador + "=" + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Laço de repetição For - matriz triangular usando 'break' implícito no for 'coluna ,+ 
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.
            // A.Usando operador '%' módulo que traz o resto da divisão  'if (numero % 3 === 0)'
            for (int numero = 1; numero <= 100; numero++)
            {

                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero);
                }
            }

            // B.Somando numero += 3
            for (int numero = 3; numero <= 100; numero+=3)
            {
                Console.WriteLine(numero);
            }

            // imprimir os fatoriais de 1 a 10 ----- 10! = 10*9*8*7*6*5*4*3*2*1
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial *= n;
                Console.WriteLine($"O fatorial de {n} é {fatorial}.");
            }





            Console.WriteLine("\nParabéns! Você chegou ao final do curso introdutório de C# da Alura!");
            Console.WriteLine("Aperte enter para sair.");
            
            Console.ReadKey();

        }
    }
}