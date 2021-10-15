/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 15/10/2021
* Autores do Projeto: Roberto Rivoli Gomes Júnior
* Turma: 2F
* Atividade Proposta em aula
* Observação: Lista 7
* 
* Exercicio 2.cs
* ************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int length = listBox1.Items.Count;
            if (e.KeyCode == Keys.E && e.Alt)
            {
                
                for (int i = 0; i < length; i++)
                {
                    string nome_inteiro = listBox1.Items[i].ToString();

                    int x = nome_inteiro.IndexOf(",");

                    string primeiro_nome = nome_inteiro.Substring(0, x);

                    string sobrenome = nome_inteiro.Substring(x + 1, (nome_inteiro.Length - (x + 1)));

                    listBox2.Items.Insert(i, sobrenome + ", " + primeiro_nome);
                }
            }
        }

        
    }
}
