namespace Fahrplan
{
    partial class Form1
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
            this.LVverbindung = new System.Windows.Forms.ListView();
            this.LabelFehler = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Clear = new System.Windows.Forms.LinkLabel();
            this.Datum = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Nach = new System.Windows.Forms.Label();
            this.Von = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LVverbindung
            // 
            this.LVverbindung.Location = new System.Drawing.Point(376, 94);
            this.LVverbindung.Name = "LVverbindung";
            this.LVverbindung.Size = new System.Drawing.Size(751, 308);
            this.LVverbindung.TabIndex = 45;
            this.LVverbindung.UseCompatibleStateImageBehavior = false;
            this.LVverbindung.Visible = false;
            // 
            // LabelFehler
            // 
            this.LabelFehler.AutoSize = true;
            this.LabelFehler.Location = new System.Drawing.Point(237, 50);
            this.LabelFehler.Name = "LabelFehler";
            this.LabelFehler.Size = new System.Drawing.Size(203, 13);
            this.LabelFehler.TabIndex = 44;
            this.LabelFehler.Text = "Fehler! Sie müssen eine Station angeben.";
            this.LabelFehler.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Uhrzeit:";
            // 
            // time
            // 
            this.time.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.time.Location = new System.Drawing.Point(115, 178);
            this.time.Name = "time";
            this.time.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.time.Size = new System.Drawing.Size(200, 20);
            this.time.TabIndex = 42;
            this.time.Value = new System.DateTime(2017, 5, 2, 13, 35, 0, 0);
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(115, 146);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 20);
            this.date.TabIndex = 41;
            // 
            // Clear
            // 
            this.Clear.AutoSize = true;
            this.Clear.Location = new System.Drawing.Point(284, 224);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(31, 13);
            this.Clear.TabIndex = 40;
            this.Clear.TabStop = true;
            this.Clear.Text = "Clear";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(47, 152);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(41, 13);
            this.Datum.TabIndex = 39;
            this.Datum.Text = "Datum:";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(115, 219);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 38;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Nach
            // 
            this.Nach.AutoSize = true;
            this.Nach.Location = new System.Drawing.Point(52, 126);
            this.Nach.Name = "Nach";
            this.Nach.Size = new System.Drawing.Size(36, 13);
            this.Nach.TabIndex = 37;
            this.Nach.Text = "Nach:";
            // 
            // Von
            // 
            this.Von.AutoSize = true;
            this.Von.Location = new System.Drawing.Point(59, 94);
            this.Von.Name = "Von";
            this.Von.Size = new System.Drawing.Size(29, 13);
            this.Von.TabIndex = 36;
            this.Von.Text = "Von:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 120);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1174, 452);
            this.Controls.Add(this.LVverbindung);
            this.Controls.Add(this.LabelFehler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Nach);
            this.Controls.Add(this.Von);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView LVverbindung;
        private System.Windows.Forms.Label LabelFehler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker time;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.LinkLabel Clear;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label Nach;
        private System.Windows.Forms.Label Von;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

