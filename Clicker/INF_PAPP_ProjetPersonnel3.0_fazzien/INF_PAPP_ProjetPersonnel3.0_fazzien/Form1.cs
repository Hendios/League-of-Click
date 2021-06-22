/*Nom: Fazzi Enzo
 *Date: 09.03.17
 *But: Création du Clicker
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Design;

namespace INF_PAPP_ProjetPersonnel3._0_fazzien
{
    /*Nom: Fazzi Enzo
     *Date: 09.03.17
     *But: Déclaration de toutes les variables
     */
    public partial class frm_Clicker : Form
    {
        //
        //Variables de gestion des différents items
        //
        int switchInfini = 0;
        int switchLuden = 0;
        int switchMorello = 0;
        int switchRabadon = 0;
        int switchmusique = 0;
        int valeur_dmg;
        int valeur_dmgP;
        //
        //
        int nbs_PO = 0;        
        int pts_vie = 10;
        int dmgA = 1;
        int dmgP = 0;
        int lvl = 0;
        int saison = 1;
        const int prct = 100;
        const int PoCheat1 = 10000;
        const int PoCheat2 = 10000000;
        //
        //Variables qui définissent la vie des 10 champions de chaques niveaux
        //
        const int niv1 = 10;
        const int niv2 = 50;
        const int niv3 = 100;
        const int niv4 = 500;
        const int niv5 = 1000;
        const int niv6 = 10000;
        const int niv7 = 50000;
        const int niv8 = 500000;
        const int niv9 = 2000000;
        const int Boss = 100000000;
        //
        //Dégâts Actif
        //
        //Défini le coût de l'item          Défini la valeur de dégâts
        const int LameInfini1PO = 10;       const int LameInfini1dmg = 5;

        const int LameInfini2PO = 100;      const int LameInfini2dmg = 50;

        const int LameInfini3PO = 200;      const int LameInfini3dmg = 100;

        const int LameInfini4PO = 1000;     const int LameInfini4dmg = 500;

        const int LameInfini5PO = 5000;     const int LameInfini5dmg = 10000;

        const int LameInfini6PO = 25000;    const int LameInfini6dmg = 50000;

        const int LameInfini7PO = 300000;   const int LameInfini7dmg = 100000;

        const int LameInfini8PO = 4000000;  const int LameInfini8dmg = 500000;

        const int LameInfiniPO = 200000000; const int LameInfinidmg = 5000000;
        //
        //Dégâts Passif Luden
        //
        const int Luden1PO = 20;            const int Luden1dmg = 1;

        const int Luden2PO = 5000;          const int Luden2dmg = 100;

        const int Luden3PO = 250000;        const int Luden3dmg = 5000;

        const int LudenPO = 20000000;       const int Ludendmg = 100000;
        //
        //Dégâts Passif Morello
        //
        const int Morello1PO = 50;          const int Morello1dmg = 2;

        const int Morello2PO = 50000;       const int Morello2dmg = 250;

        const int Morello3PO = 1000000;     const int Morello3dmg = 12500;

        const int MorelloPO = 50000000;     const int Morellodmg = 300000;
        //
        //Dégâts Passif Rabadon
        //
        const int Rabadon1PO = 250;         const int Rabadon1dmg = 5;

        const int Rabadon2PO = 250000;      const int Rabadon2dmg = 500;

        const int Rabadon3PO = 10000000;    const int Rabadon3dmg = 50000;

        const int RabadonPO = 200000000;    const int Rabadondmg = 1000000;
        //
        //Défini quelles variables sera quelles musique
        //
        SoundPlayer music1 = new SoundPlayer("Braum _ Music - League of Legends.wav");
        SoundPlayer music2 = new SoundPlayer("Demacia Rising _ Music - League of Legends.wav");
        SoundPlayer music3 = new SoundPlayer("Tiny Masterpiece of Evil _ Music - League of Legends.wav");
        SoundPlayer music4 = new SoundPlayer("Warsongs - Flash Funk (Marshmello Remix) _ Music - League of Legends.wav");
        SoundPlayer music5 = new SoundPlayer("Warsongs - Piercing Light (Mako Remix) _ Music - League of Legends.wav");
        SoundPlayer music6 = new SoundPlayer("Warsongs - The Glory (James Egbert Remix) _ Music - League of Legends.wav");
        //
        //Défini les différentes images
        //
        Image Teemo = Image.FromFile("Teemo.png");
        Image Jax = Image.FromFile("Jax.png");
        Image Nami = Image.FromFile("Nami.png");
        Image Zed = Image.FromFile("Zed.png");
        Image Riven = Image.FromFile("Riven.png");
        Image Rek = Image.FromFile("Rek_Sai.png");
        Image Fizz = Image.FromFile("Fizz.png");
        Image Kalista = Image.FromFile("Kalista.png");
        Image Renekton = Image.FromFile("Renekton.png");
        Image Veigar = Image.FromFile("Veigar.png");
        //
        //
        DateTime TempsActuel;//Récupère l'heure tous les 1 centième de secondes
        TimeSpan TempsPasse;//Fait la différence de temps passé entre le click du bouton "Démarrer" et le temps actuel
        DateTime TempsDepart;//Récupère l'heure quand on appuie sur le bouton "Démarrer"
        //
        /*Nom: Fazzi Enzo
        *Date: 09.03.17
        *But: Initialisation dans la form
        */
        public frm_Clicker()
        {
            InitializeComponent();//Permet l'initialisation de tout ce qu'il y a dans le tableau
            //
            //Permet de tout rendre invisible
            //
            btn_rabadon.Visible = false;
            btn_morello.Visible = false;
            btn_luden.Visible = false;
            btn_dmgAC.Visible = false;
            btn_dmgA.Visible = false;
            lbl_dmgS.Visible = false;
            lbl_saison.Visible = false;
            lbl_lvl.Visible = false;
            pb_life.Visible = false;
            lbl_PO.Visible = false;
            btn_music1.Visible = false;
            btn_music2.Visible = false;
            btn_music3.Visible = false;
            btn_music4.Visible = false;
            btn_music5.Visible = false;
            btn_music6.Visible = false;
            Menu.Visible = false;
            //
            //Rend non clickable tous les boutons des items
            //
            btn_rabadon.Enabled = false;
            btn_morello.Enabled = false;
            btn_luden.Enabled = false;
            btn_dmgAC.Enabled = false;
            //
            //
            btn_dmgA.BackgroundImage = new Bitmap("Poing Riot.png");//Affiche le logo de Riot dans le bouton "btn_dmgA"
            pb_life.Value = 0;//Initialise la vie de la progressbar à 0
            pb_life.Minimum = 0;//Initialise la vie minimum de la progressbar à 0
            pb_life.Maximum = 100;//Initialise la vie maximum de la progressbar à 100
            //
            //Mise en place de ce que le chrono affichera
            //
            lbl_min.Text = "00";
            lbl_2pts_min.Text = " : ";
            lbl_sec.Text = "00";
            lbl_2pts_sec.Text = " : ";
            lbl_msec.Text = "00";
            //
            //Rend invisible le chrono
            //
            lbl_min.Visible = false;
            lbl_2pts_min.Visible = false;
            lbl_sec.Visible = false;
            lbl_2pts_sec.Visible = false;
            lbl_msec.Visible = false;
            //
        }
        /*Nom: Fazzi Enzo
        *Date: 09.03.17
        *But: Arrêt du Chrono
        */
        private void frm_Clicker_Load(object sender, EventArgs e)
        {
            Chrono.Enabled = false;//Arret du Chrono
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //
            //Permet de tout rendre visible
            //
            btn_rabadon.Visible = true;
            btn_morello.Visible = true;
            btn_luden.Visible = true;
            btn_dmgAC.Visible = true;
            btn_dmgA.Visible = true;
            pb_life.Visible = true;
            lbl_PO.Visible = true;
            lbl_min.Visible = true;
            lbl_2pts_min.Visible = true;
            lbl_sec.Visible = true;
            lbl_2pts_sec.Visible = true;
            lbl_msec.Visible = true;
            lbl_dmgS.Visible = true;
            lbl_saison.Visible = true;
            lbl_lvl.Visible = true;
            Menu.Visible = true;
            //
            //Réinitialise les valeur de la progressbar
            //
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
            //
            //
            btn_Start.Visible = false;//Rend invisible le bouton Start
            //
            //
            TempsDepart = DateTime.Now;//Récupère l'heure de départ
            Chrono.Start();//Démarre le chrono
            TimerPb.Start();//Démarre le second chrono
            //
        }

        private void MenuRéinitialiser_Click(object sender, EventArgs e)
        {
            //
            //Réinitialise la valeur de la progressbar
            //
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
            //
            //Réinitialise toutes les variables
            //
            lvl = 0;
            dmgA = 1;
            dmgP = 0;
            saison = 1;
            nbs_PO = 0;
            pts_vie = 10;
            switchInfini = 0;
            switchLuden = 0;
            switchMorello = 0;
            switchRabadon = 0;
            switchmusique = 0;
            //
            //Stop toutes les musiques
            //
            music1.Stop();
            music2.Stop();
            music3.Stop();
            music4.Stop();
            music5.Stop();
            music6.Stop();
            //
            //Permet de tout rendre invisible
            //
            btn_rabadon.Visible = false;
            btn_morello.Visible = false;
            btn_luden.Visible = false;
            btn_dmgAC.Visible = false;
            btn_dmgA.Visible = false;
            pb_life.Visible = false;
            lbl_lvl.Visible = false;
            lbl_saison.Visible = false;
            lbl_dmgS.Visible = false;
            lbl_PO.Visible = false;
            btn_dmgA.Visible = false;
            btn_luden.Visible = false;
            btn_morello.Visible = false;
            btn_rabadon.Visible = false;
            btn_music1.Visible = false;
            btn_music2.Visible = false;
            btn_music3.Visible = false;
            btn_music4.Visible = false;
            btn_music5.Visible = false;
            btn_music6.Visible = false;
            Menu.Visible = false;
            lbl_min.Visible = false;
            lbl_2pts_min.Visible = false;
            lbl_sec.Visible = false;
            lbl_2pts_sec.Visible = false;
            lbl_msec.Visible = false;
            //
            //
            btn_Start.Visible = true;//Rend visible le bouton Start
            Chrono.Stop();//Stop le chrono
        }

        private void btn_dmgA_Click(object sender, EventArgs e)
        {
            valeur_dmg = dmgA * prct / pts_vie;//Calcul pour faire les dégâts à la progressbar
            pb_life.Increment(valeur_dmg);//Reprend la valeur au dessus (calcul) et fait les dégâts à la progressbar
        }

        private void btn_dmgAC_Click(object sender, EventArgs e)
        {
            switchInfini++;

            switch (switchInfini)
            {
                default:
                    dmgA = 1;//Défini la valeur de dégâts par click
                    btn_dmgAC.Text = "Lame de Doran/Lame d'infini";//Changement du texte du bouton Infini
                    break;//Sort de la fonction
                //
                case 1:
                    dmgA = dmgA + LameInfini1dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Epée longue/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini1PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 2:
                    dmgA = dmgA + LameInfini2dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Sabre Vicié/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini2PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 3:
                    dmgA = dmgA + LameInfini3dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Phage/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini3PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 4:
                    dmgA = dmgA + LameInfini4dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Pioche/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini4PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 5:
                    dmgA = dmgA + LameInfini5dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Dernier Souffle/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini5PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 6:
                    dmgA = dmgA + LameInfini6dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "BF Glaive/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini6PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 7:
                    dmgA = dmgA + LameInfini7dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Soif-de-sang/Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini7PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 8:
                    dmgA = dmgA + LameInfini8dmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Lame d'infini";
                    nbs_PO = nbs_PO - LameInfini8PO;//Enlève des PO à la variable des PO
                    break;
                //
                case 9:
                    dmgA = dmgA + LameInfinidmg;//Ajoute une valeur aux dégâts par click
                    btn_dmgAC.Text = "Fin de l'item (Lame d'infini)";
                    nbs_PO = nbs_PO - LameInfiniPO;//Enlève des PO à la variable des PO
                    btn_dmgAC.Enabled = false;//Grise le bouton de dégâts
                    break;
            }
        }

        private void btn_luden_Click(object sender, EventArgs e)
        {
            switchLuden++;

            switch (switchLuden)
            {
                default:
                    btn_luden.Text = "Tome d'amplification/Luden";//Changement du texte du bouton Luden
                    break;
                    //
                case 1:
                    dmgP = dmgP + Luden1dmg;//Ajoute une valeur aux dégâts passif
                    btn_luden.Text = "Feu Follet éthéré/Luden";
                    nbs_PO = nbs_PO - Luden1PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 2:
                    dmgP = dmgP + Luden2dmg;//Ajoute une valeur aux dégâts passif
                    btn_luden.Text = "Baguette trop grosse/Luden";
                    nbs_PO = nbs_PO - Luden2PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 3:
                    dmgP = dmgP + Luden3dmg;//Ajoute une valeur aux dégâts passif
                    btn_luden.Text = "Echo de Luden";
                    nbs_PO = nbs_PO - Luden3PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 4:
                    dmgP = dmgP + Ludendmg;//Ajoute une valeur aux dégâts passif
                    btn_luden.Text = "Fin de l'item (Echo de Luden)";
                    nbs_PO = nbs_PO - LudenPO;//Enlève des PO à la variable des PO
                    btn_luden.Enabled = false;//Grise le bouton Luden
                    break;
            }
        }

        private void btn_morello_Click(object sender, EventArgs e)
        {
            switchMorello++;

            switch (switchMorello)
            {
                default:
                    btn_luden.Text = "Codex Méphitique/Morello";//Changement du texte du bouton Morello
                    break;
                    //
                case 1:
                    dmgP = dmgP + Morello1dmg;//Ajoute une valeur aux dégâts passif
                    btn_morello.Text = "Tome d'amplification/Morello";
                    nbs_PO = nbs_PO - Morello1PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 2:
                    dmgP = dmgP + Morello2dmg;//Ajoute une valeur aux dégâts passif
                    btn_morello.Text = "Chapitre perdu/Morello";
                    nbs_PO = nbs_PO - Morello2PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 3:
                    dmgP = dmgP + Morello3dmg;//Ajoute une valeur aux dégâts passif
                    btn_morello.Text = "Morellonomicon";
                    nbs_PO = nbs_PO - Morello3PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 4:
                    dmgP = dmgP + Morellodmg;//Ajoute une valeur aux dégâts passif
                    btn_morello.Text = "Fin de l'item (Morellonomicon)";
                    nbs_PO = nbs_PO - MorelloPO;//Enlève des PO à la variable des PO
                    btn_morello.Enabled = false;//Grise le bouton Morello
                    break;
            }
        }

        private void btn_rabadon_Click(object sender, EventArgs e)
        {
            switchRabadon++;

            switch (switchRabadon)
            {
                default:
                    btn_luden.Text = "Tome d'amplification/Rabadon";//Changement du texte du bouton Rabadon
                    break;
                    //
                case 1:
                    dmgP = dmgP + Rabadon1dmg;//Ajoute une valeur aux dégâts passif
                    btn_rabadon.Text = "Baguette explosive/Rabadon";
                    nbs_PO = nbs_PO - Rabadon1PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 2:
                    dmgP = dmgP + Rabadon2dmg;//Ajoute une valeur aux dégâts passif
                    btn_rabadon.Text = "Baguette trop grosse/Rabadon";
                    nbs_PO = nbs_PO - Rabadon2PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 3:
                    dmgP = dmgP + Rabadon3dmg;//Ajoute une valeur aux dégâts passif
                    btn_rabadon.Text = "Coiffe de Rabadon";
                    nbs_PO = nbs_PO - Rabadon3PO;//Enlève des PO à la variable des PO
                    break;
                    //
                case 4:
                    dmgP = dmgP + Rabadondmg;//Ajoute une valeur aux dégâts passif
                    btn_rabadon.Text = "Fin de l'item (Coiffe de Rabadon)";
                    nbs_PO = nbs_PO - RabadonPO;//Enlève des PO à la variable des PO
                    btn_rabadon.Enabled = false;//Grise le bouton Rabadon
                    break;
            }
        }

        private void MenuAide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                  Règles du jeu:" + "\r\n" + "\r\n" + "\r\n" +
                                               "Le but de ce jeu est de cliquer sur le bouton du milieu!");//Affiche une Pop-Up et affiche ce message
        }//Fin aideToolStripMenuItem_Click

        private void MenuMusique_Click(object sender, EventArgs e)
        {
            switchmusique++;

            switch (switchmusique)
            {
                case 1:
                    //
                    //Rend visible les boutons pour la musique
                    //
                    btn_music1.Visible = true;
                    btn_music2.Visible = true;
                    btn_music3.Visible = true;
                    btn_music4.Visible = true;
                    btn_music5.Visible = true;
                    btn_music6.Visible = true;
                    break;
                //
                case 2:
                    //
                    //Rend invisible les boutons pour la musique
                    //
                    btn_music1.Visible = false;
                    btn_music2.Visible = false;
                    btn_music3.Visible = false;
                    btn_music4.Visible = false;
                    btn_music5.Visible = false;
                    btn_music6.Visible = false;

                    switchmusique = 0;
                    break;
            }
        }

        private void btn_music1_Click(object sender, EventArgs e)
        {
            //Stop les musiques
            music2.Stop();
            music3.Stop();
            music4.Stop();
            music5.Stop();
            music6.Stop();
            //
            //Démarre la musique et se joue en boucle
            music1.PlayLooping();
            //
        }

        private void btn_music2_Click(object sender, EventArgs e)
        {
            //Stop les musiques
            music1.Stop();
            music3.Stop();
            music4.Stop();
            music5.Stop();
            music6.Stop();
            //
            //Démarre la musique et se joue en boucle
            music2.PlayLooping();
            //
        }

        private void btn_music3_Click(object sender, EventArgs e)
        {
            //Stop les musiques
            music1.Stop();
            music2.Stop();
            music4.Stop();
            music5.Stop();
            music6.Stop();
            //
            //Démarre la musique et se joue en boucle
            music3.PlayLooping();
            //
        }

        private void btn_music4_Click(object sender, EventArgs e)
        {
            //Stop les musiques
            music1.Stop();
            music2.Stop();
            music3.Stop();
            music5.Stop();
            music6.Stop();
            //
            //Démarre la musique et se joue en boucle
            music4.PlayLooping();
            //
        }

        private void btn_music5_Click(object sender, EventArgs e)
        {
            //Stop les musiques
            music1.Stop();
            music2.Stop();
            music3.Stop();
            music4.Stop();
            music6.Stop();
            //
            //Démarre la musique et se joue en boucle
            music5.PlayLooping();
            //
        }

        private void btn_music6_Click(object sender, EventArgs e)
        {
            //Stop les musiques
            music1.Stop();
            music2.Stop();
            music3.Stop();
            music4.Stop();
            music5.Stop();
            //
            //Démarre la musique et se joue en boucle
            music6.PlayLooping();
            //
        }

        private void Chrono_Tick(object sender, EventArgs e)
        {
            TempsActuel = DateTime.Now;//Récupère l'heure actuelle
            TempsPasse = TempsActuel - TempsDepart;//-tempsPause
            lbl_min.Text = (TempsPasse.Minutes).ToString("0#");//Permet le démarrage du chrono
            lbl_sec.Text = (TempsPasse.Seconds).ToString("0#");//Permet le démarrage du chrono
            lbl_msec.Text = (TempsPasse.Milliseconds / 10).ToString("0#");//Permet le démarrage du chrono et divise les milliseconde par 10

            if (nbs_PO < LameInfini1PO && switchInfini == 0)//Si le nombre de Po est inférieur à la variable et que la variable = 0...
            {
                btn_dmgAC.Enabled = false;//...Je grise le bouton Infini
            }
            else if (nbs_PO >= LameInfini1PO && switchInfini == 0)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 0...
            {
                btn_dmgAC.Enabled = true;//...Je dégrise le bouton Infini
            }

            if (nbs_PO < LameInfini2PO && switchInfini == 1)//Si le nombre de Po est inférieur à la variable et que la variable = 1...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini2PO && switchInfini == 1)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 1...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfini3PO && switchInfini == 2)//Si le nombre de Po est inférieur à la variable et que la variable = 2...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini3PO && switchInfini == 2)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 2...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfini4PO && switchInfini == 3)//Si le nombre de Po est inférieur à la variable et que la variable = 3...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini4PO && switchInfini == 3)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 3...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfini5PO && switchInfini == 4)//Si le nombre de Po est inférieur à la variable et que la variable = 4...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini5PO && switchInfini == 4)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 4...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfini6PO && switchInfini == 5)//Si le nombre de Po est inférieur à la variable et que la variable = 5...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini6PO && switchInfini == 5)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 5...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfini7PO && switchInfini == 6)//Si le nombre de Po est inférieur à la variable et que la variable = 6...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini7PO && switchInfini == 6)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 6...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfini8PO && switchInfini == 7)//Si le nombre de Po est inférieur à la variable et que la variable = 7...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfini8PO && switchInfini == 7)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 7...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < LameInfiniPO && switchInfini == 8)//Si le nombre de Po est inférieur à la variable et que la variable = 8...
            {
                btn_dmgAC.Enabled = false;
            }
            else if (nbs_PO >= LameInfiniPO && switchInfini == 8)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 8...
            {
                btn_dmgAC.Enabled = true;
            }

            if (nbs_PO < Luden1PO && switchLuden == 0)//Si le nombre de Po est inférieur à la variable et que la variable = 0...
            {
                btn_luden.Enabled = false;//...Je grise le bouton Luden
            }
            else if (nbs_PO >= Luden1PO && switchLuden == 0)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 0...
            {
                btn_luden.Enabled = true;//...Je dégrise le bouton Luden
            }

            if (nbs_PO < Luden2PO && switchLuden == 1)//Si le nombre de Po est inférieur à la variable et que la variable = 1...
            {
                btn_luden.Enabled = false;

            }
            else if (nbs_PO >= Luden2PO && switchLuden == 1)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 1...
            {
                btn_luden.Enabled = true;
            }

            if (nbs_PO < Luden3PO && switchLuden == 2)//Si le nombre de Po est inférieur à la variable et que la variable = 2...
            {
                btn_luden.Enabled = false;
            }
            else if (nbs_PO >= Luden3PO && switchLuden == 2)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 2...
            {
                btn_luden.Enabled = true;
            }

            if (nbs_PO < LudenPO && switchLuden == 3)//Si le nombre de Po est inférieur à la variable et que la variable = 3...
            {
                btn_luden.Enabled = false;
            }
            else if (nbs_PO >= LudenPO && switchLuden == 3)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 3...
            {
                btn_luden.Enabled = true;
            }

            if (nbs_PO < Morello1PO && switchMorello == 0)//Si le nombre de Po est inférieur à la variable et que la variable = 0...
            {
                btn_morello.Enabled = false;//...Je grise le bouton Morello
            }
            else if (nbs_PO >= Morello1PO && switchMorello == 0)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 0...
            {
                btn_morello.Enabled = true;//...Je dégrise le bouton Morello
            }

            if (nbs_PO < Morello2PO && switchMorello == 1)//Si le nombre de Po est inférieur à la variable et que la variable = 1...
            {
                btn_morello.Enabled = false;
            }
            else if (nbs_PO >= Morello2PO && switchMorello == 1)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 1...
            {
                btn_morello.Enabled = true;
            }

            if (nbs_PO < Morello3PO && switchMorello == 2)//Si le nombre de Po est inférieur à la variable et que la variable = 2...
            {
                btn_morello.Enabled = false;
            }
            else if (nbs_PO >= Morello3PO && switchMorello == 2)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 2...
            {
                btn_morello.Enabled = true;
            }

            if (nbs_PO < MorelloPO && switchMorello == 3)//Si le nombre de Po est inférieur à la variable et que la variable = 3...
            {
                btn_morello.Enabled = false;
            }
            else if (nbs_PO >= MorelloPO && switchMorello == 3)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 3...
            {
                btn_morello.Enabled = true;
            }

            if (nbs_PO < Rabadon1PO && switchRabadon == 0)//Si le nombre de Po est inférieur à la variable et que la variable = 0...
            {
                btn_rabadon.Enabled = false;//...Je grise le bouton Rabadon
            }
            else if (nbs_PO >= Rabadon1PO && switchRabadon == 0)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 0...
            {
                btn_rabadon.Enabled = true;//...Je dégrise le bouton Rabadon
            }

            if (nbs_PO < Rabadon2PO && switchRabadon == 1)//Si le nombre de Po est inférieur à la variable et que la variable = 1...
            {
                btn_rabadon.Enabled = false;

            }
            else if (nbs_PO >= Rabadon2PO && switchRabadon == 1)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 1...
            {
                btn_rabadon.Enabled = true;
            }

            if (nbs_PO < Rabadon3PO && switchRabadon == 2)//Si le nombre de Po est inférieur à la variable et que la variable = 2...
            {
                btn_rabadon.Enabled = false;
            }
            else if (nbs_PO >= Rabadon3PO && switchRabadon == 2)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 2...
            {
                btn_rabadon.Enabled = true;
            }

            if (nbs_PO < RabadonPO && switchRabadon == 3)//Si le nombre de Po est inférieur à la variable et que la variable = 3...
            {
                btn_rabadon.Enabled = false;
            }
            else if (nbs_PO >= RabadonPO && switchRabadon == 3)//Sinon si le nombre de Po est inférieur ou égal à la variable et que la variable = 3...
            {
                btn_rabadon.Enabled = true;
            }
            //
        }

        private void TimerPb_Tick(object sender, EventArgs e)
        {
            valeur_dmg = dmgA * prct / pts_vie;//Calcul les dégâts actif

            valeur_dmgP = dmgP * prct / pts_vie;//Calcul les dégâts passif
            pb_life.Increment(valeur_dmgP);//Inflige des dégâts tous les 50 millisecondes à la progressbar

            if (saison == 1)
            {
                BackgroundImage = Teemo;
                //
                //Change la couleur de texte des labels
                //
                lbl_PO.ForeColor = Color.Yellow;
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Blue;
                lbl_lvl.ForeColor = Color.Black;
                lbl_min.ForeColor = Color.Blue;
                lbl_2pts_min.ForeColor = Color.Blue;
                lbl_sec.ForeColor = Color.Blue;
                lbl_2pts_sec.ForeColor = Color.Blue;
                lbl_msec.ForeColor = Color.Blue;
                //
                //1er niveau
                if (pb_life.Value == 100)//Si la progressbar est arrivée à son maximum de 10...
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)//Si lvl est en dessous de 10...
                    {
                        pts_vie = niv1;//Change les points de vie du champion
                        pb_life.Value = 0;//Valeur Progressbar = 0
                        pb_life.Minimum = 0;//Valeur minimum de base Progressbar = 0
                        pb_life.Maximum = 100;//Valeur maximum de la progressbar que le joueur peut atteindre de 100

                        nbs_PO = nbs_PO + 2;//Ajoute 2 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";//Affiche le nombre de PO que le joueurs a et affiche le texte PO
                    }

                    //Début niveau 2
                    else if (lvl == 10)
                    {
                        pts_vie = niv2;//Change les points de vie du champion
                        saison = saison + 1;//Incémente la variable saison
                        lbl_saison.Text = "Saison " + saison;//Change le texte du label saison
                        lvl = 0;//Réinitialise la valeur à 0
                        pb_life.Value = 0;//Valeur Progressbar = 0
                        pb_life.Minimum = 0;//Valeur minimum de base Progressbar = 0
                        pb_life.Maximum = 100;//Valeur maximum de la progressbar que le joueur peut atteindre de 100

                        nbs_PO = nbs_PO + 2;//Ajoute 2 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";//Affiche le nombre de PO que le joueurs a et affiche le texte PO
                    }
                }
            }

            if (saison == 2)
            {
                BackgroundImage = Jax;//Change l'image de fond
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Red;
                lbl_lvl.ForeColor = Color.Red;
                lbl_min.ForeColor = Color.Red;
                lbl_2pts_min.ForeColor = Color.Red;
                lbl_sec.ForeColor = Color.Red;
                lbl_2pts_sec.ForeColor = Color.Red;
                lbl_msec.ForeColor = Color.Red;
                //
                //2eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv2;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 50;//Ajoute 50 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 3
                    else if (lvl == 10)
                    {
                        pts_vie = niv3;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 50;//Ajoute 50 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }
                }
            }

            if (saison == 3)
            {
                BackgroundImage = Nami;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Red;
                lbl_lvl.ForeColor = Color.Red;
                lbl_min.ForeColor = Color.Red;
                lbl_2pts_min.ForeColor = Color.Red;
                lbl_sec.ForeColor = Color.Red;
                lbl_2pts_sec.ForeColor = Color.Red;
                lbl_msec.ForeColor = Color.Red;
                //
                //3eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv3;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 250;//Ajoute 250 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 4
                    else if (lvl == 10)
                    {
                        pts_vie = niv4;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 250;//Ajoute 250 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }
                }
            }

            if (saison == 4)
            {
                BackgroundImage = Zed;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Red;
                lbl_lvl.ForeColor = Color.Red;
                lbl_min.ForeColor = Color.Red;
                lbl_2pts_min.ForeColor = Color.Red;
                lbl_sec.ForeColor = Color.Red;
                lbl_2pts_sec.ForeColor = Color.Red;
                lbl_msec.ForeColor = Color.Red;
                //
                //4eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv4;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 1000;//Ajoute 1000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 5
                    else if (lvl == 10)
                    {
                        pts_vie = niv5;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 1000;//Ajoute 1000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }
                }
            }

            if (saison == 5)
            {
                BackgroundImage = Riven;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Yellow;
                lbl_lvl.ForeColor = Color.Yellow;
                lbl_min.ForeColor = Color.Lime;
                lbl_2pts_min.ForeColor = Color.Lime;
                lbl_sec.ForeColor = Color.Lime;
                lbl_2pts_sec.ForeColor = Color.Lime;
                lbl_msec.ForeColor = Color.Lime;
                //
                //5eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv5;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 25000;//Ajoute 25000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 6
                    else if (lvl == 10)
                    {
                        pts_vie = niv6;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;//Valeur Progressbar = 0
                        pb_life.Minimum = 0;//Valeur minimum de base Progressbar = 0
                        pb_life.Maximum = 100;//Valeur maximum de la progressbar que le joueur peut atteindre de 100

                        nbs_PO = nbs_PO + 25000;//Ajoute 25000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";//Affiche le nombre de PO que le joueurs a et affiche le texte PO
                    }
                }
            }

            if (saison == 6)
            {
                BackgroundImage = Rek;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Yellow;
                lbl_lvl.ForeColor = Color.Yellow;
                lbl_min.ForeColor = Color.Lime;
                lbl_2pts_min.ForeColor = Color.Lime;
                lbl_sec.ForeColor = Color.Lime;
                lbl_2pts_sec.ForeColor = Color.Lime;
                lbl_msec.ForeColor = Color.Lime;
                //
                //6eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv6;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 250000;//Ajoute 250000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 7
                    else if (lvl == 10)
                    {
                        pts_vie = niv7;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 250000;//Ajoute 250000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }
                }
            }

            if (saison == 7)
            {
                BackgroundImage = Fizz;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Yellow;
                lbl_lvl.ForeColor = Color.Lime;
                lbl_min.ForeColor = Color.Yellow;
                lbl_2pts_min.ForeColor = Color.Yellow;
                lbl_sec.ForeColor = Color.Yellow;
                lbl_2pts_sec.ForeColor = Color.Yellow;
                lbl_msec.ForeColor = Color.Yellow;
                //
                //7eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv7;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 1000000;//Ajoute 1000000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 8
                    else if (lvl == 10)
                    {
                        pts_vie = niv8;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 1000000;//Ajoute 1000000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }
                }
            }

            if (saison == 8)
            {
                BackgroundImage = Kalista;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Yellow;
                lbl_lvl.ForeColor = Color.Yellow;
                lbl_min.ForeColor = Color.Yellow;
                lbl_2pts_min.ForeColor = Color.Yellow;
                lbl_sec.ForeColor = Color.Yellow;
                lbl_2pts_sec.ForeColor = Color.Yellow;
                lbl_msec.ForeColor = Color.Yellow;
                //
                //8eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv8;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 5000000;//Ajoute 5000000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //Début niveau 9
                    else if (lvl == 10)
                    {
                        pts_vie = niv9;//Change les points de vie du champion
                        saison = saison + 1;
                        lbl_saison.Text = "Saison " + saison;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 5000000;//Ajoute 5000000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }
                }
            }

            if (saison == 9)
            {
                BackgroundImage = Renekton;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Lime;
                lbl_saison.ForeColor = Color.Yellow;
                lbl_lvl.ForeColor = Color.Yellow;
                lbl_min.ForeColor = Color.Yellow;
                lbl_2pts_min.ForeColor = Color.Yellow;
                lbl_sec.ForeColor = Color.Yellow;
                lbl_2pts_sec.ForeColor = Color.Yellow;
                lbl_msec.ForeColor = Color.Yellow;
                //
                //9eme niveau
                if (pb_life.Value == 100)
                {
                    lvl++;//Incrémente la viriable lvl par 1

                    if (lvl < 10)
                    {
                        pts_vie = niv9;//Change les points de vie du champion
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;

                        nbs_PO = nbs_PO + 50000000;//Ajoute 50000000 PO à la variable des PO
                        lbl_PO.Text = nbs_PO + " PO";
                    }

                    //niveau du Boss
                    else if (lvl == 10)
                    {
                        pts_vie = Boss;//Change les points de vie du Boss
                        saison = saison + 1;
                        lvl = 0;
                        pb_life.Value = 0;
                        pb_life.Minimum = 0;
                        pb_life.Maximum = 100;
                    }
                }
            }

            if (saison == 10)
            {
                BackgroundImage = Veigar;
                //
                //Change la couleur de texte des labels
                //
                lbl_dmgS.ForeColor = Color.Red;
                lbl_saison.ForeColor = Color.Red;
                lbl_lvl.ForeColor = Color.Red;
                lbl_min.ForeColor = Color.Yellow;
                lbl_2pts_min.ForeColor = Color.Yellow;
                lbl_sec.ForeColor = Color.Yellow;
                lbl_2pts_sec.ForeColor = Color.Yellow;
                lbl_msec.ForeColor = Color.Yellow;
                //
                if (pb_life.Value == 100)
                {
                    Chrono.Stop();//Stop le chrono
                    TimerPb.Stop();//Stop le second chrono
                    saison = saison + 1;

                    if (MessageBox.Show("FIN!!! Bravo Invocateur, tu as vaincu Veigar Boss de fin!", "FIN") == DialogResult.OK)
                    {
                        Dispose();//Arrêt du programme
                    }
                }
            }

            lbl_PO.Text = nbs_PO + " PO";//Affiche combien de PO le joueur a
            lbl_dmgS.Text = dmgP + " dégâts/sec.";//Affiche combien de dégâts par seconde le joueur inflige
            lbl_saison.Text = "Saison " + saison;//Affiche à quel niveau se trouve le joueur
            lbl_lvl.Text = lvl + 1 + " / 10";//Affiche à quel champions le joueur se trouve
            //
            //
            if (saison == 10)
            {
                lbl_saison.Text = "BOSS!";//Change le texte du label lvl
                lbl_lvl.Text = lvl + 1 + " / 1";//Change le texte du label lvl
            }
            //
        }

        private void tuerUnChampionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pb_life.Increment(pb_life.Maximum);//Permet de tuer instantanément un champion
        }

        private void gagner10KToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nbs_PO = nbs_PO + PoCheat1;//Ajoute tant de PO à la variable de PO
        }

        private void gagner10MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nbs_PO = nbs_PO + PoCheat2;//Ajoute tant de PO à la variable de PO
        }

        private void niv1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 1;//Saison devient 1 (Niveau 1)
            lvl = 0;//Réinitialise la variable à 0
            pts_vie = niv1;//Change les points de vie du champions
            pb_life.Value = 0;//Valeur Progressbar = 0
            pb_life.Minimum = 0;//Valeur minimum de base Progressbar = 0
            pb_life.Maximum = 100;//Valeur maximum de la progressbar que le joueur peut atteindre de 100
        }

        private void niv2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 2;
            lvl = 0;
            pts_vie = niv2;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 3;
            lvl = 0;
            pts_vie = niv3;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 4;
            lvl = 0;
            pts_vie = niv4;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 5;
            lvl = 0;
            pts_vie = niv5;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 6;
            lvl = 0;
            pts_vie = niv6;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 7;
            lvl = 0;
            pts_vie = niv7;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 8;
            lvl = 0;
            pts_vie = niv8;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void niv9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 9;
            lvl = 0;
            pts_vie = niv9;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void nivBossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saison = 10;
            lvl = 0;
            pts_vie = Boss;
            pb_life.Value = 0;
            pb_life.Minimum = 0;
            pb_life.Maximum = 100;
        }

        private void MenuQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter la partie en cours?", "Quitter", MessageBoxButtons.YesNo) == DialogResult.Yes)//Si l'un des joueurs clic sur oui dans la messagebox...
            {
                Dispose();//Ferme le programme (STOP)
            }//Fin if
        }

        private void frm_Clicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter la partie en cours?", "Quitter", MessageBoxButtons.OKCancel) == DialogResult.OK)//Si l'un des joueurs clic sur OK dans la messagebox...
            {
                Dispose();//Ferme le programme (STOP)
            }//Fin if
            else
            {
                e.Cancel = true;//Arrête l'action qui vient d'être demander au programme
            }//Fin else
        }
    }
}
