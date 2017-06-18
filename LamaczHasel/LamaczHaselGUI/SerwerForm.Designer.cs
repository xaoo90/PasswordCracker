namespace LamaczHaselGUI
{
    partial class SerwerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerwerForm));
            this.panelBruteForce = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textPassToCode = new System.Windows.Forms.TextBox();
            this.btOblicz = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textPassFromCode = new System.Windows.Forms.TextBox();
            this.textCodeToPass = new System.Windows.Forms.TextBox();
            this.textCodeFromPass = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelAlfabet = new System.Windows.Forms.Panel();
            this.checkedSpecjalne = new System.Windows.Forms.CheckedListBox();
            this.checkedCyfry = new System.Windows.Forms.CheckedListBox();
            this.checkedWielkie = new System.Windows.Forms.CheckedListBox();
            this.checkedMale = new System.Windows.Forms.CheckedListBox();
            this.btWyczysc = new System.Windows.Forms.Button();
            this.btSpecjalne = new System.Windows.Forms.Button();
            this.btCyfry = new System.Windows.Forms.Button();
            this.btWielkie = new System.Windows.Forms.Button();
            this.btMale = new System.Windows.Forms.Button();
            this.btWszystko = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btAddToList = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textMD5Hash = new System.Windows.Forms.TextBox();
            this.textMD5Pass = new System.Windows.Forms.TextBox();
            this.panelPozostale = new System.Windows.Forms.Panel();
            this.btClearHashList = new System.Windows.Forms.Button();
            this.btHashTXTRead = new System.Windows.Forms.Button();
            this.btDeleteHash = new System.Windows.Forms.Button();
            this.listMD5Hash = new System.Windows.Forms.ListBox();
            this.lbPozostle = new System.Windows.Forms.Label();
            this.textIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textPaczka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSlownik = new System.Windows.Forms.Panel();
            this.checkedTransformation = new System.Windows.Forms.CheckedListBox();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.btPlik = new System.Windows.Forms.Button();
            this.panelSerwer = new System.Windows.Forms.Panel();
            this.lbProces = new System.Windows.Forms.Label();
            this.btTest = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rdSlownik = new System.Windows.Forms.RadioButton();
            this.rdBruteForce = new System.Windows.Forms.RadioButton();
            this.lbStan = new System.Windows.Forms.Label();
            this.btStart = new System.Windows.Forms.Button();
            this.btPolacz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelOdpowiedzi = new System.Windows.Forms.Panel();
            this.btClearOdp = new System.Windows.Forms.Button();
            this.btSavePassToFile = new System.Windows.Forms.Button();
            this.textOdp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btMD5Generate = new System.Windows.Forms.Button();
            this.panelBruteForce.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAlfabet.SuspendLayout();
            this.panelPozostale.SuspendLayout();
            this.panelSlownik.SuspendLayout();
            this.panelSerwer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOdpowiedzi.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBruteForce
            // 
            this.panelBruteForce.Controls.Add(this.panel2);
            this.panelBruteForce.Controls.Add(this.panelAlfabet);
            this.panelBruteForce.Location = new System.Drawing.Point(3, 6);
            this.panelBruteForce.Name = "panelBruteForce";
            this.panelBruteForce.Size = new System.Drawing.Size(314, 538);
            this.panelBruteForce.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textPassToCode);
            this.panel2.Controls.Add(this.btOblicz);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.textPassFromCode);
            this.panel2.Controls.Add(this.textCodeToPass);
            this.panel2.Controls.Add(this.textCodeFromPass);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(3, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 135);
            this.panel2.TabIndex = 2;
            // 
            // textPassToCode
            // 
            this.textPassToCode.Location = new System.Drawing.Point(3, 35);
            this.textPassToCode.Name = "textPassToCode";
            this.textPassToCode.Size = new System.Drawing.Size(140, 20);
            this.textPassToCode.TabIndex = 11;
            // 
            // btOblicz
            // 
            this.btOblicz.Location = new System.Drawing.Point(6, 91);
            this.btOblicz.Name = "btOblicz";
            this.btOblicz.Size = new System.Drawing.Size(290, 34);
            this.btOblicz.TabIndex = 10;
            this.btOblicz.Text = "Oblicz";
            this.btOblicz.UseVisualStyleBackColor = true;
            this.btOblicz.Click += new System.EventHandler(this.btOblicz_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Kombinacja na hasło";
            // 
            // textPassFromCode
            // 
            this.textPassFromCode.Location = new System.Drawing.Point(156, 61);
            this.textPassFromCode.Name = "textPassFromCode";
            this.textPassFromCode.ReadOnly = true;
            this.textPassFromCode.Size = new System.Drawing.Size(140, 20);
            this.textPassFromCode.TabIndex = 8;
            // 
            // textCodeToPass
            // 
            this.textCodeToPass.Location = new System.Drawing.Point(156, 35);
            this.textCodeToPass.Name = "textCodeToPass";
            this.textCodeToPass.ShortcutsEnabled = false;
            this.textCodeToPass.Size = new System.Drawing.Size(140, 20);
            this.textCodeToPass.TabIndex = 7;
            this.textCodeToPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodeToPass_KeyPress);
            // 
            // textCodeFromPass
            // 
            this.textCodeFromPass.Location = new System.Drawing.Point(3, 61);
            this.textCodeFromPass.Name = "textCodeFromPass";
            this.textCodeFromPass.ReadOnly = true;
            this.textCodeFromPass.Size = new System.Drawing.Size(140, 20);
            this.textCodeFromPass.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Hasło na kombinacje";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Kalkulator";
            // 
            // panelAlfabet
            // 
            this.panelAlfabet.Controls.Add(this.checkedSpecjalne);
            this.panelAlfabet.Controls.Add(this.checkedCyfry);
            this.panelAlfabet.Controls.Add(this.checkedWielkie);
            this.panelAlfabet.Controls.Add(this.checkedMale);
            this.panelAlfabet.Controls.Add(this.btWyczysc);
            this.panelAlfabet.Controls.Add(this.btSpecjalne);
            this.panelAlfabet.Controls.Add(this.btCyfry);
            this.panelAlfabet.Controls.Add(this.btWielkie);
            this.panelAlfabet.Controls.Add(this.btMale);
            this.panelAlfabet.Controls.Add(this.btWszystko);
            this.panelAlfabet.Controls.Add(this.label4);
            this.panelAlfabet.Location = new System.Drawing.Point(3, 15);
            this.panelAlfabet.Name = "panelAlfabet";
            this.panelAlfabet.Size = new System.Drawing.Size(308, 338);
            this.panelAlfabet.TabIndex = 1;
            // 
            // checkedSpecjalne
            // 
            this.checkedSpecjalne.CheckOnClick = true;
            this.checkedSpecjalne.ColumnWidth = 35;
            this.checkedSpecjalne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedSpecjalne.FormattingEnabled = true;
            this.checkedSpecjalne.Items.AddRange(new object[] {
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "&",
            "*",
            "(",
            ")",
            "-",
            "=",
            "`",
            "[",
            "]",
            ";",
            "\'",
            "\\",
            ",",
            ".",
            "/",
            "_",
            "+",
            "~",
            "{",
            "}",
            ":",
            "\"",
            "|",
            "<",
            ">",
            "?"});
            this.checkedSpecjalne.Location = new System.Drawing.Point(189, 15);
            this.checkedSpecjalne.MultiColumn = true;
            this.checkedSpecjalne.Name = "checkedSpecjalne";
            this.checkedSpecjalne.Size = new System.Drawing.Size(116, 238);
            this.checkedSpecjalne.TabIndex = 5;
            // 
            // checkedCyfry
            // 
            this.checkedCyfry.CheckOnClick = true;
            this.checkedCyfry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedCyfry.FormattingEnabled = true;
            this.checkedCyfry.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.checkedCyfry.Location = new System.Drawing.Point(153, 15);
            this.checkedCyfry.Name = "checkedCyfry";
            this.checkedCyfry.Size = new System.Drawing.Size(36, 238);
            this.checkedCyfry.TabIndex = 3;
            // 
            // checkedWielkie
            // 
            this.checkedWielkie.CheckOnClick = true;
            this.checkedWielkie.ColumnWidth = 35;
            this.checkedWielkie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedWielkie.FormattingEnabled = true;
            this.checkedWielkie.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.checkedWielkie.Location = new System.Drawing.Point(79, 15);
            this.checkedWielkie.MultiColumn = true;
            this.checkedWielkie.Name = "checkedWielkie";
            this.checkedWielkie.Size = new System.Drawing.Size(74, 238);
            this.checkedWielkie.TabIndex = 2;
            // 
            // checkedMale
            // 
            this.checkedMale.CheckOnClick = true;
            this.checkedMale.ColumnWidth = 35;
            this.checkedMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedMale.FormattingEnabled = true;
            this.checkedMale.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "q",
            "r",
            "s",
            "t",
            "u",
            "v",
            "w",
            "x",
            "y",
            "z"});
            this.checkedMale.Location = new System.Drawing.Point(5, 15);
            this.checkedMale.MultiColumn = true;
            this.checkedMale.Name = "checkedMale";
            this.checkedMale.Size = new System.Drawing.Size(74, 238);
            this.checkedMale.TabIndex = 1;
            // 
            // btWyczysc
            // 
            this.btWyczysc.Location = new System.Drawing.Point(153, 300);
            this.btWyczysc.Name = "btWyczysc";
            this.btWyczysc.Size = new System.Drawing.Size(135, 35);
            this.btWyczysc.TabIndex = 100;
            this.btWyczysc.Text = "Wyczyść";
            this.btWyczysc.UseVisualStyleBackColor = true;
            this.btWyczysc.Click += new System.EventHandler(this.btWyczysc_Click);
            // 
            // btSpecjalne
            // 
            this.btSpecjalne.Location = new System.Drawing.Point(224, 259);
            this.btSpecjalne.Name = "btSpecjalne";
            this.btSpecjalne.Size = new System.Drawing.Size(64, 35);
            this.btSpecjalne.TabIndex = 99;
            this.btSpecjalne.Text = "Znaki Specjalne";
            this.btSpecjalne.UseVisualStyleBackColor = true;
            this.btSpecjalne.Click += new System.EventHandler(this.btSpecjalne_Click);
            // 
            // btCyfry
            // 
            this.btCyfry.Location = new System.Drawing.Point(153, 259);
            this.btCyfry.Name = "btCyfry";
            this.btCyfry.Size = new System.Drawing.Size(64, 35);
            this.btCyfry.TabIndex = 98;
            this.btCyfry.Text = "Cyfry";
            this.btCyfry.UseVisualStyleBackColor = true;
            this.btCyfry.Click += new System.EventHandler(this.btCyfry_Click);
            // 
            // btWielkie
            // 
            this.btWielkie.Location = new System.Drawing.Point(76, 259);
            this.btWielkie.Name = "btWielkie";
            this.btWielkie.Size = new System.Drawing.Size(64, 35);
            this.btWielkie.TabIndex = 97;
            this.btWielkie.Text = "Wielkie Litery";
            this.btWielkie.UseVisualStyleBackColor = true;
            this.btWielkie.Click += new System.EventHandler(this.btWielkie_Click);
            // 
            // btMale
            // 
            this.btMale.Location = new System.Drawing.Point(5, 259);
            this.btMale.Name = "btMale";
            this.btMale.Size = new System.Drawing.Size(64, 35);
            this.btMale.TabIndex = 96;
            this.btMale.Text = "Małe Litery";
            this.btMale.UseVisualStyleBackColor = true;
            this.btMale.Click += new System.EventHandler(this.btMale_Click);
            // 
            // btWszystko
            // 
            this.btWszystko.Location = new System.Drawing.Point(5, 300);
            this.btWszystko.Name = "btWszystko";
            this.btWszystko.Size = new System.Drawing.Size(135, 35);
            this.btWszystko.TabIndex = 95;
            this.btWszystko.Text = "Zaznacz Wszystko";
            this.btWszystko.UseVisualStyleBackColor = true;
            this.btWszystko.Click += new System.EventHandler(this.btWszystko_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Alfabet";
            // 
            // btAddToList
            // 
            this.btAddToList.Location = new System.Drawing.Point(155, 73);
            this.btAddToList.Name = "btAddToList";
            this.btAddToList.Size = new System.Drawing.Size(127, 33);
            this.btAddToList.TabIndex = 11;
            this.btAddToList.Text = "Dodaj na liste";
            this.btAddToList.UseVisualStyleBackColor = true;
            this.btAddToList.Click += new System.EventHandler(this.btMD_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(98, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Hasło na MD5";
            // 
            // textMD5Hash
            // 
            this.textMD5Hash.Location = new System.Drawing.Point(6, 49);
            this.textMD5Hash.Name = "textMD5Hash";
            this.textMD5Hash.ReadOnly = true;
            this.textMD5Hash.Size = new System.Drawing.Size(276, 20);
            this.textMD5Hash.TabIndex = 2;
            // 
            // textMD5Pass
            // 
            this.textMD5Pass.Location = new System.Drawing.Point(6, 23);
            this.textMD5Pass.Name = "textMD5Pass";
            this.textMD5Pass.Size = new System.Drawing.Size(276, 20);
            this.textMD5Pass.TabIndex = 1;
            // 
            // panelPozostale
            // 
            this.panelPozostale.Controls.Add(this.btClearHashList);
            this.panelPozostale.Controls.Add(this.btHashTXTRead);
            this.panelPozostale.Controls.Add(this.btDeleteHash);
            this.panelPozostale.Controls.Add(this.listMD5Hash);
            this.panelPozostale.Controls.Add(this.lbPozostle);
            this.panelPozostale.Controls.Add(this.textIndex);
            this.panelPozostale.Controls.Add(this.label7);
            this.panelPozostale.Controls.Add(this.label6);
            this.panelPozostale.Controls.Add(this.textPaczka);
            this.panelPozostale.Controls.Add(this.label5);
            this.panelPozostale.Location = new System.Drawing.Point(6, 196);
            this.panelPozostale.Name = "panelPozostale";
            this.panelPozostale.Size = new System.Drawing.Size(233, 335);
            this.panelPozostale.TabIndex = 2;
            // 
            // btClearHashList
            // 
            this.btClearHashList.Location = new System.Drawing.Point(95, 292);
            this.btClearHashList.Name = "btClearHashList";
            this.btClearHashList.Size = new System.Drawing.Size(58, 40);
            this.btClearHashList.TabIndex = 12;
            this.btClearHashList.Text = "Wyczyść liste";
            this.btClearHashList.UseVisualStyleBackColor = true;
            this.btClearHashList.Click += new System.EventHandler(this.btClearHashList_Click);
            // 
            // btHashTXTRead
            // 
            this.btHashTXTRead.Location = new System.Drawing.Point(11, 292);
            this.btHashTXTRead.Name = "btHashTXTRead";
            this.btHashTXTRead.Size = new System.Drawing.Size(58, 40);
            this.btHashTXTRead.TabIndex = 11;
            this.btHashTXTRead.Text = "Wczytaj z TXT";
            this.btHashTXTRead.UseVisualStyleBackColor = true;
            this.btHashTXTRead.Click += new System.EventHandler(this.btHashTXTRead_Click);
            // 
            // btDeleteHash
            // 
            this.btDeleteHash.Location = new System.Drawing.Point(172, 292);
            this.btDeleteHash.Name = "btDeleteHash";
            this.btDeleteHash.Size = new System.Drawing.Size(58, 40);
            this.btDeleteHash.TabIndex = 10;
            this.btDeleteHash.Text = "Usuń hash";
            this.btDeleteHash.UseVisualStyleBackColor = true;
            this.btDeleteHash.Click += new System.EventHandler(this.btDeleteHash_Click);
            // 
            // listMD5Hash
            // 
            this.listMD5Hash.FormattingEnabled = true;
            this.listMD5Hash.Items.AddRange(new object[] {
            "4124bc0a9335c27f086f24ba207a4912",
            "47bce5c74f589f4867dbd57e9ca9f808",
            "cb07750cf125dcbc1bf8987ec031c9a3"});
            this.listMD5Hash.Location = new System.Drawing.Point(6, 95);
            this.listMD5Hash.Name = "listMD5Hash";
            this.listMD5Hash.Size = new System.Drawing.Size(224, 186);
            this.listMD5Hash.TabIndex = 9;
            // 
            // lbPozostle
            // 
            this.lbPozostle.AutoSize = true;
            this.lbPozostle.Location = new System.Drawing.Point(3, 0);
            this.lbPozostle.Name = "lbPozostle";
            this.lbPozostle.Size = new System.Drawing.Size(55, 13);
            this.lbPozostle.TabIndex = 8;
            this.lbPozostle.Text = "Pozostałe";
            // 
            // textIndex
            // 
            this.textIndex.Location = new System.Drawing.Point(117, 47);
            this.textIndex.Name = "textIndex";
            this.textIndex.Size = new System.Drawing.Size(100, 20);
            this.textIndex.TabIndex = 7;
            this.textIndex.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Index początkowy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "MD5 Hash:";
            // 
            // textPaczka
            // 
            this.textPaczka.Location = new System.Drawing.Point(117, 21);
            this.textPaczka.Name = "textPaczka";
            this.textPaczka.Size = new System.Drawing.Size(100, 20);
            this.textPaczka.TabIndex = 2;
            this.textPaczka.Text = "1000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Wielkość paczki:";
            // 
            // panelSlownik
            // 
            this.panelSlownik.Controls.Add(this.checkedTransformation);
            this.panelSlownik.Controls.Add(this.textFilePath);
            this.panelSlownik.Controls.Add(this.btPlik);
            this.panelSlownik.Location = new System.Drawing.Point(6, 6);
            this.panelSlownik.Name = "panelSlownik";
            this.panelSlownik.Size = new System.Drawing.Size(290, 310);
            this.panelSlownik.TabIndex = 1;
            // 
            // checkedTransformation
            // 
            this.checkedTransformation.CheckOnClick = true;
            this.checkedTransformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedTransformation.FormattingEnabled = true;
            this.checkedTransformation.Items.AddRange(new object[] {
            "addNumber",
            "addSamePassword",
            "firstUpperCase",
            "makeUpper",
            "replaceLetter",
            "addSome",
            "bracket",
            "addNumberA",
            "addNumberB",
            "addNumberAB",
            "replaceAtIndex",
            "replaceAllTheSameLetter",
            "addSign"});
            this.checkedTransformation.Location = new System.Drawing.Point(7, 45);
            this.checkedTransformation.Name = "checkedTransformation";
            this.checkedTransformation.Size = new System.Drawing.Size(283, 228);
            this.checkedTransformation.TabIndex = 4;
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(88, 19);
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.ReadOnly = true;
            this.textFilePath.Size = new System.Drawing.Size(199, 20);
            this.textFilePath.TabIndex = 3;
            // 
            // btPlik
            // 
            this.btPlik.Location = new System.Drawing.Point(7, 16);
            this.btPlik.Name = "btPlik";
            this.btPlik.Size = new System.Drawing.Size(75, 23);
            this.btPlik.TabIndex = 1;
            this.btPlik.Text = "Wybierz plik";
            this.btPlik.UseVisualStyleBackColor = true;
            this.btPlik.Click += new System.EventHandler(this.btPlik_Click);
            // 
            // panelSerwer
            // 
            this.panelSerwer.Controls.Add(this.lbProces);
            this.panelSerwer.Controls.Add(this.btTest);
            this.panelSerwer.Controls.Add(this.btStop);
            this.panelSerwer.Controls.Add(this.panelPozostale);
            this.panelSerwer.Controls.Add(this.panel1);
            this.panelSerwer.Controls.Add(this.lbStan);
            this.panelSerwer.Controls.Add(this.btStart);
            this.panelSerwer.Controls.Add(this.btPolacz);
            this.panelSerwer.Controls.Add(this.label3);
            this.panelSerwer.Location = new System.Drawing.Point(634, 8);
            this.panelSerwer.Name = "panelSerwer";
            this.panelSerwer.Size = new System.Drawing.Size(241, 534);
            this.panelSerwer.TabIndex = 2;
            // 
            // lbProces
            // 
            this.lbProces.AutoSize = true;
            this.lbProces.Location = new System.Drawing.Point(81, 63);
            this.lbProces.Name = "lbProces";
            this.lbProces.Size = new System.Drawing.Size(0, 13);
            this.lbProces.TabIndex = 8;
            // 
            // btTest
            // 
            this.btTest.BackColor = System.Drawing.Color.Red;
            this.btTest.Enabled = false;
            this.btTest.Location = new System.Drawing.Point(12, 160);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(224, 23);
            this.btTest.TabIndex = 7;
            this.btTest.Text = "TEST";
            this.btTest.UseVisualStyleBackColor = false;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // btStop
            // 
            this.btStop.Enabled = false;
            this.btStop.Location = new System.Drawing.Point(161, 53);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 32);
            this.btStop.TabIndex = 6;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rdSlownik);
            this.panel1.Controls.Add(this.rdBruteForce);
            this.panel1.Location = new System.Drawing.Point(6, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 61);
            this.panel1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Metoda łamania";
            // 
            // rdSlownik
            // 
            this.rdSlownik.AutoSize = true;
            this.rdSlownik.Location = new System.Drawing.Point(11, 39);
            this.rdSlownik.Name = "rdSlownik";
            this.rdSlownik.Size = new System.Drawing.Size(64, 17);
            this.rdSlownik.TabIndex = 1;
            this.rdSlownik.Text = "Słownik";
            this.rdSlownik.UseVisualStyleBackColor = true;
            // 
            // rdBruteForce
            // 
            this.rdBruteForce.AutoSize = true;
            this.rdBruteForce.Checked = true;
            this.rdBruteForce.Location = new System.Drawing.Point(11, 16);
            this.rdBruteForce.Name = "rdBruteForce";
            this.rdBruteForce.Size = new System.Drawing.Size(77, 17);
            this.rdBruteForce.TabIndex = 0;
            this.rdBruteForce.TabStop = true;
            this.rdBruteForce.Text = "BruteForce";
            this.rdBruteForce.UseVisualStyleBackColor = true;
            // 
            // lbStan
            // 
            this.lbStan.AutoSize = true;
            this.lbStan.ForeColor = System.Drawing.Color.Red;
            this.lbStan.Location = new System.Drawing.Point(81, 27);
            this.lbStan.Name = "lbStan";
            this.lbStan.Size = new System.Drawing.Size(64, 13);
            this.lbStan.TabIndex = 3;
            this.lbStan.Text = "Rozłączony";
            // 
            // btStart
            // 
            this.btStart.Enabled = false;
            this.btStart.Location = new System.Drawing.Point(161, 15);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 32);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btPolacz
            // 
            this.btPolacz.Location = new System.Drawing.Point(6, 15);
            this.btPolacz.Name = "btPolacz";
            this.btPolacz.Size = new System.Drawing.Size(75, 32);
            this.btPolacz.TabIndex = 1;
            this.btPolacz.Text = "Połącz";
            this.btPolacz.UseVisualStyleBackColor = true;
            this.btPolacz.Click += new System.EventHandler(this.btPolacz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serwer";
            // 
            // panelOdpowiedzi
            // 
            this.panelOdpowiedzi.Controls.Add(this.btClearOdp);
            this.panelOdpowiedzi.Controls.Add(this.btSavePassToFile);
            this.panelOdpowiedzi.Controls.Add(this.textOdp);
            this.panelOdpowiedzi.Controls.Add(this.label8);
            this.panelOdpowiedzi.Location = new System.Drawing.Point(343, 23);
            this.panelOdpowiedzi.Name = "panelOdpowiedzi";
            this.panelOdpowiedzi.Size = new System.Drawing.Size(285, 394);
            this.panelOdpowiedzi.TabIndex = 3;
            // 
            // btClearOdp
            // 
            this.btClearOdp.Location = new System.Drawing.Point(155, 355);
            this.btClearOdp.Name = "btClearOdp";
            this.btClearOdp.Size = new System.Drawing.Size(127, 34);
            this.btClearOdp.TabIndex = 7;
            this.btClearOdp.Text = "Wyczyść liste";
            this.btClearOdp.UseVisualStyleBackColor = true;
            this.btClearOdp.Click += new System.EventHandler(this.btClearOdp_Click);
            // 
            // btSavePassToFile
            // 
            this.btSavePassToFile.Location = new System.Drawing.Point(6, 355);
            this.btSavePassToFile.Name = "btSavePassToFile";
            this.btSavePassToFile.Size = new System.Drawing.Size(127, 34);
            this.btSavePassToFile.TabIndex = 6;
            this.btSavePassToFile.Text = "Zapisz do pliku";
            this.btSavePassToFile.UseVisualStyleBackColor = true;
            this.btSavePassToFile.Click += new System.EventHandler(this.btSavePassToFile_Click);
            // 
            // textOdp
            // 
            this.textOdp.Location = new System.Drawing.Point(6, 16);
            this.textOdp.Multiline = true;
            this.textOdp.Name = "textOdp";
            this.textOdp.ReadOnly = true;
            this.textOdp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textOdp.Size = new System.Drawing.Size(276, 333);
            this.textOdp.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Odpowiedzi";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Location = new System.Drawing.Point(12, 7);
            this.tab.Multiline = true;
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(325, 539);
            this.tab.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelBruteForce);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 513);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BruteForce";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelSlownik);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 513);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Słownik";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btMD5Generate);
            this.panel3.Controls.Add(this.btAddToList);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textMD5Pass);
            this.panel3.Controls.Add(this.textMD5Hash);
            this.panel3.Location = new System.Drawing.Point(343, 423);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 116);
            this.panel3.TabIndex = 8;
            // 
            // btMD5Generate
            // 
            this.btMD5Generate.Location = new System.Drawing.Point(6, 73);
            this.btMD5Generate.Name = "btMD5Generate";
            this.btMD5Generate.Size = new System.Drawing.Size(127, 33);
            this.btMD5Generate.TabIndex = 12;
            this.btMD5Generate.Text = "MD5 hash";
            this.btMD5Generate.UseVisualStyleBackColor = true;
            this.btMD5Generate.Click += new System.EventHandler(this.btMD5Generate_Click);
            // 
            // SerwerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(885, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panelOdpowiedzi);
            this.Controls.Add(this.panelSerwer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SerwerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LamaczHasel";
            this.panelBruteForce.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAlfabet.ResumeLayout(false);
            this.panelAlfabet.PerformLayout();
            this.panelPozostale.ResumeLayout(false);
            this.panelPozostale.PerformLayout();
            this.panelSlownik.ResumeLayout(false);
            this.panelSlownik.PerformLayout();
            this.panelSerwer.ResumeLayout(false);
            this.panelSerwer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOdpowiedzi.ResumeLayout(false);
            this.panelOdpowiedzi.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBruteForce;
        private System.Windows.Forms.Panel panelSlownik;
        private System.Windows.Forms.Panel panelSerwer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelAlfabet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btWszystko;
        private System.Windows.Forms.Button btMale;
        private System.Windows.Forms.Button btWielkie;
        private System.Windows.Forms.Button btCyfry;
        private System.Windows.Forms.Button btSpecjalne;
        private System.Windows.Forms.Button btWyczysc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPaczka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPozostale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textIndex;
        private System.Windows.Forms.Panel panelOdpowiedzi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btPolacz;
        private System.Windows.Forms.Label lbStan;
        private System.Windows.Forms.CheckedListBox checkedMale;
        private System.Windows.Forms.CheckedListBox checkedWielkie;
        private System.Windows.Forms.CheckedListBox checkedSpecjalne;
        private System.Windows.Forms.CheckedListBox checkedCyfry;
        private System.Windows.Forms.Label lbPozostle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdSlownik;
        private System.Windows.Forms.RadioButton rdBruteForce;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btPlik;
        private System.Windows.Forms.TextBox textFilePath;
        private System.Windows.Forms.CheckedListBox checkedTransformation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textMD5Hash;
        private System.Windows.Forms.TextBox textMD5Pass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPassFromCode;
        private System.Windows.Forms.TextBox textCodeToPass;
        private System.Windows.Forms.TextBox textCodeFromPass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btOblicz;
        private System.Windows.Forms.Button btAddToList;
        public System.Windows.Forms.Button btStart;
        public System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btDeleteHash;
        private System.Windows.Forms.ListBox listMD5Hash;
        public System.Windows.Forms.TextBox textOdp;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textPassToCode;
        private System.Windows.Forms.Button btMD5Generate;
        private System.Windows.Forms.Button btClearOdp;
        private System.Windows.Forms.Button btSavePassToFile;
        private System.Windows.Forms.Button btHashTXTRead;
        private System.Windows.Forms.Button btClearHashList;
        private System.Windows.Forms.Button btTest;
        public System.Windows.Forms.Label lbProces;
    }
}

