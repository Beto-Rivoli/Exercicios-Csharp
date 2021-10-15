/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 15/10/2021
* Autores do Projeto: Roberto Rivoli Gomes Júnior
* Turma: 2F
* Atividade Proposta em aula
* Observação: <colocar se houver>
* 
* Exercicio 4.cs
* ************************************************************/ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            char char1 = str[str.Length / 2 - 1];
            char char2 = str[str.Length / 2];
            textBox2.AppendText(char1.ToString() + " = " + ((int)char1).ToString() + Environment.NewLine);
            textBox2.AppendText(char2.ToString() + " = " + ((int)char2).ToString() + Environment.NewLine);
        }
    }
}
