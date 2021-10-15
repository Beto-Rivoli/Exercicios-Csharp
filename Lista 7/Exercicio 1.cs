/* *******************************************************************
 * Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 15/10/2021
 * Autores do Projeto: Roberto Rivoli Gomes Júnior
 * Turma: 2M
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

namespace Exercicio_1_7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // botão que faz o codigo funcionar
        // passa os valores da listabox1 para um vetor
        // desse vetor os dados são "tratados" por um Selection Sort
        // deixando em ordem (menor para maior) de acordo
        // com os valores escolhidos pelo usuario
        // posteriormente os mesmos são mostrados na ListBox1
        private void button1_Click(object sender, EventArgs e)
        {
            int tamanho = listBox1.Items.Count;
            double[] vetorzin = new double[tamanho];
            int cont = 0;
            for (int cont2 = 0; cont2 < tamanho; cont2++)
            {
                if (listBox1.GetSelected(cont2))
                {
                    vetorzin[cont2] = double.Parse(listBox1.Items[cont2].ToString());
                }
            }
            listBox1.Items.Clear();
            
            int tamanho1 = vetorzin.Length;

            int min;
            double aux;
            for (int i = 0; i < tamanho1 - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < tamanho1; j++)
                {
                    if (vetorzin[j] < vetorzin[min])
                    {
                        min = j;
                    }
                
                }
                if (min != i) 
                {
                    aux = vetorzin[min];
                    vetorzin[min] = vetorzin[i];
                    vetorzin[i] = aux;
                
                }
            
            }


                for (int i = 0; i < tamanho; i++)
                {
                    if (vetorzin[i] == 0)
                    {
                        cont++;
                    }
                    else
                    {
                        listBox1.Items.Insert(i - cont, vetorzin[i]);

                    }




                }
        }

     

        
        
    }
}
