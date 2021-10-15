/* *******************************************************************
* Colegio Técnico Antônio Teixeira Fernandes (Univap)
* Curso Técnico em Informática - Data de Entrega: 15/10/2021
* Autores do Projeto: Roberto Rivoli Gomes Júnior
* Turma: 2F
* Atividade Proposta em aula
* Observação: <lista 7>
* 
* Exercicio 3.cs
* ************************************************************/ 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            //global
            int contador;
        private void button1_Click(object sender, EventArgs e)
        {
           int valor = int.Parse(comboBox1.Text.ToString());
           double raiz = Math.Sqrt(valor);
           int val = (int)(raiz);
                if (raiz == val)
                {
                    comboBox1.Items.Insert(contador, valor);
                    contador++;
                }
                else 
                {
                    MessageBox.Show("número inválido!");
                }
        }
    }
}
