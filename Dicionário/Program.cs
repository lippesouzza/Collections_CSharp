using System;
using System.Collections.Generic;

namespace Dicion�rio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dicion�rio da Generation Brasil\n");

            Dictionary<string, string> mentalidades = new Dictionary<string, string>();

            mentalidades.Add("Persist�ncia: ", "Continuar tentando, vez ap�s vez");
            mentalidades.Add("Mentalidade de crescimento: ", "Acreditar que suas compet�ncias mais b�sicas podem ser desenvolvidas atrav�s de dedica��o e trabalho �rduo");
            mentalidades.Add("Responsabilidade pessoal: ", "Assumir responsabilidade por suas pr�prias a��es, trabalhando arduamente, mantendo seus compromissos e n�o dando desculpas");
            mentalidades.Add("Orienta��o ao futuro: ", "Estabelecer metas para o seu futuro, compreender como as a��es de hoje impactam nessas metas e verificar seu progresso com frequ�ncia");

            Dictionary<string, string> habilidades = new Dictionary<string, string>();
            habilidades.Add("Comunica��o: ", "Capacidade de expressar ideias de forma clara e concisa, com linguagem apropriada ao p�blico, assim como ouvir com aten��o, manter contato visual com seus interlocutores e tomar notas ao receber novas informa��es");
            habilidades.Add("Proatividade: ", "Assumir a lideran�a sem nenhum impulso exterior, antecipando situa��es e tomando as a��es preventivas que forem necess�rias");
            habilidades.Add("Orienta��o aos detalhes: ", "Estar constantemente atento aos detalhes ao executar tarefas, a fim de serem completadas com precis�o e cuidado");
            habilidades.Add("Trabalho em equipe: ", "Trabalhar em conjunto visando um objetivo em comum");


            Console.WriteLine("As mentalidades da Generation s�o:\n");

            foreach (KeyValuePair<string, string> valor in mentalidades)
            {
                Console.WriteLine($"Mentalidade: {valor.Key} | Significado: {valor.Value};\n");
            }

            Console.WriteLine("As habilidades comportamentais da Generation s�o:\n");

            foreach (KeyValuePair<string, string> valor in habilidades)
            {
                Console.WriteLine($"Habilidade: {valor.Key} | Significado: {valor.Value};\n");
            }
        }
    }
}