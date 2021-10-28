using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Aluno> alunos = new List<Aluno>();


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            lstDados.Items.Clear();
            Aluno aluno = new Aluno();
            aluno.id = Convert.ToInt32(txtID.Text);
            aluno.nome = txtNone.Text;
            aluno.idade = Convert.ToInt32(txtIdade.Text);
            aluno.turma = txtTurma.Text;

            alunos.Add(aluno);
            MessageBox.Show("Aluno cadastrado");
        }

        private void Listar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= alunos.Count - 1; i++)
            {
                lstDados.Items.Add(alunos[i].nome);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string nome = txtNone.Text;
            bool achou = false;

            for (int i = 0; i <= alunos.Count-1; i++)
            {
                if (nome == alunos[i].nome)
                {
                    txtID.Text = alunos[i].id.ToString();
                    txtIdade.Text=alunos[i].idade.ToString();
                    txtTurma.Text = alunos[i].turma;
                    achou = true;
                }
            }
            if (achou == false)
            {
                MessageBox.Show("Não encontrei " + nome);
            }
        }
    }
}
