﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Aluno
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        public Aluno()
        {
            id = 0;
            nome = "";
            idade = 0;
            turma = "";
        }
    }
}
