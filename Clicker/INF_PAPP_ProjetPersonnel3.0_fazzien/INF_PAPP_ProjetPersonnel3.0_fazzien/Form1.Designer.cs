namespace INF_PAPP_ProjetPersonnel3._0_fazzien
{
    partial class frm_Clicker
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Clicker));
            this.Chrono = new System.Windows.Forms.Timer(this.components);
            this.TimerPb = new System.Windows.Forms.Timer(this.components);
            this.pb_life = new System.Windows.Forms.ProgressBar();
            this.btn_dmgA = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAide = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMusique = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCode = new System.Windows.Forms.ToolStripMenuItem();
            this.tuerUnChampionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gagner10KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gagner10MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allerNivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.niv9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivBossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRéinitialiser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rabadon = new System.Windows.Forms.Button();
            this.btn_morello = new System.Windows.Forms.Button();
            this.btn_luden = new System.Windows.Forms.Button();
            this.btn_dmgAC = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_music1 = new System.Windows.Forms.Button();
            this.btn_music2 = new System.Windows.Forms.Button();
            this.btn_music3 = new System.Windows.Forms.Button();
            this.btn_music4 = new System.Windows.Forms.Button();
            this.btn_music5 = new System.Windows.Forms.Button();
            this.btn_music6 = new System.Windows.Forms.Button();
            this.lbl_PO = new System.Windows.Forms.Label();
            this.lbl_dmgS = new System.Windows.Forms.Label();
            this.lbl_saison = new System.Windows.Forms.Label();
            this.lbl_lvl = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_2pts_min = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.lbl_2pts_sec = new System.Windows.Forms.Label();
            this.lbl_msec = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chrono
            // 
            this.Chrono.Interval = 1;
            this.Chrono.Tick += new System.EventHandler(this.Chrono_Tick);
            // 
            // TimerPb
            // 
            this.TimerPb.Interval = 50;
            this.TimerPb.Tick += new System.EventHandler(this.TimerPb_Tick);
            // 
            // pb_life
            // 
            this.pb_life.Location = new System.Drawing.Point(215, 40);
            this.pb_life.Name = "pb_life";
            this.pb_life.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pb_life.RightToLeftLayout = true;
            this.pb_life.Size = new System.Drawing.Size(270, 37);
            this.pb_life.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_life.TabIndex = 0;
            this.pb_life.UseWaitCursor = true;
            // 
            // btn_dmgA
            // 
            this.btn_dmgA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dmgA.Location = new System.Drawing.Point(275, 206);
            this.btn_dmgA.Name = "btn_dmgA";
            this.btn_dmgA.Size = new System.Drawing.Size(150, 136);
            this.btn_dmgA.TabIndex = 1;
            this.btn_dmgA.UseVisualStyleBackColor = true;
            this.btn_dmgA.Click += new System.EventHandler(this.btn_dmgA_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAide,
            this.MenuMusique,
            this.MenuCode,
            this.MenuRéinitialiser,
            this.MenuQuitter});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // MenuAide
            // 
            this.MenuAide.Name = "MenuAide";
            this.MenuAide.Size = new System.Drawing.Size(154, 22);
            this.MenuAide.Text = "Aide";
            this.MenuAide.Click += new System.EventHandler(this.MenuAide_Click);
            // 
            // MenuMusique
            // 
            this.MenuMusique.Name = "MenuMusique";
            this.MenuMusique.Size = new System.Drawing.Size(154, 22);
            this.MenuMusique.Text = "Musique";
            this.MenuMusique.Click += new System.EventHandler(this.MenuMusique_Click);
            // 
            // MenuCode
            // 
            this.MenuCode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tuerUnChampionToolStripMenuItem,
            this.gagner10KToolStripMenuItem,
            this.gagner10MToolStripMenuItem,
            this.allerNivToolStripMenuItem});
            this.MenuCode.Name = "MenuCode";
            this.MenuCode.Size = new System.Drawing.Size(154, 22);
            this.MenuCode.Text = "Code de Triche";
            // 
            // tuerUnChampionToolStripMenuItem
            // 
            this.tuerUnChampionToolStripMenuItem.Name = "tuerUnChampionToolStripMenuItem";
            this.tuerUnChampionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tuerUnChampionToolStripMenuItem.Text = "Tuer un Champion";
            this.tuerUnChampionToolStripMenuItem.Click += new System.EventHandler(this.tuerUnChampionToolStripMenuItem_Click);
            // 
            // gagner10KToolStripMenuItem
            // 
            this.gagner10KToolStripMenuItem.Name = "gagner10KToolStripMenuItem";
            this.gagner10KToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gagner10KToolStripMenuItem.Text = "Gagner 10K";
            this.gagner10KToolStripMenuItem.Click += new System.EventHandler(this.gagner10KToolStripMenuItem_Click);
            // 
            // gagner10MToolStripMenuItem
            // 
            this.gagner10MToolStripMenuItem.Name = "gagner10MToolStripMenuItem";
            this.gagner10MToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gagner10MToolStripMenuItem.Text = "Gagner 10M";
            this.gagner10MToolStripMenuItem.Click += new System.EventHandler(this.gagner10MToolStripMenuItem_Click);
            // 
            // allerNivToolStripMenuItem
            // 
            this.allerNivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.niv1ToolStripMenuItem,
            this.niv2ToolStripMenuItem,
            this.niv3ToolStripMenuItem,
            this.niv4ToolStripMenuItem,
            this.niv5ToolStripMenuItem,
            this.niv6ToolStripMenuItem,
            this.niv7ToolStripMenuItem,
            this.niv8ToolStripMenuItem,
            this.niv9ToolStripMenuItem,
            this.nivBossToolStripMenuItem});
            this.allerNivToolStripMenuItem.Name = "allerNivToolStripMenuItem";
            this.allerNivToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.allerNivToolStripMenuItem.Text = "Aller Niv.";
            // 
            // niv1ToolStripMenuItem
            // 
            this.niv1ToolStripMenuItem.Name = "niv1ToolStripMenuItem";
            this.niv1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv1ToolStripMenuItem.Text = "Niv.1";
            this.niv1ToolStripMenuItem.Click += new System.EventHandler(this.niv1ToolStripMenuItem_Click);
            // 
            // niv2ToolStripMenuItem
            // 
            this.niv2ToolStripMenuItem.Name = "niv2ToolStripMenuItem";
            this.niv2ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv2ToolStripMenuItem.Text = "Niv.2";
            this.niv2ToolStripMenuItem.Click += new System.EventHandler(this.niv2ToolStripMenuItem_Click);
            // 
            // niv3ToolStripMenuItem
            // 
            this.niv3ToolStripMenuItem.Name = "niv3ToolStripMenuItem";
            this.niv3ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv3ToolStripMenuItem.Text = "Niv.3";
            this.niv3ToolStripMenuItem.Click += new System.EventHandler(this.niv3ToolStripMenuItem_Click);
            // 
            // niv4ToolStripMenuItem
            // 
            this.niv4ToolStripMenuItem.Name = "niv4ToolStripMenuItem";
            this.niv4ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv4ToolStripMenuItem.Text = "Niv.4";
            this.niv4ToolStripMenuItem.Click += new System.EventHandler(this.niv4ToolStripMenuItem_Click);
            // 
            // niv5ToolStripMenuItem
            // 
            this.niv5ToolStripMenuItem.Name = "niv5ToolStripMenuItem";
            this.niv5ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv5ToolStripMenuItem.Text = "Niv.5";
            this.niv5ToolStripMenuItem.Click += new System.EventHandler(this.niv5ToolStripMenuItem_Click);
            // 
            // niv6ToolStripMenuItem
            // 
            this.niv6ToolStripMenuItem.Name = "niv6ToolStripMenuItem";
            this.niv6ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv6ToolStripMenuItem.Text = "Niv.6";
            this.niv6ToolStripMenuItem.Click += new System.EventHandler(this.niv6ToolStripMenuItem_Click);
            // 
            // niv7ToolStripMenuItem
            // 
            this.niv7ToolStripMenuItem.Name = "niv7ToolStripMenuItem";
            this.niv7ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv7ToolStripMenuItem.Text = "Niv.7";
            this.niv7ToolStripMenuItem.Click += new System.EventHandler(this.niv7ToolStripMenuItem_Click);
            // 
            // niv8ToolStripMenuItem
            // 
            this.niv8ToolStripMenuItem.Name = "niv8ToolStripMenuItem";
            this.niv8ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv8ToolStripMenuItem.Text = "Niv.8";
            this.niv8ToolStripMenuItem.Click += new System.EventHandler(this.niv8ToolStripMenuItem_Click);
            // 
            // niv9ToolStripMenuItem
            // 
            this.niv9ToolStripMenuItem.Name = "niv9ToolStripMenuItem";
            this.niv9ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.niv9ToolStripMenuItem.Text = "Niv.9";
            this.niv9ToolStripMenuItem.Click += new System.EventHandler(this.niv9ToolStripMenuItem_Click);
            // 
            // nivBossToolStripMenuItem
            // 
            this.nivBossToolStripMenuItem.Name = "nivBossToolStripMenuItem";
            this.nivBossToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.nivBossToolStripMenuItem.Text = "Niv. Boss";
            this.nivBossToolStripMenuItem.Click += new System.EventHandler(this.nivBossToolStripMenuItem_Click);
            // 
            // MenuRéinitialiser
            // 
            this.MenuRéinitialiser.Name = "MenuRéinitialiser";
            this.MenuRéinitialiser.Size = new System.Drawing.Size(154, 22);
            this.MenuRéinitialiser.Text = "Réinitialiser";
            this.MenuRéinitialiser.Click += new System.EventHandler(this.MenuRéinitialiser_Click);
            // 
            // MenuQuitter
            // 
            this.MenuQuitter.Name = "MenuQuitter";
            this.MenuQuitter.Size = new System.Drawing.Size(154, 22);
            this.MenuQuitter.Text = "Quitter";
            this.MenuQuitter.Click += new System.EventHandler(this.MenuQuitter_Click);
            // 
            // btn_rabadon
            // 
            this.btn_rabadon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rabadon.Location = new System.Drawing.Point(12, 478);
            this.btn_rabadon.Name = "btn_rabadon";
            this.btn_rabadon.Size = new System.Drawing.Size(132, 72);
            this.btn_rabadon.TabIndex = 3;
            this.btn_rabadon.Text = "Tome d\'amplification/Rabadon";
            this.btn_rabadon.UseVisualStyleBackColor = true;
            this.btn_rabadon.Click += new System.EventHandler(this.btn_rabadon_Click);
            // 
            // btn_morello
            // 
            this.btn_morello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_morello.Location = new System.Drawing.Point(12, 400);
            this.btn_morello.Name = "btn_morello";
            this.btn_morello.Size = new System.Drawing.Size(132, 72);
            this.btn_morello.TabIndex = 4;
            this.btn_morello.Text = "Codex Méphitique/Morello";
            this.btn_morello.UseVisualStyleBackColor = true;
            this.btn_morello.Click += new System.EventHandler(this.btn_morello_Click);
            // 
            // btn_luden
            // 
            this.btn_luden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_luden.Location = new System.Drawing.Point(12, 322);
            this.btn_luden.Name = "btn_luden";
            this.btn_luden.Size = new System.Drawing.Size(132, 72);
            this.btn_luden.TabIndex = 5;
            this.btn_luden.Text = "Tome d\'amplification/Luden";
            this.btn_luden.UseVisualStyleBackColor = true;
            this.btn_luden.Click += new System.EventHandler(this.btn_luden_Click);
            // 
            // btn_dmgAC
            // 
            this.btn_dmgAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dmgAC.Location = new System.Drawing.Point(540, 478);
            this.btn_dmgAC.Name = "btn_dmgAC";
            this.btn_dmgAC.Size = new System.Drawing.Size(132, 72);
            this.btn_dmgAC.TabIndex = 6;
            this.btn_dmgAC.Text = "Lame de Doran/Lame d\'infini";
            this.btn_dmgAC.UseVisualStyleBackColor = true;
            this.btn_dmgAC.Click += new System.EventHandler(this.btn_dmgAC_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Location = new System.Drawing.Point(317, 255);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(68, 37);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_music1
            // 
            this.btn_music1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music1.Location = new System.Drawing.Point(581, 147);
            this.btn_music1.Name = "btn_music1";
            this.btn_music1.Size = new System.Drawing.Size(85, 36);
            this.btn_music1.TabIndex = 8;
            this.btn_music1.Text = "Braum";
            this.btn_music1.UseVisualStyleBackColor = true;
            this.btn_music1.Click += new System.EventHandler(this.btn_music1_Click);
            // 
            // btn_music2
            // 
            this.btn_music2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music2.Location = new System.Drawing.Point(581, 189);
            this.btn_music2.Name = "btn_music2";
            this.btn_music2.Size = new System.Drawing.Size(85, 36);
            this.btn_music2.TabIndex = 9;
            this.btn_music2.Text = "Demacia";
            this.btn_music2.UseVisualStyleBackColor = true;
            this.btn_music2.Click += new System.EventHandler(this.btn_music2_Click);
            // 
            // btn_music3
            // 
            this.btn_music3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music3.Location = new System.Drawing.Point(581, 231);
            this.btn_music3.Name = "btn_music3";
            this.btn_music3.Size = new System.Drawing.Size(85, 36);
            this.btn_music3.TabIndex = 10;
            this.btn_music3.Text = "Masterpiece";
            this.btn_music3.UseVisualStyleBackColor = true;
            this.btn_music3.Click += new System.EventHandler(this.btn_music3_Click);
            // 
            // btn_music4
            // 
            this.btn_music4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music4.Location = new System.Drawing.Point(581, 273);
            this.btn_music4.Name = "btn_music4";
            this.btn_music4.Size = new System.Drawing.Size(85, 36);
            this.btn_music4.TabIndex = 11;
            this.btn_music4.Text = "Flash Funk";
            this.btn_music4.UseVisualStyleBackColor = true;
            this.btn_music4.Click += new System.EventHandler(this.btn_music4_Click);
            // 
            // btn_music5
            // 
            this.btn_music5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music5.Location = new System.Drawing.Point(581, 314);
            this.btn_music5.Name = "btn_music5";
            this.btn_music5.Size = new System.Drawing.Size(85, 36);
            this.btn_music5.TabIndex = 12;
            this.btn_music5.Text = "Piercing Light";
            this.btn_music5.UseVisualStyleBackColor = true;
            this.btn_music5.Click += new System.EventHandler(this.btn_music5_Click);
            // 
            // btn_music6
            // 
            this.btn_music6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_music6.Location = new System.Drawing.Point(581, 356);
            this.btn_music6.Name = "btn_music6";
            this.btn_music6.Size = new System.Drawing.Size(85, 36);
            this.btn_music6.TabIndex = 13;
            this.btn_music6.Text = "The Glory";
            this.btn_music6.UseVisualStyleBackColor = true;
            this.btn_music6.Click += new System.EventHandler(this.btn_music6_Click);
            // 
            // lbl_PO
            // 
            this.lbl_PO.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PO.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PO.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_PO.Location = new System.Drawing.Point(12, 46);
            this.lbl_PO.Name = "lbl_PO";
            this.lbl_PO.Size = new System.Drawing.Size(197, 34);
            this.lbl_PO.TabIndex = 14;
            this.lbl_PO.Text = "0 PO";
            // 
            // lbl_dmgS
            // 
            this.lbl_dmgS.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dmgS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dmgS.ForeColor = System.Drawing.Color.Lime;
            this.lbl_dmgS.Location = new System.Drawing.Point(12, 264);
            this.lbl_dmgS.Name = "lbl_dmgS";
            this.lbl_dmgS.Size = new System.Drawing.Size(257, 37);
            this.lbl_dmgS.TabIndex = 15;
            this.lbl_dmgS.Text = "0 dégâts/sec.";
            // 
            // lbl_saison
            // 
            this.lbl_saison.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saison.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saison.ForeColor = System.Drawing.Color.Blue;
            this.lbl_saison.Location = new System.Drawing.Point(580, 40);
            this.lbl_saison.Name = "lbl_saison";
            this.lbl_saison.Size = new System.Drawing.Size(96, 37);
            this.lbl_saison.TabIndex = 16;
            this.lbl_saison.Text = "Saison 1";
            // 
            // lbl_lvl
            // 
            this.lbl_lvl.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lvl.Location = new System.Drawing.Point(584, 84);
            this.lbl_lvl.Name = "lbl_lvl";
            this.lbl_lvl.Size = new System.Drawing.Size(97, 37);
            this.lbl_lvl.TabIndex = 17;
            this.lbl_lvl.Text = "1 / 10";
            // 
            // lbl_min
            // 
            this.lbl_min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.Color.Blue;
            this.lbl_min.Location = new System.Drawing.Point(532, 430);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(30, 25);
            this.lbl_min.TabIndex = 18;
            this.lbl_min.Text = "00";
            // 
            // lbl_2pts_min
            // 
            this.lbl_2pts_min.BackColor = System.Drawing.Color.Transparent;
            this.lbl_2pts_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2pts_min.ForeColor = System.Drawing.Color.Blue;
            this.lbl_2pts_min.Location = new System.Drawing.Point(568, 430);
            this.lbl_2pts_min.Name = "lbl_2pts_min";
            this.lbl_2pts_min.Size = new System.Drawing.Size(10, 25);
            this.lbl_2pts_min.TabIndex = 19;
            this.lbl_2pts_min.Text = ":";
            // 
            // lbl_sec
            // 
            this.lbl_sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_sec.Location = new System.Drawing.Point(584, 430);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(30, 25);
            this.lbl_sec.TabIndex = 20;
            this.lbl_sec.Text = "00";
            // 
            // lbl_2pts_sec
            // 
            this.lbl_2pts_sec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_2pts_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_2pts_sec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_2pts_sec.Location = new System.Drawing.Point(620, 430);
            this.lbl_2pts_sec.Name = "lbl_2pts_sec";
            this.lbl_2pts_sec.Size = new System.Drawing.Size(10, 25);
            this.lbl_2pts_sec.TabIndex = 21;
            this.lbl_2pts_sec.Text = ":";
            // 
            // lbl_msec
            // 
            this.lbl_msec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_msec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msec.ForeColor = System.Drawing.Color.Blue;
            this.lbl_msec.Location = new System.Drawing.Point(636, 430);
            this.lbl_msec.Name = "lbl_msec";
            this.lbl_msec.Size = new System.Drawing.Size(30, 25);
            this.lbl_msec.TabIndex = 22;
            this.lbl_msec.Text = "00";
            // 
            // frm_Clicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 562);
            this.Controls.Add(this.lbl_msec);
            this.Controls.Add(this.lbl_2pts_sec);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.lbl_2pts_min);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_lvl);
            this.Controls.Add(this.lbl_saison);
            this.Controls.Add(this.lbl_dmgS);
            this.Controls.Add(this.lbl_PO);
            this.Controls.Add(this.btn_music6);
            this.Controls.Add(this.btn_music5);
            this.Controls.Add(this.btn_music4);
            this.Controls.Add(this.btn_music3);
            this.Controls.Add(this.btn_music2);
            this.Controls.Add(this.btn_music1);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_dmgAC);
            this.Controls.Add(this.btn_luden);
            this.Controls.Add(this.btn_morello);
            this.Controls.Add(this.btn_rabadon);
            this.Controls.Add(this.btn_dmgA);
            this.Controls.Add(this.pb_life);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Clicker";
            this.Text = "League of Click";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Clicker_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Chrono;
        private System.Windows.Forms.Timer TimerPb;
        private System.Windows.Forms.ProgressBar pb_life;
        private System.Windows.Forms.Button btn_dmgA;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuAide;
        private System.Windows.Forms.ToolStripMenuItem MenuMusique;
        private System.Windows.Forms.ToolStripMenuItem MenuCode;
        private System.Windows.Forms.ToolStripMenuItem MenuRéinitialiser;
        private System.Windows.Forms.ToolStripMenuItem MenuQuitter;
        private System.Windows.Forms.Button btn_rabadon;
        private System.Windows.Forms.Button btn_morello;
        private System.Windows.Forms.Button btn_luden;
        private System.Windows.Forms.Button btn_dmgAC;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_music1;
        private System.Windows.Forms.Button btn_music2;
        private System.Windows.Forms.Button btn_music3;
        private System.Windows.Forms.Button btn_music4;
        private System.Windows.Forms.Button btn_music5;
        private System.Windows.Forms.Button btn_music6;
        private System.Windows.Forms.Label lbl_PO;
        private System.Windows.Forms.Label lbl_dmgS;
        private System.Windows.Forms.Label lbl_saison;
        private System.Windows.Forms.Label lbl_lvl;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_2pts_min;
        private System.Windows.Forms.Label lbl_sec;
        private System.Windows.Forms.Label lbl_2pts_sec;
        private System.Windows.Forms.Label lbl_msec;
        private System.Windows.Forms.ToolStripMenuItem gagner10KToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gagner10MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allerNivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem niv9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivBossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tuerUnChampionToolStripMenuItem;
    }
}

