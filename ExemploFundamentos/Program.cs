using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_projetos_c_.ExemploFundamentos.Common.Models;


// Pessoa pessoal = new Pessoa();
// pessoal.Nome = "Vagner";
// pessoal.Idade = 29;
// pessoal.Apresentar();






// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção: ");  
//     Console.WriteLine("1 - Cadastrar Cliente ");
//     Console.WriteLine("2 - Buscar Cliente ");
//     Console.WriteLine("3 - Apagar Cliente ");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//         Console.WriteLine("Cadastro do Cliente");
//         break;

//         case "2":
//         Console.WriteLine("Busca de Cliente");
//         break;

//         case "3":
//         Console.WriteLine("Apagar Cliente");
//         break;

//         case "4":
//         Console.WriteLine("Encerrar");
//         exibirMenu = false;
//         // Enviroment.Exite(0);
//         break;

//         default:
//             Console.WriteLine("opção invalida");

//         break;

//     }
// }

// Console.WriteLine("O console encerrou");












// int soma = 0, numero = 0;


// do {

//     Console.WriteLine("Digite um numero (0 para parar): ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// }while (numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");






// int numero = 5;
// int contador = 0;


// while(contador <= 10)
// {

//     Console.WriteLine($"{contador + 1}º Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }







// int numero = 5;


// for (int contador = 0; contador <= 10; contador++ ){

//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }


// Calculadora calc = new Calculadora();


// calc.RaizQuadrada(9);

// int numeroImcremento = 10;

// Console.WriteLine(numeroImcremento);

// Console.WriteLine("Incrementando o 10");
// //numero = numero + 1;
// numeroImcremento++;

// Console.WriteLine(numeroImcremento);

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);

// numeroDecremento--;

// Console.WriteLine(numeroDecremento);


// calc.Coseno(30);
// calc.Seno(30);
// calc.Tangente(30);
// calc.Potencia(3, 3);
// calc.Somar(2, 5);
// calc.Subtrair(10, 50);
// calc.Dividir(50, 10);
// calc.Multiplicar(10, 9);










// int eMaiorDeIdade = Convert.ToInt32(Console.ReadLine());
// string possuiAutorizaçãoDoResponsavel = Console.ReadLine();

// if (eMaiorDeIdade >= 18)
// {

//         Console.WriteLine("Entrada Liberada");
// }
// else if (possuiAutorizaçãoDoResponsavel == "sim")
//        {
//          Console.WriteLine("Entrada Liberada");
//        }
//        else {
//         Console.WriteLine("Entrada não Liberada");
//        }






// Console.WriteLine("Digite uma Letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//         case "a":
//         case "e":
//         case "i":
//         case "o":
//         case "u":
//         Console.Write("Vogal");
//         break;

//         default:
//         Console.WriteLine("Não é uma vogal");
//         break;

// }
















// static void Main(string[] args){

//         int n = int.Parse(Console.ReadLine());
//         int p = 1, s = 0;
//         while (n > 0){
//              int l = n % 10;
// // TODO: Crie as outras condições necessárias para a resolução do desafio:
//              p *= l;
//              s += n;
//              n /= n;
//            }

//            Console.WriteLine(p-s);
//         }
    



// Pessoa pessoa1 = new Pessoa(); 


// pessoa1.Nome = "Vagner";
// pessoa1.Idade = 29;
// pessoa1.Apresentar();

