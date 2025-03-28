﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;


namespace farol_3I_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Amarelo_Click(object sender, EventArgs e)
        {

        }


        public Boolean Stop = false;
        //Criando uma instância publica da classe CancellationTokenSource que sinaliza para um token que ele deve ser cancelado
        public CancellationTokenSource ts_Sequencia = new
        CancellationTokenSource();

        private void btn_Vermelho_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.Red;
            lbl_Amarelo.BackColor = Color.White;
            lbl_Verde.BackColor = Color.White;
        }

        private void btn_Amarelo_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.White;
            lbl_Amarelo.BackColor = Color.Yellow;
            lbl_Verde.BackColor = Color.White;
        }

        private void btn_Verde_Click(object sender, EventArgs e)
        {
            lbl_Vermelho.BackColor = Color.White;
            lbl_Amarelo.BackColor = Color.White;
            lbl_Verde.BackColor = Color.Green;
        }

        private void btn_Automacao_Click(object sender, EventArgs e)
        {
            /*A classe Stopwatch pode ser usada para medir o tempo decorrido de uma transação ou tarefa. Usado para realizar micros-benchmarks (Microrefências) na otimização de códigopodendo executar o monitoramento de desempenho. Ref: usingSystem.Diagnostics*/

            var sw = new Stopwatch(); //Medir Tempo
            int i = 0; //Intervalo
            int t = 0; //Transição - Repetições
            while (t < 3)
            {
                //Vermelho
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_Vermelho.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Amarelo
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100; i++)
                {
                    btn_Verde.PerformClick();
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Verde
                sw.Reset();
                sw.Start();
                for (i = 0; i < 100 * (nud_Tempo.Value); i++)
                {
                    btn_Amarelo.PerformClick();
                    lbl_Tempo.Text = i.ToString();
                    //MessageBox.Show(i.ToString());
                }
                sw.Stop();
                lbl_Tempo.Text = sw.ElapsedMilliseconds.ToString();
                MessageBox.Show(i.ToString()); //Observar, tempo
                                               //Inc 1 em t (Transição - Repetição)
                t++;
            }

        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            Stop = true;
            ts_Sequencia.Cancel();
            //this.Close();
        }

        private void btn_Sequencial_Click(object sender, EventArgs e)
        {

        }


        private async void btn_Sequencial_Click_1(object sender,
        EventArgs e)
        {
            try
            {
                while (Stop == false)
                {
                    btn_Vermelho.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 

                    btn_Verde.PerformClick();
                    await Task.Delay(10000, ts_Sequencia.Token); // 10 

                    btn_Amarelo.PerformClick();
                    await Task.Delay(3000, ts_Sequencia.Token); // 03 

                }
            }
            catch (TaskCanceledException ex)
            {
                MessageBox.Show("Sequencial Cancelada!", "Atenção");
                //MessageBox.Show("Sequencial: "+ex.Message);
            }
            catch (Exception erroX)
            {
                MessageBox.Show("Erro:" + erroX.Message);
            }

        }
    }
}
