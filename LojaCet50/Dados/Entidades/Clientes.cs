using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCet50.Dados.Entidades
{
    public class Clientes
    {
        public int Id { get; set; }


        public string Nome { get; set; }


        public string Apelido { get; set; }


        public string Morada { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }


        public int Telefone { get; set; }

    }
}
