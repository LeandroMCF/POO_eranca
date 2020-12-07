using System;
using POO_eranca.classes;

namespace POO_eranca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancian-mos nossa subclasse
            PessoaFisica pf = new PessoaFisica();
            PessoaJuridica pj = new PessoaJuridica();
            string ops;

            Console.WriteLine($"Digite seu nome");
            pf.nome = Console.ReadLine();
            ConfirmandoEscrita(pf.nome);

            Console.WriteLine($"Digite seu CPF");
            pf.cpf = Console.ReadLine();
            ConfirmandoEscrita(pf.cpf);
            Console.WriteLine($"-----------------------\n{pf.DarBoasVindas(pf.nome)}");
            pf.ValidarCPF(pf.cpf);

            Console.WriteLine($"-----------------------\nSua empresa possui uma inscrição estadual?\n[S] Sim\n[N] Não");
            ops = Console.ReadLine();
            ops = ops.ToUpper();
            ConfirmandoSN(ops);
            switch (ops)
            {
                case "S":
                    Console.Write($"Digite o código da sua inscrição estadual: ");
                    pj.inscricaoEstadual = Console.ReadLine();
                    ConfirmandoEscrita(pj.inscricaoEstadual);
                    Console.WriteLine($"Inscrição estadual cadastrada.");
                    break;
            }
            Console.Write($"-----------------------\nEstamos quase acabando.\nDigte o codigo da sua inscrição Municipal:");
            pj.inscricaoMunicipal = Console.ReadLine();
            ConfirmandoEscrita(pj.inscricaoMunicipal);
            Console.WriteLine($"Inscrição Municipal cadastrada.\nEmpresa localizada!");

            //funções
            void ConfirmandoSN(string a){
                while (a != "S" && a != "N")
                {
                    Console.WriteLine($"Resposta inválida.\n[S] Sim\n[N] Não");
                    a = Console.ReadLine();
                    a = a.ToUpper();
                }
            } 

            void ConfirmandoEscrita(string a){
                while (a == ""){
                    Console.Write($"Você não digitou nada.\nDigite novamente: ");
                    a = Console.ReadLine();
                }
            }  
        }
    }
}
