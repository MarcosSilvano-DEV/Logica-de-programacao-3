using System;

namespace Aula_13_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a sua idade?: ");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18){
                Console.Write("Você gostaria de participar do time de CS GO? - Sim ou Não: ");
                string resposta = Console.ReadLine();
                if(resposta == "Sim"|| resposta == "sim"|| resposta == "SIM"){
                    Console.WriteLine("Compareça a secretaria - Falar com a SARA");
                }else{
                    Console.WriteLine("Ok,tenha um ótimo dia!");
                }
            }else{
                Console.Write("Você gostaria de participar do time de League of legends? Sim ou Não: ");
                string Resposta = Console.ReadLine();
                if(Resposta == "Sim"||Resposta == "sim"||Resposta == "SIM"){
                    Console.WriteLine("Compareça a secretaria - falar com Jucelino");
                }else{
                    Console.WriteLine("Muito obrigado!");
                }
            }
        }
    }
}
