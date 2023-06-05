using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrecaoAtividade03e04SegQuar
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;

            string nome_produto1;
            int qnt_produto1;

            string nome_produto2;
            int qnt_produto2;

            

            Console.WriteLine("Digite seu nome para começar:");
            nome = Console.ReadLine();

            Console.WriteLine($"O cadastro será feito no nome de {nome}");

            Console.WriteLine("Digite o nome do produto 1: ");
            nome_produto1 = Console.ReadLine();

            Console.WriteLine($"Digite a quantidade em estoque de {nome_produto1}");
            qnt_produto1 = int.Parse( Console.ReadLine() );
            //Int32.Parse(  );
            //Convert.ToInt32( );

            Console.WriteLine("Digite o nome do produto 2: ");
            nome_produto2 = Console.ReadLine();

            Console.WriteLine($"Digite a quantidade em estoque de {nome_produto2}");
            qnt_produto2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Produtos cadastrados com sucesso!");
            Console.WriteLine($"Foram cadastrados no nome do funcionário {nome}");
            Console.WriteLine($"{nome_produto1} contém {qnt_produto1} itens");
            Console.WriteLine($"{nome_produto2} contém {qnt_produto2} itens");

            int total_produtos = qnt_produto1 + qnt_produto2;
            Console.WriteLine($"O total de itens em estoque é { total_produtos }");

            Console.ReadKey();

        }
        
        void Atividae03()
        {
            string nome = "Lucas";
            int idade = 25;
            bool cliente = true;

            string nome2 = "Pedrita";
            int idade2 = 19;
            bool cliente2 = false;

            int qnt_cafe = 103;
            int qnt_cafe2 = 5;

            int qnt_cafe_total = qnt_cafe + qnt_cafe2;

            int qnt_cafe_restante = 200 - qnt_cafe;
            int qnt_cafe_restante2 = 200 - qnt_cafe2;

            Console.WriteLine("Lista de usuários: ");
            Console.WriteLine($"1 - Nome: {nome}, idade: {idade}. É cliente: {cliente}");
            Console.WriteLine($"2 - Nome: {nome2}, idade: {idade2}. É cliente: {cliente2}");

            Console.WriteLine($"O cliente {nome}, tomou {qnt_cafe} cafés");
            Console.WriteLine($"O cliente {nome2}, tomou {qnt_cafe2} cafés ");

            Console.WriteLine($"A soma de {nome} e {nome2} dá { qnt_cafe_total } cafés tomados");

            Console.WriteLine($"Falta { qnt_cafe_restante } para {nome}");
            Console.WriteLine($"Falta { qnt_cafe_restante2 } para {nome2}");

            Console.ReadKey();
        }

    }
}
