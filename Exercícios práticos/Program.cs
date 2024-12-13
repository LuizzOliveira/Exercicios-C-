
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

//Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas
//personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

Console.WriteLine("Informe o nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"\tOlá, {nome}! Seja muito bem vindo!");



//Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário
//e ao final exiba o nome completo.

Console.WriteLine("\nInforme seu primeiro nome: ");
String primeiroNome = Console.ReadLine();

Console.WriteLine("Informe seu sobre nome: ");
String segundoNome = Console.ReadLine();

Console.WriteLine($"\nNome completo:\n\t {primeiroNome} {segundoNome}");




// Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
//-A soma entre esses dois números;
//-A subtração entre os dois números;
//-A multiplicação entre os dois números;
//-A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
//-A média entre os dois números.

double numUm = 28.2;
double numDois = 18.2;
Console.WriteLine("\nOperações:");

Console.WriteLine($"  \n{numUm} + {numDois} = {numUm + numDois}");
Console.WriteLine($"  \n{numUm} - {numDois} = {numUm - numDois}");
Console.WriteLine($"  \n{numUm} x {numDois} = {numUm * numDois}");

if (numDois > 0)
{
    Console.WriteLine($"  \n{numUm} / {numDois} = {(numUm / numDois):F2}");

}
else
{
    Console.WriteLine("  O segndo número precisa ser maior que zero!");

}

Console.WriteLine($"  \nMédia {numUm} e {numDois} = {(numUm + numDois) / 2}");





//Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de
//caracteres que a palavra inserida tem.

Console.WriteLine("\nDigite uma palavra ou mais: ");

String? palavra = Console.ReadLine().Replace(" ", "");

Console.WriteLine($"\n  A palvra {palavra} tem {palavra.Length} caracteres.");



//Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
//-A placa deve ter 7 caracteres alfanuméricos;
//-Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
//-Os quatro últimos caracteres são números;

//Ao final, o programa deve exibir*** Verdadeiro***se a placa for válida e ***Falso * **caso contrário.

Console.Write("\nDigite a placa do veículo: ");
string placa = Console.ReadLine().ToUpper();

string padraoPlaca = @"^[A-Z]{3}[0-9]{4}$";

if (Regex.IsMatch(placa, padraoPlaca))
{
    Console.WriteLine("Placa válida!");
}
else
{
    Console.WriteLine("Placa inválida. O formato correto é: AAA1234");
}


//Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
//    -Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
//    - Apenas a data no formato "01/03/2024".
//    - Apenas a hora no formato de 24 horas.
//    - A data com o mês por extenso.

DateTime agora = DateTime.Now;
int escolha;

Console.WriteLine("\nEscolha o formato da data:");
Console.WriteLine("1 - Formato completo");
Console.WriteLine("2 - Data curta (DD/MM/AAAA)");
Console.WriteLine("3 - Hora (24 horas)");
Console.WriteLine("4 - Data com mês por extenso");
Console.Write("Digite sua opção: ");

if (int.TryParse(Console.ReadLine(), out escolha))
{
    switch (escolha)
    {
        case 1:
            Console.WriteLine(agora.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            break;
        case 2:
            Console.WriteLine(agora.ToString("dd/MM/yyyy"));
            break;
        case 3:
            Console.WriteLine(agora.ToString("HH:mm:ss"));
            break;
        case 4:
            Console.WriteLine(agora.ToString("dd MMMM yyyy"));
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
}




