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
            this.Vontb = new System.Windows.Forms.TextBox();
            this.Nachtb = new System.Windows.Forms.TextBox();
            this.Von = new System.Windows.Forms.Label();
            this.Nach = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.LabelFehler = new System.Windows.Forms.Label();
            this.LVverbindung = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dTPTime = new System.Windows.Forms.DateTimePicker();
            this.Datum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Stationtb
            // 
            this.Stationtb.Location = new System.Drawing.Point(720, 63);
            this.Stationtb.Name = "Stationtb";
            this.Stationtb.Size = new System.Drawing.Size(200, 20);
            this.Stationtb.TabIndex = 58;
            // 
            // station
            // 
            this.station.AutoSize = true;
            this.station.Location = new System.Drawing.Point(644, 66);
            this.station.Name = "station";
            this.station.Size = new System.Drawing.Size(43, 13);
            this.station.TabIndex = 59;
            this.station.Text = "Station:";
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(720, 98);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 23);
            this.Search2.TabIndex = 60;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            // 
            // Vontb
            // 
            this.Vontb.Location = new System.Drawing.Point(79, 66);
            this.Vontb.Name = "Vontb";
            this.Vontb.Size = new System.Drawing.Size(200, 20);
            this.Vontb.TabIndex = 46;
            // 
            // Nachtb
            // 
            this.Nachtb.Location = new System.Drawing.Point(79, 92);
            this.Nachtb.Name = "Nachtb";
            this.Nachtb.Size = new System.Drawing.Size(200, 20);
            this.Nachtb.TabIndex = 47;
            // 
            // Von
            // 
            this.Von.AutoSize = true;
            this.Von.Location = new System.Drawing.Point(23, 66);
            this.Von.Name = "Von";
            this.Von.Size = new System.Drawing.Size(29, 13);
            this.Von.TabIndex = 48;
            this.Von.Text = "Von:";
            // 
            // Nach
            // 
            this.Nach.AutoSize = true;
            this.Nach.Location = new System.Drawing.Point(16, 98);
            this.Nach.Name = "Nach";
            this.Nach.Size = new System.Drawing.Size(36, 13);
            this.Nach.TabIndex = 49;
            this.Nach.Text = "Nach:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(79, 155);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 50;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // LabelFehler
            // 
            this.LabelFehler.AutoSize = true;
            this.LabelFehler.Location = new System.Drawing.Point(76, 9);
            this.LabelFehler.Name = "LabelFehler";
            this.LabelFehler.Size = new System.Drawing.Size(203, 13);
            this.LabelFehler.TabIndex = 56;
            this.LabelFehler.Text = "Fehler! Sie müssen eine Station angeben.";
            this.LabelFehler.Visible = false;
            // 
            // LVverbindung
            // 
            this.LVverbindung.Location = new System.Drawing.Point(12, 226);
            this.LVverbindung.Name = "LVverbindung";
            this.LVverbindung.Size = new System.Drawing.Size(626, 239);
            this.LVverbindung.TabIndex = 57;
            this.LVverbindung.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(294, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 61;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Liste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dTPTime
            // 
            this.dTPTime.Location = new System.Drawing.Point(79, 124);
            this.dTPTime.Name = "dTPTime";
            this.dTPTime.Size = new System.Drawing.Size(200, 20);
            this.dTPTime.TabIndex = 63;
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(11, 130);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(41, 13);
            this.Datum.TabIndex = 64;
            this.Datum.Text = "Datum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 494);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.dTPTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.station);
            this.Controls.Add(this.Stationtb);
            this.Controls.Add(this.LVverbindung);
            this.Controls.Add(this.LabelFehler);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Nach);
            this.Controls.Add(this.Von);
            this.Controls.Add(this.Nachtb);
            this.Controls.Add(this.Vontb);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Stationtb;
        private System.Windows.Forms.Label station;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.TextBox Vontb;
        private System.Windows.Forms.TextBox Nachtb;
        private System.Windows.Forms.Label Von;
        private System.Windows.Forms.Label Nach;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label LabelFehler;
        private System.Windows.Forms.ListView LVverbindung;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dTPTime;
        private System.Windows.Forms.Label Datum;
    }
}

