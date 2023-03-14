using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Project
{
    public partial class FormRpg : Form
    {
        public FormRpg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnRolarD20_Click(object sender, EventArgs e)
        {
            //Rolagem D20

            Random D20Aleatorio = new Random();
            int D20 = D20Aleatorio.Next(1,21);
            lblResultadoD20.Text = "Resultado: " + D20.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Sair do app

             this.Close();
        }

        private void txtboxNomePersonagem_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCriarPersonagem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Nome = txtboxNomePersonagem.Text;
            Properties.Settings.Default.Raca = cmbboxRaca.Text;
            Properties.Settings.Default.Classe = cmbboxClasse.Text;
            Properties.Settings.Default.Save();

            //Ifs 

            if (Properties.Settings.Default.Nome == "")
            {
                MessageBox.Show("Nomeie seu personagem!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Properties.Settings.Default.Nivel = 0;
            }
                if (Properties.Settings.Default.Classe != "Bárbaro" && Properties.Settings.Default.Classe != "Bardo" && Properties.Settings.Default.Classe != "Bruxo" && Properties.Settings.Default.Classe != "Guerreiro" && Properties.Settings.Default.Classe != "Ladino" && Properties.Settings.Default.Classe != "Paladino" && Properties.Settings.Default.Classe != "Mago" && Properties.Settings.Default.Classe != "Feiticeiro" && Properties.Settings.Default.Classe != "Druida" && Properties.Settings.Default.Classe != "Clérigo")
            {
                MessageBox.Show("Selecione uma das classes válidas!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbboxClasse.Text = "";
                Properties.Settings.Default.Nivel = 0;
            }
                if (Properties.Settings.Default.Raca != "Anão da Colina" && Properties.Settings.Default.Raca != "Anão da Montanha" && Properties.Settings.Default.Raca != "Alto Elfo" && Properties.Settings.Default.Raca != "Elfo da Floresta" && Properties.Settings.Default.Raca != "Elfo Negro (Drow)" && Properties.Settings.Default.Raca != "Meio-Elfo" && Properties.Settings.Default.Raca != "Halfling Pés Leves" && Properties.Settings.Default.Raca != "Halfling Robusto" && Properties.Settings.Default.Raca != "Humano" && Properties.Settings.Default.Raca != "Draconato" && Properties.Settings.Default.Raca != "Gnomo da Floresta" && Properties.Settings.Default.Raca != "Gnomo das Rochas" && Properties.Settings.Default.Raca != "Meio-Orc" && Properties.Settings.Default.Raca != "Infernal" && 
                  Properties.Settings.Default.Raca != "Humano Variante")
                {
                    MessageBox.Show("Escolha uma das raças determinadas para receber seus bônus!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cmbboxRaca.Text = "";
                    Properties.Settings.Default.Nivel = 0;
                }

            //ifs nuds

            //if nud Força

            if (nudForca.Text == "0")
            {
                lblModForça.Text = "-6";
            }
            if (nudForca.Text == "1")
            {
                lblModForça.Text = "-5";
            }
            else if (nudForca.Text == "2" || nudForca.Text == "3")
            {
                lblModForça.Text = "-4";
            }
            else if (nudForca.Text == "4" || nudForca.Text == "5")
            {
                lblModForça.Text = "-3";
            }
            else if (nudForca.Text == "6" || nudForca.Text == "7")
            {
                lblModForça.Text = "-2";
            }
            else if (nudForca.Text == "8" || nudForca.Text == "9")
            {
                lblModForça.Text = "-1";
            }
            else if (nudForca.Text == "10" || nudForca.Text == "11")
            {
                lblModForça.Text = "+0";
            }
            else if (nudForca.Text == "12" || nudForca.Text == "13")
            {
                lblModForça.Text = "+1";
            }
            else if (nudForca.Text == "14" || nudForca.Text == "15")
            {
                lblModForça.Text = "+2";
            }
            else if (nudForca.Text == "16" || nudForca.Text == "17")
            {
                lblModForça.Text = "+3";
            }
            else if (nudForca.Text == "18" || nudForca.Text == "19")
            {
                lblModForça.Text = "+4";
            }
            else if (nudForca.Text == "20" || nudForca.Text == "21")
            {
                lblModForça.Text = "+5";
            }
            else if (nudForca.Text == "22" || nudForca.Text == "23")
            {
                lblModForça.Text = "+6";
            }
            else if (nudForca.Text == "24" || nudForca.Text == "25")
            {
                lblModForça.Text = "+7";
            }
            else if (nudForca.Text == "26" || nudForca.Text == "27")
            {
                lblModForça.Text = "+8";
            }
            else if (nudForca.Text == "28" || nudForca.Text == "29")
            {
                lblModForça.Text = "+9";
            }
            else if (nudForca.Text == "30")
            {
                lblModForça.Text = "+10";
            }
            else
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // if nud Destreza

            if (nudDestreza.Text == "0")
            {
                lblModDestreza.Text = "-6";
            }
            if (nudDestreza.Text == "1")
            {
                lblModDestreza.Text = "-5";
            }
            else if (nudDestreza.Text == "2" || nudDestreza.Text == "3")
            {
                lblModDestreza.Text = "-4";
            }
            else if (nudDestreza.Text == "4" || nudDestreza.Text == "5")
            {
                lblModDestreza.Text = "-3";
            }
            else if (nudDestreza.Text == "6" || nudDestreza.Text == "7")
            {
                lblModDestreza.Text = "-2";
            }
            else if (nudDestreza.Text == "8" || nudDestreza.Text == "9")
            {
                lblModDestreza.Text = "-1";
            }
            else if (nudDestreza.Text == "10" || nudDestreza.Text == "11")
            {
                lblModDestreza.Text = "+0";
            }
            else if (nudDestreza.Text == "12" || nudDestreza.Text == "13")
            {
                lblModDestreza.Text = "+1";
            }
            else if (nudDestreza.Text == "14" || nudDestreza.Text == "15")
            {
                lblModDestreza.Text = "+2";
            }
            else if (nudDestreza.Text == "16" || nudDestreza.Text == "17")
            {
                lblModDestreza.Text = "+3";
            }
            else if (nudDestreza.Text == "18" || nudDestreza.Text == "19")
            {
                lblModDestreza.Text = "+4";
            }
            else if (nudDestreza.Text == "20" || nudDestreza.Text == "21")
            {
                lblModDestreza.Text = "+5";
            }
            else if (nudDestreza.Text == "22" || nudDestreza.Text == "23")
            {
                lblModDestreza.Text = "+6";
            }
            else if (nudDestreza.Text == "24" || nudDestreza.Text == "25")
            {
                lblModDestreza.Text = "+7";
            }
            else if (nudDestreza.Text == "26" || nudDestreza.Text == "27")
            {
                lblModDestreza.Text = "+8";
            }
            else if (nudDestreza.Text == "28" || nudDestreza.Text == "29")
            {
                lblModDestreza.Text = "+9";
            }
            else if (nudDestreza.Text == "30")
            {
                lblModDestreza.Text = "+10";
            }
            else
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if nud Constituição

            if (nudConstituicao.Text == "0")
            {
                lblModConstituicao.Text = "-6";
            }
            if (nudConstituicao.Text == "1")
            {
                lblModConstituicao.Text = "-5";
            }
            else if (nudConstituicao.Text == "2" || nudConstituicao.Text == "3")
            {
                lblModConstituicao.Text = "-4";
            }
            else if (nudConstituicao.Text == "4" || nudConstituicao.Text == "5")
            {
                lblModConstituicao.Text = "-3";
            }
            else if (nudConstituicao.Text == "6" || nudConstituicao.Text == "7")
            {
                lblModConstituicao.Text = "-2";
            }
            else if (nudConstituicao.Text == "8" || nudConstituicao.Text == "9")
            {
                lblModConstituicao.Text = "-1";
            }
            else if (nudConstituicao.Text == "10" || nudConstituicao.Text == "11")
            {
                lblModConstituicao.Text = "0";
            }
            else if (nudConstituicao.Text == "12" || nudConstituicao.Text == "13")
            {
                lblModConstituicao.Text = "+1";
            }
            else if (nudConstituicao.Text == "14" || nudConstituicao.Text == "15")
            {
                lblModConstituicao.Text = "+2";
            }
            else if (nudConstituicao.Text == "16" || nudConstituicao.Text == "17")
            {
                lblModConstituicao.Text = "+3";
            }
            else if (nudConstituicao.Text == "18" || nudConstituicao.Text == "19")
            {
                lblModConstituicao.Text = "+4";
            }
            else if (nudConstituicao.Text == "20" || nudConstituicao.Text == "21")
            {
                lblModConstituicao.Text = "+5";
            }
            else if (nudConstituicao.Text == "22" || nudConstituicao.Text == "23")
            {
                lblModConstituicao.Text = "+6";
            }
            else if (nudConstituicao.Text == "24" || nudConstituicao.Text == "25")
            {
                lblModConstituicao.Text = "+7";
            }
            else if (nudConstituicao.Text == "26" || nudConstituicao.Text == "27")
            {
                lblModConstituicao.Text = "+8";
            }
            else if (nudConstituicao.Text == "28" || nudConstituicao.Text == "29")
            {
                lblModConstituicao.Text = "+9";
            }
            else if (nudConstituicao.Text == "30")
            {
                lblModConstituicao.Text = "+10";
            }
            else
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if nud Inteligência 

            if (nudInteligencia.Text == "0")
            {
                lblModInteligencia.Text = "-6";
            }
            if (nudInteligencia.Text == "1")
            {
                lblModInteligencia.Text = "-5";
            }
            else if (nudInteligencia.Text == "2" || nudInteligencia.Text == "3")
            {
                lblModInteligencia.Text = "-4";
            }
            else if (nudInteligencia.Text == "4" || nudInteligencia.Text == "5")
            {
                lblModInteligencia.Text = "-3";
            }
            else if (nudInteligencia.Text == "6" || nudInteligencia.Text == "7")
            {
                lblModInteligencia.Text = "-2";
            }
            else if (nudInteligencia.Text == "8" || nudInteligencia.Text == "9")
            {
                lblModInteligencia.Text = "-1";
            }
            else if (nudInteligencia.Text == "10" || nudInteligencia.Text == "11")
            {
                lblModInteligencia.Text = "+0";
            }
            else if (nudInteligencia.Text == "12" || nudInteligencia.Text == "13")
            {
                lblModInteligencia.Text = "+1";
            }
            else if (nudInteligencia.Text == "14" || nudInteligencia.Text == "15")
            {
                lblModInteligencia.Text = "+2";
            }
            else if (nudInteligencia.Text == "16" || nudInteligencia.Text == "17")
            {
                lblModInteligencia.Text = "+3";
            }
            else if (nudInteligencia.Text == "18" || nudInteligencia.Text == "19")
            {
                lblModInteligencia.Text = "+4";
            }
            else if (nudInteligencia.Text == "20" || nudInteligencia.Text == "21")
            {
                lblModInteligencia.Text = "+5";
            }
            else if (nudInteligencia.Text == "22" || nudInteligencia.Text == "23")
            {
                lblModInteligencia.Text = "+6";
            }
            else if (nudInteligencia.Text == "24" || nudInteligencia.Text == "25")
            {
                lblModInteligencia.Text = "+7";
            }
            else if (nudInteligencia.Text == "26" || nudInteligencia.Text == "27")
            {
                lblModInteligencia.Text = "+8";
            }
            else if (nudInteligencia.Text == "28" || nudInteligencia.Text == "29")
            {
                lblModInteligencia.Text = "+9";
            }
            else if (nudInteligencia.Text == "30")
            {
                lblModInteligencia.Text = "+10";
            }
            else
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if nud Sabedoria 

            if (nudSabedoria.Text == "0")
            {
                lblModSabedoria.Text = "-6";
            }
            if (nudSabedoria.Text == "1")
            {
                lblModSabedoria.Text = "-5";
            }
            else if (nudSabedoria.Text == "2" || nudSabedoria.Text == "3")
            {
                lblModSabedoria.Text = "-4";
            }
            else if (nudSabedoria.Text == "4" || nudSabedoria.Text == "5")
            {
                lblModSabedoria.Text = "-3";
            }
            else if (nudSabedoria.Text == "6" || nudSabedoria.Text == "7")
            {
                lblModSabedoria.Text = "-2";
            }
            else if (nudSabedoria.Text == "8" || nudSabedoria.Text == "9")
            {
                lblModSabedoria.Text = "-1";
            }
            else if (nudSabedoria.Text == "10" || nudSabedoria.Text == "11")
            {
                lblModSabedoria.Text = "+0";
            }
            else if (nudSabedoria.Text == "12" || nudSabedoria.Text == "13")
            {
                lblModSabedoria.Text = "+1";
            }
            else if (nudSabedoria.Text == "14" || nudSabedoria.Text == "15")
            {
                lblModSabedoria.Text = "+2";
            }
            else if (nudSabedoria.Text == "16" || nudSabedoria.Text == "17")
            {
                lblModSabedoria.Text = "+3";
            }
            else if (nudSabedoria.Text == "18" || nudSabedoria.Text == "19")
            {
                lblModSabedoria.Text = "+4";
            }
            else if (nudSabedoria.Text == "20" || nudSabedoria.Text == "21")
            {
                lblModSabedoria.Text = "+5";
            }
            else if (nudSabedoria.Text == "22" || nudSabedoria.Text == "23")
            {
                lblModSabedoria.Text = "+6";
            }
            else if (nudSabedoria.Text == "24" || nudSabedoria.Text == "25")
            {
                lblModSabedoria.Text = "+7";
            }
            else if (nudSabedoria.Text == "26" || nudSabedoria.Text == "27")
            {
                lblModSabedoria.Text = "+8";
            }
            else if (nudSabedoria.Text == "28" || nudSabedoria.Text == "29")
            {
                lblModSabedoria.Text = "+9";
            }
            else if (nudSabedoria.Text == "30")
            {
                lblModSabedoria.Text = "+10";
            }
            else
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //if nud Carisma

            if (nudCarisma.Text == "0")
            {
                lblModCarisma.Text = "-6";
            }
            if (nudCarisma.Text == "1")
            {
                lblModCarisma.Text = "-5";
            }
            else if (nudCarisma.Text == "2" || nudCarisma.Text == "3")
            {
                lblModCarisma.Text = "-4";
            }
            else if (nudCarisma.Text == "4" || nudCarisma.Text == "5")
            {
                lblModCarisma.Text = "-3";
            }
            else if (nudCarisma.Text == "6" || nudCarisma.Text == "7")
            {
                lblModCarisma.Text = "-2";
            }
            else if (nudCarisma.Text == "8" || nudCarisma.Text == "9")
            {
                lblModCarisma.Text = "-1";
            }
            else if (nudCarisma.Text == "10" || nudCarisma.Text == "11")
            {
                lblModCarisma.Text = "+0";
            }
            else if (nudCarisma.Text == "12" || nudCarisma.Text == "13")
            {
                lblModCarisma.Text = "+1";
            }
            else if (nudCarisma.Text == "14" || nudCarisma.Text == "15")
            {
                lblModCarisma.Text = "+2";
            }
            else if (nudCarisma.Text == "16" || nudCarisma.Text == "17")
            {
                lblModCarisma.Text = "+3";
            }
            else if (nudCarisma.Text == "18" || nudCarisma.Text == "19")
            {
                lblModCarisma.Text = "+4";
            }
            else if (nudCarisma.Text == "20" || nudCarisma.Text == "21")
            {
                lblModCarisma.Text = "+5";
            }
            else if (nudCarisma.Text == "22" || nudCarisma.Text == "23")
            {
                lblModCarisma.Text = "+6";
            }
            else if (nudCarisma.Text == "24" || nudCarisma.Text == "25")
            {
                lblModCarisma.Text = "+7";
            }
            else if (nudCarisma.Text == "26" || nudCarisma.Text == "27")
            {
                lblModCarisma.Text = "+8";
            }
            else if (nudCarisma.Text == "28" || nudCarisma.Text == "29")
            {
                lblModCarisma.Text = "+9";
            }
            else if (nudCarisma.Text == "30")
            {
                lblModCarisma.Text = "+10";
            }
            else
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Message Box

            MessageBox.Show("Personagem Salvo!", "Salvamento", MessageBoxButtons.OK);

            //Avisos
            lblAvisoMod.Visible = false;

            //Declaração de configs e Salvamento

           
            Properties.Settings.Default.Nome = txtboxNomePersonagem.Text;
            Properties.Settings.Default.Raca = cmbboxRaca.Text;
            Properties.Settings.Default.Classe = cmbboxClasse.Text;
            Properties.Settings.Default.Forca = Convert.ToInt32(nudForca.Text);
            Properties.Settings.Default.Destreza = Convert.ToInt32(nudDestreza.Text);
            Properties.Settings.Default.Constituicao = Convert.ToInt32(nudConstituicao.Text);
            Properties.Settings.Default.Inteligencia = Convert.ToInt32(nudInteligencia.Text);
            Properties.Settings.Default.Sabedoria = Convert.ToInt32(nudSabedoria.Text);
            Properties.Settings.Default.Carisma = Convert.ToInt32(nudCarisma.Text);
            Properties.Settings.Default.ModForca = Convert.ToInt32(lblModForça.Text);
            Properties.Settings.Default.ModDestreza = Convert.ToInt32(lblModDestreza.Text);
            Properties.Settings.Default.ModConstituicao = Convert.ToInt32(lblModConstituicao.Text);
            Properties.Settings.Default.ModInteligencia = Convert.ToInt32(lblModInteligencia.Text);
            Properties.Settings.Default.ModSabedoria = Convert.ToInt32(lblModSabedoria.Text);
            Properties.Settings.Default.ModCarisma = Convert.ToInt32(lblModCarisma.Text);
            Properties.Settings.Default.PVTotais = Convert.ToInt32(nudPVTotal.Text);
            Properties.Settings.Default.PVAtuais = Convert.ToInt32(nudPVAtuais.Text);
            Properties.Settings.Default.Itens = rtxtBoxItens.Text;
            Properties.Settings.Default.Proficiencia = Convert.ToInt32(nudProficiencia.Text);
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Vezes++;

            //Raças If

            //Humano
            if (Properties.Settings.Default.Raca == "Humano" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Forca = Properties.Settings.Default.Forca + 1;
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 1;
                Properties.Settings.Default.Constituicao = Properties.Settings.Default.Constituicao + 1;
                Properties.Settings.Default.Inteligencia = Properties.Settings.Default.Inteligencia + 1;
                Properties.Settings.Default.Sabedoria = Properties.Settings.Default.Sabedoria + 1;
                Properties.Settings.Default.Carisma = Properties.Settings.Default.Carisma + 1;
            }
            Properties.Settings.Default.Save();

            //Anão da Colina
            if (Properties.Settings.Default.Raca == "Anão da Colina" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Constituicao = Properties.Settings.Default.Constituicao + 2;
                Properties.Settings.Default.Sabedoria++;
                Properties.Settings.Default.PVTotais++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro\nTreinamento Anão em Combate\nProficiência com Ferramentas";
                MessageBox.Show("Você tem proficiência com machados de batalha, machadinhas, martelos leves, martelos de guerra; \n\n Você tem direito a uma proficiência em uma ferramenta de artesão à sua escolha entre: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro.", "Anão da Colina", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Anão da Montanha
            if (Properties.Settings.Default.Raca == "Anão da Montanha" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Constituicao = Properties.Settings.Default.Constituicao + 2;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro\nTreinamento Anão em Combate\nProficiência com Ferramentas\n\nTreinamento Anão com Armaduras";

                Properties.Settings.Default.Forca = Properties.Settings.Default.Forca + 2;

                MessageBox.Show("Você tem proficiência com machados de batalha, machadinhas, martelos leves, martelos de guerra, armaduras leves e médias; \n\n Você tem direito a uma proficiência em uma ferramenta de artesão à sua escolha entre: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro.", "Anão da Montanha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Alto Elfo
            if (Properties.Settings.Default.Raca == "Alto Elfo" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 2;

                Properties.Settings.Default.Inteligencia++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro\nTreinamento Élfico com Armas";

                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n Você tem proficiência em Percepção, espadas longas, espadas curtas, arcos longos e arcos curtos; \n\n Elfos não precisam dormir, após meditar durante 4 horas por dia ganha os mesmos benefícios que um humano após 8 horas de sono.", "Alto Elfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Elfo da Floresta
            if (Properties.Settings.Default.Raca == "Elfo da Floresta" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 2;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro\nTreinamento Élfico com Armas";

                Properties.Settings.Default.Sabedoria++;

                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n Você tem proficiência em Percepção, espadas longas, espadas curtas, arcos longos e arcos curtos; \n\n Elfos não precisam dormir, após meditar durante 4 horas por dia ganha os mesmos benefícios que um humano após 8 horas de sono.", "Elfo da Floresta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Elfo Negro (Drow)
            if (Properties.Settings.Default.Raca == "Elfo Negro (Drow)" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 2;
                Properties.Settings.Default.Carisma++;

                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro Superior\nSensibilidade à Luz Solar\nTreinamento Drow com Armas";

                MessageBox.Show("Você possui visão no escuro superior, de alcance de 36 metros de raio; \n\nVocê tem proficiência em Percepção, rapieiras, espadas curtas e bestas de mão;\n\n Você possui sensibilidade à luz solar, enquanto seu alvo ou você estiver sob luz solar você possui desvantagem em jogadas de ataque e sabedoria; \n\n Elfos não precisam dormir, após meditar durante 4 horas por dia ganha os mesmos benefícios que um humano após 8 horas de sono.", "Elfo Negro (Drow)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Meio-Elfo
            if (Properties.Settings.Default.Raca == "Meio-Elfo" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 2;
                Properties.Settings.Default.Carisma = Properties.Settings.Default.Carisma + 2;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro.";
                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n\n Você tem proficiência em duas perícias, à sua escolha; \n\n Você pode aumentar em 1 outros dois valores de habilidade à sua esccolha; \n\n Elfos não precisam dormir, após meditar durante 4 horas por dia ganha os mesmos benefícios que um humano após 8 horas de sono.", "Meio-Elfo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Halfling Pés Leves
            if (Properties.Settings.Default.Raca == "Halfling Pés Leves" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 2;
                Properties.Settings.Default.Carisma++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nSortudo\nFurtividade Natural";
                MessageBox.Show("Sortudo: Quando você obtiver um 1 natural em uma jogada de ataque, teste de habilidade ou teste de resistência, você pode jogar de novo o dado e deve utilizar o novo resultado; \n\n Furtividade Natural: Você pode tentar se esconder mesmo quando possuir apenas a cobertura de uma criatura que for no mínimo um tamanho maior que o seu.", "Halfling Pés Leves", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Halfling Robusto
            if (Properties.Settings.Default.Raca == "Halfling Robusto" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Destreza = Properties.Settings.Default.Destreza + 2;
                Properties.Settings.Default.Constituicao++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nSortudo";
                MessageBox.Show("Sortudo: Quando você obtiver um 1 natural em uma jogada de ataque, teste de habilidade ou teste de resistência, você pode jogar de novo o dado e deve utilizar o novo resultado.", "Halfling Robusto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Humano Variante
            if (Properties.Settings.Default.Raca == "Humano Variante" && Properties.Settings.Default.Vezes == 1)
            {
                MessageBox.Show("Aumento no Valor de Habilidade: Dois valores de habilidade, à sua escolha, aumentam em 1; \n\n Você ganha proficiência em uma perícia, à sua escolha;  \n\n Você adquire um talento de sua escolha. ", "Humano Variante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Draconato
            if (Properties.Settings.Default.Raca == "Draconato" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nAncestral Dracônico(tipo)\nArma de Sopro(tipo)\nResistência a dano(tipo)";
                Properties.Settings.Default.Forca = Properties.Settings.Default.Forca + 2;
                Properties.Settings.Default.Carisma++;

                MessageBox.Show("Ancestral Dracônico: Você possui um ancestral dracônico, que te dá uma arma de sopro e resistência a dano, pelo tipo de dragão escolhido. ", "Draconato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Gnomo da Floresta
            if (Properties.Settings.Default.Raca == "Gnomo da Floresta" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Inteligencia = Properties.Settings.Default.Inteligencia + 2;
                Properties.Settings.Default.Destreza++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro\nEsperteza Gnômica\nIlusionista Nato\nFalar com Bestas Pequenas";

                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n\n Esperteza Gnômica: Você possui vantagem em todos os testes de resistência de Inteligência, Sabedoria e Carisma contra magia; \n\n Ilusionista Nato: Você conhece o truque ilusão menor. Inteligência é a sua habilidade usada para conjurá-la (Você cria um som ou uma imagem de um objeto com duração de um minuto) \n\n Falar com Bestas Pequenas: Gnomos da floresta amam os animais e normalmente possuem esquilos, doninhas, coelhos, toupeiras, pica-paus e outras criaturas como amados animais de estimação. ", "Gnomo da Floresta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Gnomo das Rochas
            if (Properties.Settings.Default.Raca == "Gnomo das Rochas" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Inteligencia = Properties.Settings.Default.Inteligencia + 2;
                Properties.Settings.Default.Constituicao++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVisão no Escuro\nEsperteza Gnômica";

                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n\n Esperteza Gnômica: Você possui vantagem em todos os testes de resistência de Inteligência, Sabedoria e Carisma contra magia; ", "Gnomo das Rochas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Meio-Orc
            if (Properties.Settings.Default.Raca == "Meio-Orc" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Forca = Properties.Settings.Default.Forca + 2;
                Properties.Settings.Default.Constituicao++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n Visão no Escuro\nAmeaçador\nResistência Implacável\nAtaques Selvagens";

                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n\n Ameaçador: Você adquire proficiência na perícia Intimidação. \n\n Resistência Implacável: Quando você é reduzido a 0 pontos de vida mas não é completamente morto, você pode voltar para 1 ponto de vida. Você não pode usar essa característica novamente até completar um descanso longo. \n\n Ataques Selvagens: Quando você atinge um ataque crítico com uma arma corpo-a-corpo, você pode rolar um dos dados de dano da arma mais uma vez e adicioná-lo ao dano extra causado pelo acerto crítico.", "Meio-Orc", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Infernal
            if (Properties.Settings.Default.Raca == "Infernal" && Properties.Settings.Default.Vezes == 1)
            {
                Properties.Settings.Default.Carisma = Properties.Settings.Default.Carisma + 2;
                Properties.Settings.Default.Inteligencia++;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n Visão no Escuro\nResistência a fogo";

                MessageBox.Show("Você possui visão no escuro, de alcance de 18 metros; \n\n Resistência Infernal: Você possui resistência a dano de fogo.", "Infernal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Classes

            //Bárbaro
            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 1)
            {
                Properties.Settings.Default.PVTotais = 12 + Properties.Settings.Default.ModConstituicao;
                Properties.Settings.Default.PVAtuais = Properties.Settings.Default.PVTotais;
                Properties.Settings.Default.Proficiencia = 2;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n2  Fúrias : dano +2\nProficiência em Força e Constituição\nDefesa sem armadura";
                MessageBox.Show("PROFICIÊNCIAS \n Armaduras: Armaduras leves, armaduras médias e escudos \n \n Armas: Armas simples, armas marciais \n \n Ferramentas: Nenhuma \n\n Testes de Resistência: Força, Constituição \n\n Perícias: Escolha duas dentre Adestrar Animais Atletismo, Intimidação, Natureza, Percepção e Sobrevivência \n\n Proficiência: +2 \n\nFÚRIA: Em batalha, você luta com uma ferocidade primitiva. No seu turno, você pode entrar em fúria com uma ação bônus.\nEnquanto estiver em fúria, você recebe os seguintes benefícios se você não estiver vestindo uma armadura pesada: Vantagem em testes de força e resistência de força, Um bônus de ataque com armas corpo a corpou usando força, Você também possui resistência contra danos de concussão, cortante e perfurante.\nFúria: você possui 2 fúrias. Dano: +2 \n\nDEFESA SEM ARMADURA: Quando você não estiver vestindo qualquer armadura sua Classe de Armadura será 10 + seu modificador de Destreza + seu modificador de Constituição. Você pode usar um escudo.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 2)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nAtaque descuidado\nSentido de perigo";
                MessageBox.Show("ATAQUE DESCUIDADO: você pode desistir de toda preocupação com sua defesa para atacar com um desespero feroz. Quando você fizer o seu primeiro ataque no turno, você pode decidir atacar descuidadamente. Fazer isso lhe concede vantagem nas jogadas de ataque com armas corpo-a-corpo usando Força durante seu turno, porém, as jogadas de ataques feitas contra você possuem vantagem até o início do seu próximo turno.\n\nSENTIDO DE PERIGO: você adquire um sentido sobrenatural de quando as coisas próximas não estão como deveriam, concedendo a você uma chance maior quando estiver evitando perigos.\nVocê possui vantagem em testes de resistência de Destreza contra efeitos que você possa ver, como armadilhas e magias. Para receber esse benefício você não pode estar cego, surdo ou incapacitado.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 3)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n3 Fúrias: dano +2\nCaminho Primitivo";
                MessageBox.Show("Fúrias: 3\n\nCAMINHO PRIMITIVO: No 3° nível, você escolhe um caminho que molda a natureza da sua fúria. Escolha o Caminho do Furioso ou o Caminho do Guerreiro Totêmico, ambos detalhados no final da descrição de classe. Sua escolha lhe concederá características no 3° nível e novamente no 6°, 10° e 14° níveis.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 4)
            {
                MessageBox.Show("Incremento no valor de habilidade: Quando você atinge o 4° nível e novamente no 8°, 12°, 16° e 19° nível, você pode aumentar um valor de habilidade, à sua escolha, em 2 ou você pode aumentar dois valores de habilidade, à sua escolha em 1. Como padrão, você não pode elevar um valor de habilidade acima de 20 com essa característica.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 5)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nAtaque extra\nMovimento Rápido";
                Properties.Settings.Default.Proficiencia = 3;
                MessageBox.Show("Proficiência: +3 \n\nAtaque extra: você pode atacar duas vezes, ao invés de uma, sempre que você realizar a ação de Ataque no seu turno.\n\nMOVIMENTO RÁPIDO: Começando no 5° nível, seu deslocamento aumenta em 3 metros enquanto você não estiver vestindo uma armadura pesada.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 6)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n4 Fúrias: dano +2";
                MessageBox.Show("Fúrias: 4\n\nCaracterística de Caminho Primitivo", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 7)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nInstinto Selvagem";
                MessageBox.Show("INSTINTO SELVAGEM: seu instinto está tão apurado que você recebe vantagem nas jogadas de iniciativa.\nAlém disso, se você estiver surpreso no começo de um combate e não estiver incapacitado, você pode agir normalmente no seu primeiro turno, mas apenas se você entrar em fúria antes de realizar qualquer outra coisa neste turno.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 8)
            {
                MessageBox.Show("Incremento no valor de habilidade", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 9)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n4 Fúrias: dano +3\nCrítico Brutal";
                Properties.Settings.Default.Proficiencia = 4;
                MessageBox.Show("Dano de Fúria: +3 \n\n Crítico Brutal: Quando der acerto crítico jogue mais um dado e some os valores \n\nProficiência: +4", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 10)
            {
                MessageBox.Show("Característica de Caminho Primitivo", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 11)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nFÚRIA IMPLACÁVEL";
                MessageBox.Show("FÚRIA IMPLACÁVEL: A partir do 11° nível, sua fúria pode manter você lutando independente da gravidade dos seus ferimentos. Se você cair para 0 pontos de vida enquanto estiver em fúria e não morrer, você pode realizar um teste de resistência de Constituição CD 10 (CD: Classe de dificuldade). Se você for bem sucedido, você volta para 1 ponto de vida ao invés disso\n  Cada vez que você utilizar essa característica após a primeira, a CD aumenta em 5. Assim que você terminar um descanso curto ou longo a CD volta para 10.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 12)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n5 Fúrias: dano +3";
                MessageBox.Show("Fúrias: 5 \n\n Incremento no Valor de Habilidade", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 13)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nCrítico Brutal 2";
                Properties.Settings.Default.Proficiencia = 5;
                MessageBox.Show("Crítico Brutal 2: Quando der acerto crítico jogue mais dois dados e some os valores \n\nProficiência: +5 ", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 14)
            {
                MessageBox.Show("Característica de Caminho Primitivo", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 15)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nFúria Persistente";
                MessageBox.Show("FÚRIA PERSISTENTE: A partir do 15° nível, sua fúria é tão brutal que ela só termina prematuramente se você cair inconsciente ou se você decidir terminá-la.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 16)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n5 Fúrias: dano +4";
                MessageBox.Show("Dano de Fúria: +4 \n\n Incremento no Valor de Habilidade", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 17)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n6 Fúrias: dano +4\nCrítico Brutal 3";
                Properties.Settings.Default.Proficiencia = 6;
                MessageBox.Show("Proficiência: +6 \n\nCrítico Brutal 3: Quando der acerto crítico jogue mais três dados e some os valores \n\nFúrias: 6", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 18)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nForça Indomável";
                MessageBox.Show("FORÇA INDOMÁVEL: A partir do 18° nível, se o total de um teste de Força seu for menor que o seu valor de Força, você pode usar esse valor no lugar do resultado.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 19)
            {
                MessageBox.Show("Incremento no Valor de Habilidade", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

                if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel == 20)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nFúrias Ilimitadas! dano +4\nCampeão Primitivo";
                MessageBox.Show("Fúrias: Ilimitadas! \n\nCAMPEÃO PRIMITIVO: No 20° nível, você incorpora os poderes da natureza. Seus valores de Força e Constituição aumentam em 4. Seu máximo para esses valores agora é 24.", "Bárbaro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //Bardo
            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 1)
            {
                Properties.Settings.Default.Proficiencia = 2;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nConjuração \nInspiração de Bardo (d6) \nTruques Conhecidos: 2 \n Magias Conhecidas: 4 \n Espaços de Magia: 2 de 1º nível";
                MessageBox.Show("PROFICIÊNCIAS: Armaduras: Armaduras leves\nArmas: Armas simples, bestas de mão, espadas longas, rapieiras, espadas curtas\nFerramentas: Três instrumentos musicais, à sua escolha\nTestes de Resistência: Destreza, Carisma\nPerícias: Escolha três quaisquer\n\nCONJURAÇÃO: Você aprendeu a desembaraçar e remodelar o decido da realidade em harmonia com os seus desejos e música. Suas magias são parte do seu vasto repertório, magia que você pode entoar em diferentes situações. Veja o capítulo 10 para as regras gerais de conjuração e o capítulo 11 para a lista de magias de bardo.\n\nHABILIDADE DE CONJURAÇÃO: Sua habilidade de conjuração é Carisma para suas magias de bardo, portanto, você usa seu Carisma sempre que alguma magia se referir à sua habilidade de conjurar magias. Além disso, você usa o seu modificador de Carisma para definir a CD dos testes de resistência para as magias de bardo que você conjura e quando você realiza uma jogada de ataque com uma magia \n\n INSPIRAÇÃO DE BARDO: Você pode inspirar os outros através de palavras animadoras ou música. Para tanto, você usa uma ação bônus no seu turno para escolher uma outra criatura, que não seja você mesmo, a até 18 metros de você que possa ouvi-lo. Essa criatura ganha um dado de Inspiração de Bardo, um d6.\nUma vez, nos próximos 10 minutos, a criatura poderá rolar o dado e adicionar o valor rolado a um teste de habilidade, jogada de ataque ou teste de resistência que ela fizer. A criatura pode esperar até rolar o d20 antes de decidir usar o dado de Inspiração de Bardo, mas deve decidir antes do Mestre dizer se a rolagem foi bem ou mal sucedida. Quando o dado de Inspiração de Bardo for rolado, ele é gasto. Uma criatura pode ter apenas um dado de Inspiração de Bardo por vez.\n\n Truques Conhecidos: 2 \n\n Magias Conhecidas: 4 \n\n Espaços de Magia: 2 de 1º nível\nProficiência: +2", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 2)
            {
                MessageBox.Show("VERSATILIDADE: A partir do 2° nível, você pode adicionar metade do seu bônus de proficiência, arredondado para baixo, em qualquer teste de habilidade que você fizer que ainda não possua seu bônus de proficiência.\n\nCANÇÃO DE DESCANSO: A partir do 2° nível, você pode usar música ou oração calmantes para ajudar a revitalizar seus aliados feridos durante um descanso curto. Se você ou qualquer criatura amigável que puder ouvir sua atuação recuperar pontos de vida no fim do descanso curto ao gastar um ou mais Dados de Vida, cada uma dessas criaturas recupera 1d6 pontos de vida adicionais.\n\n Truques Conhecidos: 2 \n\n Magias Conhecidas: 5 \n\n Espaços de Magia: 3 de 1º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nVersatilidade\nCanção do Descanso (d6) \nTruques Conhecidos: 2 \n Magias Conhecidas: 5 \n Espaços de Magia: 3 de 1º nível";
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 3)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nColégio de Bardo\nAptidão\nTruques Conhecidos: 2 \n Magias Conhecidas: 6 \n Espaços de Magia: 4 de 1º nível e 2 de 2º nível";

                MessageBox.Show("COLÉGIO DE BARDO: No 3° nível, você investiga as técnicas avançadas de um colégio de bardo, à sua escolha: o Colégio do Conhecimento ou o Colégio da Bravura, ambos detalhados no final da descrição da classe. Sua escolha lhe concede características no 3° nível e novamente no 6° e 14° nível.\nAPTIDÃO: No 3° nível, escolha duas das perícias em que você é proficiente. Seu bônus de proficiência é dobrado em qualquer teste de habilidade que você fizer que utilize qualquer das perícias escolhidas.\n\nTruques Conhecidos: 2\n\nMagias Conhecidas: 6\n\nEspaços de Magia: 4 de 1º nível e 2 de 2º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 4)
            {
                
                MessageBox.Show("Incremento no valor de habilidade: Quando você atinge o 4° nível e novamente no 8°, 12°, 16° e 19° nível, você pode aumentar um valor de habilidade, à sua escolha, em 2 ou você pode aumentar dois valores de habilidade, à sua escolha em 1. Como padrão, você não pode elevar um valor de habilidade acima de 20 com essa característica.\n\nTruques Conhecidos: 3\n\nMagias Conhecidas: 7\n\nEspaços de Magia: 4 de 1º nível e 3 de 2º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nTruques Conhecidos: 3\nMagias Conhecidas: 7\nEspaços de Magia: 4 de 1º nível e 3 de 2º nível";
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 5)
            {
                Properties.Settings.Default.Proficiencia = 3;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nInspiração de Bardo (d8)\nFonte de Inspiração\nTruques Conhecidos: 3\nMagias Conhecidas: 8\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível e 2 de 3º nível";
                MessageBox.Show("Inspiração de Bardo: Bônus (d8)\n\nFONTE DE INSPIRAÇÃO: Começando no momento em que você atinge o 5° nível,você recupera todos as utilizações gastas da sua Inspiração de Bardo quando você termina um descanso curto ou longo.\n\nProficiência = +3\n\nTruques Conhecidos: 3\n\nMagias Conhecidas: 8\n\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível e 2 de 3º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 6)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nHabilidade de Colégio de Bardo\nCanção de Proteção\nTruques Conhecidos: 3\nMagias Conhecidas: 9\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível e 3 de 3º nível";
                MessageBox.Show("Habilidade de Colégio de Bardo\n\nCANÇÃO DE PROTEÇÃO: No 6° nível, você adquire a habilidade de usar notas musicais ou palavras de poder para interromper efeito de influência mental. Com uma ação, você pode começar uma atuação que dura até o fim do seu próximo turno. Durante esse tempo, você e qualquer criatura amigável a até 9 metros de você terá vantagem em testes de resistência para não ser amedrontado ou enfeitiçado. Uma criatura deve ser capaz de ouvir você para receber esse benefício. A atuação termina prematuramente se você for incapacitado ou silenciado ou se você terminá-la voluntariamente (não requer ação).\n\nTruques Conhecidos: 3\n\nMagias Conhecidas: 9\n\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível e 3 de 3º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 7)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nTruques Conhecidos: 3\nMagias Conhecidas: 10\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível e 1 de 4º nível";

                MessageBox.Show("Truques Conhecidos: 3\n\nMagias Conhecidas: 10\n\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível e 1 de 4º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 8)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\nTruques Conhecidos: 3\nMagias Conhecidas: 11\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível e 2 de 4º nível";

                MessageBox.Show("Incremento no valor de habilidade\n\nTruques Conhecidos: 3\n\nMagias Conhecidas: 11\n\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível e 2 de 4º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 9)
            {
                Properties.Settings.Default.Proficiencia = 4;
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n Canção do Descanso (d8) \nTruques Conhecidos: 3\nMagias Conhecidas: 12\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível, 3 de 4º nível e 1 de 5º nível";
                MessageBox.Show("Canção do Descanso: Bônus (d8)\n\n Proficiência: +4\n\nTruques Conhecidos: 3\n\nMagias Conhecidas: 12\n\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível, 3 de 4º nível e 1 de 5º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 10)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n Inspiração de Bardo (d10)\nAptidão\n Segredos Mágicos \nTruques Conhecidos: 4\nMagias Conhecidas: 14\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível, 3 de 4º nível e 2 de 5º nível";

                MessageBox.Show("Inspiração de Bardo: Bônus (d10)\n\nAPTIDÃO: No 10° nível, você escolhe mais duas perícias em que é proficiente para ganhar esse benefício.\n\nSEGREDOS MÁGICOS: No 10° nível, você usurpou conhecimento mágico de um vasto espectro de disciplinas. Escolha duas magias de qualquer classe, incluindo essa. A magia que você escolher deve ser de um nível que você possa conjurar, como mostrado na tabela O Bardo, ou um truque.\nAs magias escolhidas contam como magias de bardo para você e já estão incluídas no número da coluna Magias Conhecidas da tabela O Bardo.\n\nTruques Conhecidos: 4\n\nMagias Conhecidas: 14\n\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível, 3 de 4º nível e 2 de 5º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Properties.Settings.Default.Classe == "Bardo" && Properties.Settings.Default.Nivel == 11)
            {
                Properties.Settings.Default.Itens = Properties.Settings.Default.Itens + "\n Inspiração de Bardo (d10)\nAptidão\n Segredos Mágicos \nTruques Conhecidos: 4\nMagias Conhecidas: 15\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível, 3 de 4º nível, 2 de 5º nível e 1 de 6º nível";

                MessageBox.Show("Truques Conhecidos: 4\nMagias Conhecidas: 15\nEspaços de Magia: 4 de 1º nível, 3 de 2º nível, 3 de 3º nível, 3 de 4º nível, 2 de 5º nível e 1 de 6º nível", "Bardo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


            Properties.Settings.Default.Save();

            //Carregar Personagem 

            txtboxNomePersonagem.Text = Properties.Settings.Default.Nome;
            cmbboxRaca.Text = Properties.Settings.Default.Raca;
            cmbboxClasse.Text = Properties.Settings.Default.Classe;
            lblNivel.Text = "Nível: " + Properties.Settings.Default.Nivel;
            nudForca.Text = Convert.ToString(Properties.Settings.Default.Forca);
            nudDestreza.Text = Convert.ToString(Properties.Settings.Default.Destreza);
            nudConstituicao.Text = Convert.ToString(Properties.Settings.Default.Constituicao);
            nudInteligencia.Text = Convert.ToString(Properties.Settings.Default.Inteligencia);
            nudSabedoria.Text = Convert.ToString(Properties.Settings.Default.Sabedoria);
            nudCarisma.Text = Convert.ToString(Properties.Settings.Default.Carisma);
            nudPVTotal.Text = Convert.ToString(Properties.Settings.Default.PVTotais);
            nudPVAtuais.Text = Convert.ToString(Properties.Settings.Default.PVAtuais);
            rtxtBoxItens.Text = Properties.Settings.Default.Itens;
            nudProficiencia.Text = Convert.ToString(Properties.Settings.Default.Proficiencia);
            lblAvisoMod.Visible = false;

            //ifs nuds

            //if nud Força

            if (nudForca.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModForça.Text = "-6";
            }
            if (nudForca.Text == "1")
            {
                lblModForça.Text = "-5";
            }
            else if (nudForca.Text == "2" || nudForca.Text == "3")
            {
                lblModForça.Text = "-4";
            }
            else if (nudForca.Text == "4" || nudForca.Text == "5")
            {
                lblModForça.Text = "-3";
            }
            else if (nudForca.Text == "6" || nudForca.Text == "7")
            {
                lblModForça.Text = "-2";
            }
            else if (nudForca.Text == "8" || nudForca.Text == "9")
            {
                lblModForça.Text = "-1";
            }
            else if (nudForca.Text == "10" || nudForca.Text == "11")
            {
                lblModForça.Text = "+0";
            }
            else if (nudForca.Text == "12" || nudForca.Text == "13")
            {
                lblModForça.Text = "+1";
            }
            else if (nudForca.Text == "14" || nudForca.Text == "15")
            {
                lblModForça.Text = "+2";
            }
            else if (nudForca.Text == "16" || nudForca.Text == "17")
            {
                lblModForça.Text = "+3";
            }
            else if (nudForca.Text == "18" || nudForca.Text == "19")
            {
                lblModForça.Text = "+4";
            }
            else if (nudForca.Text == "20" || nudForca.Text == "21")
            {
                lblModForça.Text = "+5";
            }
            else if (nudForca.Text == "22" || nudForca.Text == "23")
            {
                lblModForça.Text = "+6";
            }
            else if (nudForca.Text == "24" || nudForca.Text == "25")
            {
                lblModForça.Text = "+7";
            }
            else if (nudForca.Text == "26" || nudForca.Text == "27")
            {
                lblModForça.Text = "+8";
            }
            else if (nudForca.Text == "28" || nudForca.Text == "29")
            {
                lblModForça.Text = "+9";
            }
            else if (nudForca.Text == "30")
            {
                lblModForça.Text = "+10";
            }


            //if nud Destreza

            if (nudDestreza.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModDestreza.Text = "-6";
            }
            if (nudDestreza.Text == "1")
            {
                lblModDestreza.Text = "-5";
            }
            else if (nudDestreza.Text == "2" || nudDestreza.Text == "3")
            {
                lblModDestreza.Text = "-4";
            }
            else if (nudDestreza.Text == "4" || nudDestreza.Text == "5")
            {
                lblModDestreza.Text = "-3";
            }
            else if (nudDestreza.Text == "6" || nudDestreza.Text == "7")
            {
                lblModDestreza.Text = "-2";
            }
            else if (nudDestreza.Text == "8" || nudDestreza.Text == "9")
            {
                lblModDestreza.Text = "-1";
            }
            else if (nudDestreza.Text == "10" || nudDestreza.Text == "11")
            {
                lblModDestreza.Text = "+0";
            }
            else if (nudDestreza.Text == "12" || nudDestreza.Text == "13")
            {
                lblModDestreza.Text = "+1";
            }
            else if (nudDestreza.Text == "14" || nudDestreza.Text == "15")
            {
                lblModDestreza.Text = "+2";
            }
            else if (nudDestreza.Text == "16" || nudDestreza.Text == "17")
            {
                lblModDestreza.Text = "+3";
            }
            else if (nudDestreza.Text == "18" || nudDestreza.Text == "19")
            {
                lblModDestreza.Text = "+4";
            }
            else if (nudDestreza.Text == "20" || nudDestreza.Text == "21")
            {
                lblModDestreza.Text = "+5";
            }
            else if (nudDestreza.Text == "22" || nudDestreza.Text == "23")
            {
                lblModDestreza.Text = "+6";
            }
            else if (nudDestreza.Text == "24" || nudDestreza.Text == "25")
            {
                lblModDestreza.Text = "+7";
            }
            else if (nudDestreza.Text == "26" || nudDestreza.Text == "27")
            {
                lblModDestreza.Text = "+8";
            }
            else if (nudDestreza.Text == "28" || nudDestreza.Text == "29")
            {
                lblModDestreza.Text = "+9";
            }
            else if (nudDestreza.Text == "30")
            {
                lblModDestreza.Text = "+10";
            }


            //if nud Constituição

            if (nudConstituicao.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModConstituicao.Text = "-6";
            }
            if (nudConstituicao.Text == "1")
            {
                lblModConstituicao.Text = "-5";
            }
            else if (nudConstituicao.Text == "2" || nudConstituicao.Text == "3")
            {
                lblModConstituicao.Text = "-4";
            }
            else if (nudConstituicao.Text == "4" || nudConstituicao.Text == "5")
            {
                lblModConstituicao.Text = "-3";
            }
            else if (nudConstituicao.Text == "6" || nudConstituicao.Text == "7")
            {
                lblModConstituicao.Text = "-2";
            }
            else if (nudConstituicao.Text == "8" || nudConstituicao.Text == "9")
            {
                lblModConstituicao.Text = "-1";
            }
            else if (nudConstituicao.Text == "10" || nudConstituicao.Text == "11")
            {
                lblModConstituicao.Text = "+0";
            }
            else if (nudConstituicao.Text == "12" || nudConstituicao.Text == "13")
            {
                lblModConstituicao.Text = "+1";
            }
            else if (nudConstituicao.Text == "14" || nudConstituicao.Text == "15")
            {
                lblModConstituicao.Text = "+2";
            }
            else if (nudConstituicao.Text == "16" || nudConstituicao.Text == "17")
            {
                lblModConstituicao.Text = "+3";
            }
            else if (nudConstituicao.Text == "18" || nudConstituicao.Text == "19")
            {
                lblModConstituicao.Text = "+4";
            }
            else if (nudConstituicao.Text == "20" || nudConstituicao.Text == "21")
            {
                lblModConstituicao.Text = "+5";
            }
            else if (nudConstituicao.Text == "22" || nudConstituicao.Text == "23")
            {
                lblModConstituicao.Text = "+6";
            }
            else if (nudConstituicao.Text == "24" || nudConstituicao.Text == "25")
            {
                lblModConstituicao.Text = "+7";
            }
            else if (nudConstituicao.Text == "26" || nudConstituicao.Text == "27")
            {
                lblModConstituicao.Text = "+8";
            }
            else if (nudConstituicao.Text == "28" || nudConstituicao.Text == "29")
            {
                lblModConstituicao.Text = "+9";
            }
            else if (nudConstituicao.Text == "30")
            {
                lblModConstituicao.Text = "+10";
            }

            //if nud Inteligência 

            if (nudInteligencia.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModInteligencia.Text = "-6";
            }
            if (nudInteligencia.Text == "1")
            {
                lblModInteligencia.Text = "-5";
            }
            else if (nudInteligencia.Text == "2" || nudInteligencia.Text == "3")
            {
                lblModInteligencia.Text = "-4";
            }
            else if (nudInteligencia.Text == "4" || nudInteligencia.Text == "5")
            {
                lblModInteligencia.Text = "-3";
            }
            else if (nudInteligencia.Text == "6" || nudInteligencia.Text == "7")
            {
                lblModInteligencia.Text = "-2";
            }
            else if (nudInteligencia.Text == "8" || nudInteligencia.Text == "9")
            {
                lblModInteligencia.Text = "-1";
            }
            else if (nudInteligencia.Text == "10" || nudInteligencia.Text == "11")
            {
                lblModInteligencia.Text = "+0";
            }
            else if (nudInteligencia.Text == "12" || nudInteligencia.Text == "13")
            {
                lblModInteligencia.Text = "+1";
            }
            else if (nudInteligencia.Text == "14" || nudInteligencia.Text == "15")
            {
                lblModInteligencia.Text = "+2";
            }
            else if (nudInteligencia.Text == "16" || nudInteligencia.Text == "17")
            {
                lblModInteligencia.Text = "+3";
            }
            else if (nudInteligencia.Text == "18" || nudInteligencia.Text == "19")
            {
                lblModInteligencia.Text = "+4";
            }
            else if (nudInteligencia.Text == "20" || nudInteligencia.Text == "21")
            {
                lblModInteligencia.Text = "+5";
            }
            else if (nudInteligencia.Text == "22" || nudInteligencia.Text == "23")
            {
                lblModInteligencia.Text = "+6";
            }
            else if (nudInteligencia.Text == "24" || nudInteligencia.Text == "25")
            {
                lblModInteligencia.Text = "+7";
            }
            else if (nudInteligencia.Text == "26" || nudInteligencia.Text == "27")
            {
                lblModInteligencia.Text = "+8";
            }
            else if (nudInteligencia.Text == "28" || nudInteligencia.Text == "29")
            {
                lblModInteligencia.Text = "+9";
            }
            else if (nudInteligencia.Text == "30")
            {
                lblModInteligencia.Text = "+10";
            }


            //if nud Sabedoria 

            if (nudSabedoria.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModSabedoria.Text = "-6";
            }
            if (nudSabedoria.Text == "1")
            {
                lblModSabedoria.Text = "-5";
            }
            else if (nudSabedoria.Text == "2" || nudSabedoria.Text == "3")
            {
                lblModSabedoria.Text = "-4";
            }
            else if (nudSabedoria.Text == "4" || nudSabedoria.Text == "5")
            {
                lblModSabedoria.Text = "-3";
            }
            else if (nudSabedoria.Text == "6" || nudSabedoria.Text == "7")
            {
                lblModSabedoria.Text = "-2";
            }
            else if (nudSabedoria.Text == "8" || nudSabedoria.Text == "9")
            {
                lblModSabedoria.Text = "-1";
            }
            else if (nudSabedoria.Text == "10" || nudSabedoria.Text == "11")
            {
                lblModSabedoria.Text = "+0";
            }
            else if (nudSabedoria.Text == "12" || nudSabedoria.Text == "13")
            {
                lblModSabedoria.Text = "+1";
            }
            else if (nudSabedoria.Text == "14" || nudSabedoria.Text == "15")
            {
                lblModSabedoria.Text = "+2";
            }
            else if (nudSabedoria.Text == "16" || nudSabedoria.Text == "17")
            {
                lblModSabedoria.Text = "+3";
            }
            else if (nudSabedoria.Text == "18" || nudSabedoria.Text == "19")
            {
                lblModSabedoria.Text = "+4";
            }
            else if (nudSabedoria.Text == "20" || nudSabedoria.Text == "21")
            {
                lblModSabedoria.Text = "+5";
            }
            else if (nudSabedoria.Text == "22" || nudSabedoria.Text == "23")
            {
                lblModSabedoria.Text = "+6";
            }
            else if (nudSabedoria.Text == "24" || nudSabedoria.Text == "25")
            {
                lblModSabedoria.Text = "+7";
            }
            else if (nudSabedoria.Text == "26" || nudSabedoria.Text == "27")
            {
                lblModSabedoria.Text = "+8";
            }
            else if (nudSabedoria.Text == "28" || nudSabedoria.Text == "29")
            {
                lblModSabedoria.Text = "+9";
            }
            else if (nudSabedoria.Text == "30")
            {
                lblModSabedoria.Text = "+10";
            }


            //if nud Carisma

            if (nudCarisma.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModCarisma.Text = "-6";
            }
            if (nudCarisma.Text == "1")
            {
                lblModCarisma.Text = "-5";
            }
            else if (nudCarisma.Text == "2" || nudCarisma.Text == "3")
            {
                lblModCarisma.Text = "-4";
            }
            else if (nudCarisma.Text == "4" || nudCarisma.Text == "5")
            {
                lblModCarisma.Text = "-3";
            }
            else if (nudCarisma.Text == "6" || nudCarisma.Text == "7")
            {
                lblModCarisma.Text = "-2";
            }
            else if (nudCarisma.Text == "8" || nudCarisma.Text == "9")
            {
                lblModCarisma.Text = "-1";
            }
            else if (nudCarisma.Text == "10" || nudCarisma.Text == "11")
            {
                lblModCarisma.Text = "+0";
            }
            else if (nudCarisma.Text == "12" || nudCarisma.Text == "13")
            {
                lblModCarisma.Text = "+1";
            }
            else if (nudCarisma.Text == "14" || nudCarisma.Text == "15")
            {
                lblModCarisma.Text = "+2";
            }
            else if (nudCarisma.Text == "16" || nudCarisma.Text == "17")
            {
                lblModCarisma.Text = "+3";
            }
            else if (nudCarisma.Text == "18" || nudCarisma.Text == "19")
            {
                lblModCarisma.Text = "+4";
            }
            else if (nudCarisma.Text == "20" || nudCarisma.Text == "21")
            {
                lblModCarisma.Text = "+5";
            }
            else if (nudCarisma.Text == "22" || nudCarisma.Text == "23")
            {
                lblModCarisma.Text = "+6";
            }
            else if (nudCarisma.Text == "24" || nudCarisma.Text == "25")
            {
                lblModCarisma.Text = "+7";
            }
            else if (nudCarisma.Text == "26" || nudCarisma.Text == "27")
            {
                lblModCarisma.Text = "+8";
            }
            else if (nudCarisma.Text == "28" || nudCarisma.Text == "29")
            {
                lblModCarisma.Text = "+9";
            }
            else if (nudCarisma.Text == "30")
            {
                lblModCarisma.Text = "+10";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RPG_Load(object sender, EventArgs e)
        {

        }

        private void cmbboxClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubirDeNivel_Click(object sender, EventArgs e)
        {
            //Nivel

            Properties.Settings.Default.Nivel++;
            lblNivel.Text = "Nível: " + Properties.Settings.Default.Nivel;
            lblAvisoMod.Text = "Para salvar seu nível clique em 'salvar'";
            lblAvisoMod.Visible = true;

            //Anão da Colina
            if (Properties.Settings.Default.Raca == "Anão da Colina")
            {
                Properties.Settings.Default.PVTotais = Convert.ToInt32(nudPVTotal.Text) + 1;

            }
            Properties.Settings.Default.Save();
            nudPVTotal.Text = Convert.ToString(Properties.Settings.Default.PVTotais);

            //Classes 

            //Bárbaro
            if (Properties.Settings.Default.Classe == "Bárbaro" && Properties.Settings.Default.Nivel > 1)
            {
                Random D12Vida = new Random();
                int BarbaroVida = D12Vida.Next(1, 13);
                Properties.Settings.Default.PVTotais = Properties.Settings.Default.PVTotais + BarbaroVida;
                Properties.Settings.Default.PVAtuais = Properties.Settings.Default.PVTotais;
                nudPVTotal.Text = Convert.ToString(Properties.Settings.Default.PVTotais);
                nudPVAtuais.Text = Convert.ToString(Properties.Settings.Default.PVAtuais);
            }
            Properties.Settings.Default.Save();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnCarregarPersonagem_Click(object sender, EventArgs e)
        {
            //Carregar Personagem 

            txtboxNomePersonagem.Text = Properties.Settings.Default.Nome;
            cmbboxRaca.Text = Properties.Settings.Default.Raca;
            cmbboxClasse.Text = Properties.Settings.Default.Classe;
            lblNivel.Text = "Nível: " + Properties.Settings.Default.Nivel;
            nudForca.Text = Convert.ToString(Properties.Settings.Default.Forca);
            nudDestreza.Text = Convert.ToString(Properties.Settings.Default.Destreza);
            nudConstituicao.Text = Convert.ToString(Properties.Settings.Default.Constituicao);
            nudInteligencia.Text = Convert.ToString(Properties.Settings.Default.Inteligencia);
            nudSabedoria.Text = Convert.ToString(Properties.Settings.Default.Sabedoria);
            nudCarisma.Text = Convert.ToString(Properties.Settings.Default.Carisma);
            nudPVTotal.Text = Convert.ToString(Properties.Settings.Default.PVTotais);
            nudPVAtuais.Text = Convert.ToString(Properties.Settings.Default.PVAtuais);
            rtxtBoxItens.Text = Properties.Settings.Default.Itens;
            nudProficiencia.Text = Convert.ToString(Properties.Settings.Default.Proficiencia);
            lblAvisoMod.Visible = false;

            //ifs nuds

            //if nud Força

            if (nudForca.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModForça.Text = "-6";
            }
            if (nudForca.Text == "1")
            {
                lblModForça.Text = "-5";
            }
            else if (nudForca.Text == "2" || nudForca.Text == "3")
            {
                lblModForça.Text = "-4";
            }
            else if (nudForca.Text == "4" || nudForca.Text == "5")
            {
                lblModForça.Text = "-3";
            }
            else if (nudForca.Text == "6" || nudForca.Text == "7")
            {
                lblModForça.Text = "-2";
            }
            else if (nudForca.Text == "8" || nudForca.Text == "9")
            {
                lblModForça.Text = "-1";
            }
            else if (nudForca.Text == "10" || nudForca.Text == "11")
            {
                lblModForça.Text = "+0";
            }
            else if (nudForca.Text == "12" || nudForca.Text == "13")
            {
                lblModForça.Text = "+1";
            }
            else if (nudForca.Text == "14" || nudForca.Text == "15")
            {
                lblModForça.Text = "+2";
            }
            else if (nudForca.Text == "16" || nudForca.Text == "17")
            {
                lblModForça.Text = "+3";
            }
            else if (nudForca.Text == "18" || nudForca.Text == "19")
            {
                lblModForça.Text = "+4";
            }
            else if (nudForca.Text == "20" || nudForca.Text == "21")
            {
                lblModForça.Text = "+5";
            }
            else if (nudForca.Text == "22" || nudForca.Text == "23")
            {
                lblModForça.Text = "+6";
            }
            else if (nudForca.Text == "24" || nudForca.Text == "25")
            {
                lblModForça.Text = "+7";
            }
            else if (nudForca.Text == "26" || nudForca.Text == "27")
            {
                lblModForça.Text = "+8";
            }
            else if (nudForca.Text == "28" || nudForca.Text == "29")
            {
                lblModForça.Text = "+9";
            }
            else if (nudForca.Text == "30")
            {
                lblModForça.Text = "+10";
            }
            

            //if nud Destreza

            if (nudDestreza.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModDestreza.Text = "-6";
            }
            if (nudDestreza.Text == "1")
            {
                lblModDestreza.Text = "-5";
            }
            else if (nudDestreza.Text == "2" || nudDestreza.Text == "3")
            {
                lblModDestreza.Text = "-4";
            }
            else if (nudDestreza.Text == "4" || nudDestreza.Text == "5")
            {
                lblModDestreza.Text = "-3";
            }
            else if (nudDestreza.Text == "6" || nudDestreza.Text == "7")
            {
                lblModDestreza.Text = "-2";
            }
            else if (nudDestreza.Text == "8" || nudDestreza.Text == "9")
            {
                lblModDestreza.Text = "-1";
            }
            else if (nudDestreza.Text == "10" || nudDestreza.Text == "11")
            {
                lblModDestreza.Text = "+0";
            }
            else if (nudDestreza.Text == "12" || nudDestreza.Text == "13")
            {
                lblModDestreza.Text = "+1";
            }
            else if (nudDestreza.Text == "14" || nudDestreza.Text == "15")
            {
                lblModDestreza.Text = "+2";
            }
            else if (nudDestreza.Text == "16" || nudDestreza.Text == "17")
            {
                lblModDestreza.Text = "+3";
            }
            else if (nudDestreza.Text == "18" || nudDestreza.Text == "19")
            {
                lblModDestreza.Text = "+4";
            }
            else if (nudDestreza.Text == "20" || nudDestreza.Text == "21")
            {
                lblModDestreza.Text = "+5";
            }
            else if (nudDestreza.Text == "22" || nudDestreza.Text == "23")
            {
                lblModDestreza.Text = "+6";
            }
            else if (nudDestreza.Text == "24" || nudDestreza.Text == "25")
            {
                lblModDestreza.Text = "+7";
            }
            else if (nudDestreza.Text == "26" || nudDestreza.Text == "27")
            {
                lblModDestreza.Text = "+8";
            }
            else if (nudDestreza.Text == "28" || nudDestreza.Text == "29")
            {
                lblModDestreza.Text = "+9";
            }
            else if (nudDestreza.Text == "30")
            {
                lblModDestreza.Text = "+10";
            }
           

            //if nud Constituição

            if (nudConstituicao.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModConstituicao.Text = "-6";
            }
            if (nudConstituicao.Text == "1")
            {
                lblModConstituicao.Text = "-5";
            }
            else if (nudConstituicao.Text == "2" || nudConstituicao.Text == "3")
            {
                lblModConstituicao.Text = "-4";
            }
            else if (nudConstituicao.Text == "4" || nudConstituicao.Text == "5")
            {
                lblModConstituicao.Text = "-3";
            }
            else if (nudConstituicao.Text == "6" || nudConstituicao.Text == "7")
            {
                lblModConstituicao.Text = "-2";
            }
            else if (nudConstituicao.Text == "8" || nudConstituicao.Text == "9")
            {
                lblModConstituicao.Text = "-1";
            }
            else if (nudConstituicao.Text == "10" || nudConstituicao.Text == "11")
            {
                lblModConstituicao.Text = "+0";
            }
            else if (nudConstituicao.Text == "12" || nudConstituicao.Text == "13")
            {
                lblModConstituicao.Text = "+1";
            }
            else if (nudConstituicao.Text == "14" || nudConstituicao.Text == "15")
            {
                lblModConstituicao.Text = "+2";
            }
            else if (nudConstituicao.Text == "16" || nudConstituicao.Text == "17")
            {
                lblModConstituicao.Text = "+3";
            }
            else if (nudConstituicao.Text == "18" || nudConstituicao.Text == "19")
            {
                lblModConstituicao.Text = "+4";
            }
            else if (nudConstituicao.Text == "20" || nudConstituicao.Text == "21")
            {
                lblModConstituicao.Text = "+5";
            }
            else if (nudConstituicao.Text == "22" || nudConstituicao.Text == "23")
            {
                lblModConstituicao.Text = "+6";
            }
            else if (nudConstituicao.Text == "24" || nudConstituicao.Text == "25")
            {
                lblModConstituicao.Text = "+7";
            }
            else if (nudConstituicao.Text == "26" || nudConstituicao.Text == "27")
            {
                lblModConstituicao.Text = "+8";
            }
            else if (nudConstituicao.Text == "28" || nudConstituicao.Text == "29")
            {
                lblModConstituicao.Text = "+9";
            }
            else if (nudConstituicao.Text == "30")
            {
                lblModConstituicao.Text = "+10";
            }
           
            //if nud Inteligência 

            if (nudInteligencia.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModInteligencia.Text = "-6";
            }
            if (nudInteligencia.Text == "1")
            {
                lblModInteligencia.Text = "-5";
            }
            else if (nudInteligencia.Text == "2" || nudInteligencia.Text == "3")
            {
                lblModInteligencia.Text = "-4";
            }
            else if (nudInteligencia.Text == "4" || nudInteligencia.Text == "5")
            {
                lblModInteligencia.Text = "-3";
            }
            else if (nudInteligencia.Text == "6" || nudInteligencia.Text == "7")
            {
                lblModInteligencia.Text = "-2";
            }
            else if (nudInteligencia.Text == "8" || nudInteligencia.Text == "9")
            {
                lblModInteligencia.Text = "-1";
            }
            else if (nudInteligencia.Text == "10" || nudInteligencia.Text == "11")
            {
                lblModInteligencia.Text = "+0";
            }
            else if (nudInteligencia.Text == "12" || nudInteligencia.Text == "13")
            {
                lblModInteligencia.Text = "+1";
            }
            else if (nudInteligencia.Text == "14" || nudInteligencia.Text == "15")
            {
                lblModInteligencia.Text = "+2";
            }
            else if (nudInteligencia.Text == "16" || nudInteligencia.Text == "17")
            {
                lblModInteligencia.Text = "+3";
            }
            else if (nudInteligencia.Text == "18" || nudInteligencia.Text == "19")
            {
                lblModInteligencia.Text = "+4";
            }
            else if (nudInteligencia.Text == "20" || nudInteligencia.Text == "21")
            {
                lblModInteligencia.Text = "+5";
            }
            else if (nudInteligencia.Text == "22" || nudInteligencia.Text == "23")
            {
                lblModInteligencia.Text = "+6";
            }
            else if (nudInteligencia.Text == "24" || nudInteligencia.Text == "25")
            {
                lblModInteligencia.Text = "+7";
            }
            else if (nudInteligencia.Text == "26" || nudInteligencia.Text == "27")
            {
                lblModInteligencia.Text = "+8";
            }
            else if (nudInteligencia.Text == "28" || nudInteligencia.Text == "29")
            {
                lblModInteligencia.Text = "+9";
            }
            else if (nudInteligencia.Text == "30")
            {
                lblModInteligencia.Text = "+10";
            }
          

            //if nud Sabedoria 

            if (nudSabedoria.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModSabedoria.Text = "-6";
            }
            if (nudSabedoria.Text == "1")
            {
                lblModSabedoria.Text = "-5";
            }
            else if (nudSabedoria.Text == "2" || nudSabedoria.Text == "3")
            {
                lblModSabedoria.Text = "-4";
            }
            else if (nudSabedoria.Text == "4" || nudSabedoria.Text == "5")
            {
                lblModSabedoria.Text = "-3";
            }
            else if (nudSabedoria.Text == "6" || nudSabedoria.Text == "7")
            {
                lblModSabedoria.Text = "-2";
            }
            else if (nudSabedoria.Text == "8" || nudSabedoria.Text == "9")
            {
                lblModSabedoria.Text = "-1";
            }
            else if (nudSabedoria.Text == "10" || nudSabedoria.Text == "11")
            {
                lblModSabedoria.Text = "+0";
            }
            else if (nudSabedoria.Text == "12" || nudSabedoria.Text == "13")
            {
                lblModSabedoria.Text = "+1";
            }
            else if (nudSabedoria.Text == "14" || nudSabedoria.Text == "15")
            {
                lblModSabedoria.Text = "+2";
            }
            else if (nudSabedoria.Text == "16" || nudSabedoria.Text == "17")
            {
                lblModSabedoria.Text = "+3";
            }
            else if (nudSabedoria.Text == "18" || nudSabedoria.Text == "19")
            {
                lblModSabedoria.Text = "+4";
            }
            else if (nudSabedoria.Text == "20" || nudSabedoria.Text == "21")
            {
                lblModSabedoria.Text = "+5";
            }
            else if (nudSabedoria.Text == "22" || nudSabedoria.Text == "23")
            {
                lblModSabedoria.Text = "+6";
            }
            else if (nudSabedoria.Text == "24" || nudSabedoria.Text == "25")
            {
                lblModSabedoria.Text = "+7";
            }
            else if (nudSabedoria.Text == "26" || nudSabedoria.Text == "27")
            {
                lblModSabedoria.Text = "+8";
            }
            else if (nudSabedoria.Text == "28" || nudSabedoria.Text == "29")
            {
                lblModSabedoria.Text = "+9";
            }
            else if (nudSabedoria.Text == "30")
            {
                lblModSabedoria.Text = "+10";
            }
           

            //if nud Carisma

            if (nudCarisma.Text == "0")
            {
                MessageBox.Show("Insira um valor entre 1 e 30!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lblModCarisma.Text = "-6";
            }
            if (nudCarisma.Text == "1")
            {
                lblModCarisma.Text = "-5";
            }
            else if (nudCarisma.Text == "2" || nudCarisma.Text == "3")
            {
                lblModCarisma.Text = "-4";
            }
            else if (nudCarisma.Text == "4" || nudCarisma.Text == "5")
            {
                lblModCarisma.Text = "-3";
            }
            else if (nudCarisma.Text == "6" || nudCarisma.Text == "7")
            {
                lblModCarisma.Text = "-2";
            }
            else if (nudCarisma.Text == "8" || nudCarisma.Text == "9")
            {
                lblModCarisma.Text = "-1";
            }
            else if (nudCarisma.Text == "10" || nudCarisma.Text == "11")
            {
                lblModCarisma.Text = "+0";
            }
            else if (nudCarisma.Text == "12" || nudCarisma.Text == "13")
            {
                lblModCarisma.Text = "+1";
            }
            else if (nudCarisma.Text == "14" || nudCarisma.Text == "15")
            {
                lblModCarisma.Text = "+2";
            }
            else if (nudCarisma.Text == "16" || nudCarisma.Text == "17")
            {
                lblModCarisma.Text = "+3";
            }
            else if (nudCarisma.Text == "18" || nudCarisma.Text == "19")
            {
                lblModCarisma.Text = "+4";
            }
            else if (nudCarisma.Text == "20" || nudCarisma.Text == "21")
            {
                lblModCarisma.Text = "+5";
            }
            else if (nudCarisma.Text == "22" || nudCarisma.Text == "23")
            {
                lblModCarisma.Text = "+6";
            }
            else if (nudCarisma.Text == "24" || nudCarisma.Text == "25")
            {
                lblModCarisma.Text = "+7";
            }
            else if (nudCarisma.Text == "26" || nudCarisma.Text == "27")
            {
                lblModCarisma.Text = "+8";
            }
            else if (nudCarisma.Text == "28" || nudCarisma.Text == "29")
            {
                lblModCarisma.Text = "+9";
            }
            else if (nudCarisma.Text == "30")
            {
                lblModCarisma.Text = "+10";
            }

        }

        private void lblNivel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Excluir Personagem
            MessageBox.Show(Properties.Settings.Default.Nome + " caiu em batalha!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Properties.Settings.Default.Nome = "";
            Properties.Settings.Default.Raca = "";
            Properties.Settings.Default.Classe = "";
            Properties.Settings.Default.Forca = 0;
            Properties.Settings.Default.Destreza = 0;
            Properties.Settings.Default.Constituicao = 0;
            Properties.Settings.Default.Inteligencia = 0;
            Properties.Settings.Default.Sabedoria = 0;
            Properties.Settings.Default.Carisma = 0;
            Properties.Settings.Default.Nivel = 0;
            Properties.Settings.Default.PVTotais = 0;
            Properties.Settings.Default.PVAtuais = 0;
            Properties.Settings.Default.Proficiencia = 0;
            txtboxNomePersonagem.Text = "";
            cmbboxRaca.Text = "";
            cmbboxClasse.Text = "";
            lblNivel.Text = "Nível: " + Properties.Settings.Default.Nivel;
            nudForca.Text = Convert.ToString(Properties.Settings.Default.Forca);
            nudDestreza.Text = Convert.ToString(Properties.Settings.Default.Destreza);
            nudConstituicao.Text = Convert.ToString(Properties.Settings.Default.Constituicao);
            nudInteligencia.Text = Convert.ToString(Properties.Settings.Default.Inteligencia);
            nudSabedoria.Text = Convert.ToString(Properties.Settings.Default.Sabedoria);
            nudCarisma.Text = Convert.ToString(Properties.Settings.Default.Carisma);
            nudPVTotal.Text = Convert.ToString(Properties.Settings.Default.PVTotais);
            nudPVAtuais.Text = Convert.ToString(Properties.Settings.Default.PVAtuais);
            nudProficiencia.Text = Convert.ToString(Properties.Settings.Default.Proficiencia);
            rtxtBoxItens.Text = "";
            Properties.Settings.Default.Vezes = 0;
            lblModCarisma.Text = "";
            lblModForça.Text = "";
            lblModDestreza.Text = "";
            lblModConstituicao.Text = "";
            lblModInteligencia.Text = "";
            lblModSabedoria.Text = "";
            Properties.Settings.Default.Save();

            pictureBoxFoto.Image = Properties.Resources.caveira;
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void nudForca_ValueChanged(object sender, EventArgs e)
        {
            lblAvisoMod.Visible = true;
            lblAvisoMod.Text = "Para atualizar seus modificadores de força salve seu personagem!";

        }

        private void nudDestreza_ValueChanged(object sender, EventArgs e)
        {
            lblAvisoMod.Visible = true;
            lblAvisoMod.Text = "Para atualizar seus modificadores de destreza salve seu personagem!";
        }

        private void nudConstituicao_ValueChanged(object sender, EventArgs e)
        {
            lblAvisoMod.Visible = true;
            lblAvisoMod.Text = "Para atualizar seus modificadores de constituição salve seu personagem!";
        }

        private void nudInteligencia_ValueChanged(object sender, EventArgs e)
        {
            lblAvisoMod.Visible = true;
            lblAvisoMod.Text = "Para atualizar seus modificadores de inteligência salve seu personagem!";
        }

        private void nudSabedoria_ValueChanged(object sender, EventArgs e)
        {
            lblAvisoMod.Visible = true;
            lblAvisoMod.Text = "Para atualizar seus modificadores de sabedoria salve seu personagem!";
        }

        private void nudCarisma_ValueChanged(object sender, EventArgs e)
        {
            lblAvisoMod.Visible = true;
            lblAvisoMod.Text = "Para atualizar seus modificadores de carisma salve seu personagem!";
        }

        private void btnExcluirItens_Click(object sender, EventArgs e)
        {
            rtxtBoxItens.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            if (foto.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.ImageLocation = foto.FileName;
            }
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}


