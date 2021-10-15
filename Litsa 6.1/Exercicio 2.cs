/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 15/10/2021
* Autores do Projeto: Roberto Rivoli Gomes Júnior
* Turma: 2F
* Atividade Proposta em aula
* Observação: <colocar se houver>
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

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            string str = textBox1.Text;
            char letra = char.Parse(textBox2.Text);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letra)
                    count++;
            }
            textBox3.Text = count.ToString();
        }
    }
}
