using System;
using System.Collections.Generic;

namespace Dicionário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dicionário da Generation Brasil\n");

            Dictionary<string, string> mentalidades = new Dictionary<string, string>();

            mentalidades.Add("Persistência: ", "Continuar tentando, vez após vez");
            mentalidades.Add("Mentalidade de crescimento: ", "Acreditar que suas competências mais básicas podem ser desenvolvidas através de dedicação e trabalho árduo");
            mentalidades.Add("Responsabilidade pessoal: ", "Assumir responsabilidade por suas próprias ações, trabalhando arduamente, mantendo seus compromissos e não dando desculpas");
            mentalidades.Add("Orientação ao futuro: ", "Estabelecer metas para o seu futuro, compreender como as ações de hoje impactam nessas metas e verificar seu progresso com frequência");

            Dictionary<string, string> habilidades = new Dictionary<string, string>();
            habilidades.Add("Comunicação: ", "Capacidade de expressar ideias de forma clara e concisa, com linguagem apropriada ao público, assim como ouvir com atenção, manter contato visual com seus interlocutores e tomar notas ao receber novas informações");
            habilidades.Add("Proatividade: ", "Assumir a liderança sem nenhum impulso exterior, antecipando situações e tomando as ações preventivas que forem necessárias");
            habilidades.Add("Orientação aos detalhes: ", "Estar constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com precisão e cuidado");
            habilidades.Add("Trabalho em equipe: ", "Trabalhar em conjunto visando um objetivo em comum");


            Console.WriteLine("As mentalidades da Generation são:\n");

            foreach (KeyValuePair<string, string> valor in mentalidades)
            {
                Console.WriteLine($"Mentalidade: {valor.Key} | Significado: {valor.Value};\n");
            }

            Console.WriteLine("As habilidades comportamentais da Generation são:\n");

            foreach (KeyValuePair<string, string> valor in habilidades)
            {
                Console.WriteLine($"Habilidade: {valor.Key} | Significado: {valor.Value};\n");
            }
        }
    }
}