﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportacaoDeContratos.Classes
{
    public class Arquivos
    {

        public Arquivos()
        {

        }
        public Arquivos(int id, string? nome, string? data, string? usuarioImportacao)
        {
            Id = id;
            Nome = nome;
            Data = data;
            UsuarioImportacao = usuarioImportacao;
        }

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Data { get; set; }

        public string? UsuarioImportacao { get; set; }
    }
}
