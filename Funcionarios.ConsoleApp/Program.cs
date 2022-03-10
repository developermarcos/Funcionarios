using System;

namespace Funcionarios.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Funcionario marcos = new Funcionario();
            marcos.nome = "Marcos";
            marcos.salario = 5000.00m;
            marcos.rg = "623.111.111";
            marcos.ehFuncionario = true;
            DateTime dataCadastro = new DateTime(2022,08,01);
            marcos.dataCadastro = dataCadastro;
            marcos.Departamento = Departamentos.Administrativo;
            marcos.Bonificar(1000);
            marcos.Mostrar();


            Funcionario f1 = new Funcionario();
            f1.nome = "Fiodor";
            f1.salario = 100;
            Funcionario f2 = new Funcionario();
            f2.nome = "Fiodor";
            f2.salario = 100;
            if (f1 == f2)
                Console.WriteLine("iguais");
            else
                Console.WriteLine("Diferentes");
            
            Console.ReadKey();
        }
    }
}
