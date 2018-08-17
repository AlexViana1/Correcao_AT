using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorrecaDaProva
{
    public partial class Form1 : Form
    {   
        /*
         * Valor da jogada Selecionada
         * 0 = nenhuma jogada
         * 1= pedra
         * 2= papel
         * 3=tesoura
         */
         

        int jogadaSelecionada = 0;

        string[] jogadas = new string[3]
        {
            "Pedra",
            "Papel",
            "Tesoura"
        };

        int rodada = 1;
        int vitorias = 0;
        int empates = 0;
        int derrotas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btPedra_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = 1;
            AtualizarJogadaSelecionada();

        }

        private void AtualizarJogadaSelecionada()
        {

            if (ChecarJogadaValida())
            {
                lbJogadaSelecionada.Text = string.Format(
                    "Você selecionou a jogada{0}.",
                    jogadas[jogadaSelecionada - 1]
                    ); 
            }
            else
            {
                lbJogadaSelecionada.Text = "Nenhuma jogada seleceionada.";
            }
        }

        private bool ChecarJogadaValida()
        {
            return jogadaSelecionada > 0;
        }

        private void btJogar_Click(object sender, EventArgs e)
        {
            if (ChecarJogadaValida())
            {
                Jogar();
            }

        }

        /*enum Jogadas
        {
            PEDRA =1;
            PAPEL =2;
            TESOURA =3
        }
        */

        private void Jogar()
        {
            Random rnd = new Random();
            int jogadaComputador = rnd.Next(1, jogadas.Length+1);

            ExibirJogada("Jogador", jogadaSelecionada);
            ExibirJogada("Computador", jogadaComputador);

            //jogada sekecionada = Pedra
            // if(jogadaSelecionada == Jogadas.PEDRA )
            if (jogadaSelecionada==1)
            {
                if (jogadaComputador ==1)
                {
                    Empate();


                }
                else if (jogadaComputador==2)
                {
                    Derrota();
                }
                else if (jogadaComputador == 3)
                {
                    Vitoria();
                }
            }
            if (jogadaSelecionada == 2)
            {
                if (jogadaComputador == 1)
                {
                    Empate();

                }
                else if (jogadaComputador == 2)
                {
                    Derrota();
                }
                else if (jogadaComputador == 3)
                {
                    Vitoria();
                }

            }
            if (jogadaSelecionada == 3)
            {
                if (jogadaComputador == 1)
                {
                    Empate();


                }
                else if (jogadaComputador == 2)
                {
                    Derrota();
                }
                else if (jogadaComputador == 3)
                {
                    Vitoria();
                }
            }


            AvancarRodada();

        }

        private void ExibirJogada(string nomeJogador, int jogada)
        {
            rbResultado.AppendText(
                string.Format(
                    "{0}:{1}\n",
                    nomeJogador,
                    jogadas[jogada - 1])
                    );
        }

        private void Vitoria()
        {
            vitorias++;

            rbResultado.AppendText("Você ganhou.\n");

           

        }

        private void AvancarRodada()
        {
            DesselecionarJogada();
            rodada++;
            AtualizarLabelsJogo();
        }

        private void DesselecionarJogada()
        {
            jogadaSelecionada = 0;
            AtualizarJogadaSelecionada();
        }

        private void AtualizarLabelsJogo()
        {
            lbRodada.Text = "Rodada:" + rodada;
            lbVitorias.Text = "Rodada:" + vitorias;
            lbEmpates.Text = "Rodada:" + empates;
            lbDerrotas.Text = "Rodada:" + derrotas;
        }

        private void Derrota()
        {
            derrotas++;

            rbResultado.AppendText("Você perdeu.\n");




        }

        private void Empate()
        {
            empates++;

            rbResultado.AppendText("Você empatou.\n");



        }

        private void btPapel_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = 2;
            AtualizarJogadaSelecionada();
        }

        private void btTesoura_Click(object sender, EventArgs e)
        {
            jogadaSelecionada = 3;
            AtualizarJogadaSelecionada();
        }

        private void btDescelecionar_Click(object sender, EventArgs e)
        {
            DesselecionarJogada();
        }

        private void btReinicar_Click(object sender, EventArgs e)
        {
            rodada = 1;
            vitorias = 0;
            empates = 0;
            derrotas = 0;
            AtualizarLabelsJogo();

            DesselecionarJogada();

            rbResultado.Clear();
        }
    }
}
