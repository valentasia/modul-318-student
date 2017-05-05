namespace Fahrplan2
{
    partial class MainForm
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
            this.Stationtb = new System.Windows.Forms.TextBox();
            this.station = new System.Windows.Forms.Label();
            this.Search2 = new System.Windows.Forms.Button();
            this.Von = new System.Windows.Forms.Label();
            this.Nach = new System.Windows.Forms.Label();
            this.BtSearch = new System.Windows.Forms.Button();
            this.LabelFehler = new System.Windows.Forms.Label();
            this.LVverbindung = new System.Windows.Forms.ListView();
            this.dTPTime = new System.Windows.Forms.DateTimePicker();
            this.Datum = new System.Windows.Forms.Label();
            this.LVtafel = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelFehler3 = new System.Windows.Forms.Label();
            this.lkarte = new System.Windows.Forms.LinkLabel();
            this.lkarte2 = new System.Windows.Forms.LinkLabel();
            this.AutoCom = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Vontb = new System.Windows.Forms.ComboBox();
            this.Nachtb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Stationtb
            // 
            this.Stationtb.Location = new System.Drawing.Point(704, 69);
            this.Stationtb.Name = "Stationtb";
            this.Stationtb.Size = new System.Drawing.Size(200, 20);
            this.Stationtb.TabIndex = 58;
            // 
            // station
            // 
            this.station.AutoSize = true;
            this.station.Location = new System.Drawing.Point(639, 72);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(43, 13);
            this.station.TabIndex = 59;
            this.station.Text = "Station:";
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(704, 98);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 23);
            this.Search2.TabIndex = 60;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Click += new System.EventHandler(this.SearchButton2_Click);
            // 
            // Von
            // 
            this.Von.AutoSize = true;
            this.Von.Location = new System.Drawing.Point(9, 72);
            this.Von.Name = "Von";
            this.Von.Size = new System.Drawing.Size(29, 13);
            this.Von.TabIndex = 48;
            this.Von.Text = "Von:";
            // 
            // Nach
            // 
            this.Nach.AutoSize = true;
            this.Nach.Location = new System.Drawing.Point(9, 127);
            this.Nach.Name = "Nach";
            this.Nach.Size = new System.Drawing.Size(36, 13);
            this.Nach.TabIndex = 49;
            this.Nach.Text = "Nach:";
            // 
            // BtSearch
            // 
            this.BtSearch.Location = new System.Drawing.Point(69, 176);
            this.BtSearch.Name = "BtSearch";
            this.BtSearch.Size = new System.Drawing.Size(75, 23);
            this.BtSearch.TabIndex = 50;
            this.BtSearch.Text = "Search";
            this.BtSearch.UseVisualStyleBackColor = true;
            this.BtSearch.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // LabelFehler
            // 
            this.LabelFehler.AutoSize = true;
            this.LabelFehler.Location = new System.Drawing.Point(66, 44);
            this.LabelFehler.Name = "LabelFehler";
            this.LabelFehler.Size = new System.Drawing.Size(203, 13);
            this.LabelFehler.TabIndex = 56;
            this.LabelFehler.Text = "Fehler! Sie müssen eine Station angeben.";
            this.LabelFehler.Visible = false;
            // 
            // LVverbindung
            // 
            this.LVverbindung.BackColor = System.Drawing.Color.White;
            this.LVverbindung.Location = new System.Drawing.Point(12, 226);
            this.LVverbindung.Name = "LVverbindung";
            this.LVverbindung.Size = new System.Drawing.Size(626, 239);
            this.LVverbindung.TabIndex = 57;
            this.LVverbindung.UseCompatibleStateImageBehavior = false;
            // 
            // dTPTime
            // 
            this.dTPTime.Location = new System.Drawing.Point(69, 150);
            this.dTPTime.Name = "dTPTime";
            this.dTPTime.Size = new System.Drawing.Size(200, 20);
            this.dTPTime.TabIndex = 63;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(9, 156);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(41, 13);
            this.Datum.TabIndex = 64;
            this.Datum.Text = "Datum:";
            // 
            // LVtafel
            // 
            this.LVtafel.BackColor = System.Drawing.Color.White;
            this.LVtafel.Location = new System.Drawing.Point(642, 134);
            this.LVtafel.Name = "LVtafel";
            this.LVtafel.Size = new System.Drawing.Size(569, 330);
            this.LVtafel.TabIndex = 65;
            this.LVtafel.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Fahrplan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Abfahrtstafel";
            // 
            // LabelFehler3
            // 
            this.LabelFehler3.AutoSize = true;
            this.LabelFehler3.Location = new System.Drawing.Point(701, 44);
            this.LabelFehler3.Name = "LabelFehler3";
            this.LabelFehler3.Size = new System.Drawing.Size(203, 13);
            this.LabelFehler3.TabIndex = 70;
            this.LabelFehler3.Text = "Fehler! Sie müssen eine Station angeben.";
            this.LabelFehler3.Visible = false;
            // 
            // lkarte
            // 
            this.lkarte.AutoSize = true;
            this.lkarte.Location = new System.Drawing.Point(275, 72);
            this.lkarte.Name = "lkarte";
            this.lkarte.Size = new System.Drawing.Size(32, 13);
            this.lkarte.TabIndex = 71;
            this.lkarte.TabStop = true;
            this.lkarte.Text = "Karte";
            this.lkarte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.karte_LinkClicked);
            // 
            // lkarte2
            // 
            this.lkarte2.AutoSize = true;
            this.lkarte2.Location = new System.Drawing.Point(275, 127);
            this.lkarte2.Name = "lkarte2";
            this.lkarte2.Size = new System.Drawing.Size(32, 13);
            this.lkarte2.TabIndex = 72;
            this.lkarte2.TabStop = true;
            this.lkarte2.Text = "Karte";
            this.lkarte2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.karte2_LinkClicked);
            // 
            // AutoCom
            // 
            this.AutoCom.AutoSize = true;
            this.AutoCom.Location = new System.Drawing.Point(278, 99);
            this.AutoCom.Name = "AutoCom";
            this.AutoCom.Size = new System.Drawing.Size(129, 17);
            this.AutoCom.TabIndex = 73;
            this.AutoCom.Text = "Automatisch ausfüllen";
            this.AutoCom.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Switch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Switch_Click);
            // 
            // Vontb
            // 
            this.Vontb.FormattingEnabled = true;
            this.Vontb.Location = new System.Drawing.Point(69, 69);
            this.Vontb.Name = "Vontb";
            this.Vontb.Size = new System.Drawing.Size(200, 21);
            this.Vontb.TabIndex = 75;
            this.Vontb.TextChanged += new System.EventHandler(this.Vontb_TextChanged);
            // 
            // Nachtb
            // 
            this.Nachtb.FormattingEnabled = true;
            this.Nachtb.Location = new System.Drawing.Point(69, 124);
            this.Nachtb.Name = "Nachtb";
            this.Nachtb.Size = new System.Drawing.Size(200, 21);
            this.Nachtb.TabIndex = 76;
            this.Nachtb.TextChanged += new System.EventHandler(this.Nachtb_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1221, 494);
            this.Controls.Add(this.Nachtb);
            this.Controls.Add(this.Vontb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AutoCom);
            this.Controls.Add(this.lkarte2);
            this.Controls.Add(this.lkarte);
            this.Controls.Add(this.LabelFehler3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVtafel);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.dTPTime);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.station);
            this.Controls.Add(this.Stationtb);
            this.Controls.Add(this.LVverbindung);
            this.Controls.Add(this.LabelFehler);
            this.Controls.Add(this.BtSearch);
            this.Controls.Add(this.Nach);
            this.Controls.Add(this.Von);
            this.Name = "MainForm";
            this.Text = "Fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Stationtb;
        private System.Windows.Forms.Label station;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.Label Von;
        private System.Windows.Forms.Label Nach;
        private System.Windows.Forms.Button BtSearch;
        private System.Windows.Forms.Label LabelFehler;
        private System.Windows.Forms.ListView LVverbindung;
        private System.Windows.Forms.DateTimePicker dTPTime;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.ListView LVtafel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelFehler3;
        private System.Windows.Forms.LinkLabel lkarte;
        private System.Windows.Forms.LinkLabel lkarte2;
        private System.Windows.Forms.CheckBox AutoCom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Vontb;
        private System.Windows.Forms.ComboBox Nachtb;
    }
}

