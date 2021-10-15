/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 15/10/2021
* Autores do Projeto: Roberto Rivoli Gomes Júnior
* Turma: 2F
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio 1.cs
* ************************************************************/ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome_inteiro = textBox1.Text;

            int x = nome_inteiro.IndexOf(",");

            string primeiro_nome = nome_inteiro.Substring(0, x);

            string sobre_nome = nome_inteiro.Substring(x + 1, (nome_inteiro.Length - (x + 1)));

            textBox2.Text = sobre_nome + ", " + primeiro_nome;
        }
    }
}
