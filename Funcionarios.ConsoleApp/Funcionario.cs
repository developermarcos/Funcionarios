using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios.ConsoleApp
{
    public enum Departamentos
    {
        Administrativo, 
        Operacional
    }
    internal class Funcionario
    {
        public string nome;
        public Departamentos Departamento;
        public decimal salario;
        public DateTime dataCadastro;
        public string rg;
        public bool ehFuncionario;

        public void Bonificar(decimal valor)
        {
            this.salario += valor;
        }
        public void Demitir()
        {
            this.ehFuncionario = false;
        }
        public void Mostrar()
        {
            Console.WriteLine("Funcionario: {0}", this.nome);
            Console.WriteLine("Departamento: {0}", this.Departamento);
            Console.WriteLine("Salário: {0}", this.salario.ToString("N2"));
            Console.WriteLine("Data de cadastrar: {0}", this.dataCadastro);
            Console.WriteLine("RG: {0}", this.rg);
            Console.WriteLine("É funcionario: {0}", this.ehFuncionario == true? "Sim":"Não");
        }
    }
}
