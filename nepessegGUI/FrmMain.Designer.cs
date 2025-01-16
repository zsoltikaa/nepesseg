namespace nepessegGUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOrszagFelvetele = new Label();
            lblOrszag = new Label();
            lblTerulet = new Label();
            lblNepesseg = new Label();
            lblFovaros = new Label();
            lblFovarosLakossag = new Label();
            tbxOrszag = new TextBox();
            tbxTerulet = new TextBox();
            tbxNepesseg = new TextBox();
            tbxFovaros = new TextBox();
            tbxFovarosLakossag = new TextBox();
            btnMentes = new Button();
            lblUzenet = new Label();
            btnKilepes = new Button();
            SuspendLayout();
            // 
            // lblOrszagFelvetele
            // 
            lblOrszagFelvetele.AutoSize = true;
            lblOrszagFelvetele.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblOrszagFelvetele.Location = new Point(136, 9);
            lblOrszagFelvetele.Name = "lblOrszagFelvetele";
            lblOrszagFelvetele.Size = new Size(268, 45);
            lblOrszagFelvetele.TabIndex = 0;
            lblOrszagFelvetele.Text = "Új ország felvétele";
            // 
            // lblOrszag
            // 
            lblOrszag.AutoSize = true;
            lblOrszag.Font = new Font("Segoe UI", 11.25F);
            lblOrszag.Location = new Point(95, 81);
            lblOrszag.Name = "lblOrszag";
            lblOrszag.Size = new Size(58, 20);
            lblOrszag.TabIndex = 1;
            lblOrszag.Text = "Ország:";
            // 
            // lblTerulet
            // 
            lblTerulet.AutoSize = true;
            lblTerulet.Font = new Font("Segoe UI", 11.25F);
            lblTerulet.Location = new Point(96, 123);
            lblTerulet.Name = "lblTerulet";
            lblTerulet.Size = new Size(57, 20);
            lblTerulet.TabIndex = 2;
            lblTerulet.Text = "Terület:";
            // 
            // lblNepesseg
            // 
            lblNepesseg.AutoSize = true;
            lblNepesseg.Font = new Font("Segoe UI", 11.25F);
            lblNepesseg.Location = new Point(76, 172);
            lblNepesseg.Name = "lblNepesseg";
            lblNepesseg.Size = new Size(77, 20);
            lblNepesseg.TabIndex = 3;
            lblNepesseg.Text = "Népesség:";
            // 
            // lblFovaros
            // 
            lblFovaros.AutoSize = true;
            lblFovaros.Font = new Font("Segoe UI", 11.25F);
            lblFovaros.Location = new Point(90, 222);
            lblFovaros.Name = "lblFovaros";
            lblFovaros.Size = new Size(63, 20);
            lblFovaros.TabIndex = 4;
            lblFovaros.Text = "Főváros:";
            // 
            // lblFovarosLakossag
            // 
            lblFovarosLakossag.AutoSize = true;
            lblFovarosLakossag.Font = new Font("Segoe UI", 11.25F);
            lblFovarosLakossag.Location = new Point(21, 266);
            lblFovarosLakossag.Name = "lblFovarosLakossag";
            lblFovarosLakossag.Size = new Size(132, 20);
            lblFovarosLakossag.TabIndex = 5;
            lblFovarosLakossag.Text = "Főváros lakossága:";
            // 
            // tbxOrszag
            // 
            tbxOrszag.BackColor = SystemColors.Control;
            tbxOrszag.Location = new Point(159, 81);
            tbxOrszag.Name = "tbxOrszag";
            tbxOrszag.Size = new Size(221, 23);
            tbxOrszag.TabIndex = 6;
            tbxOrszag.Text = "Chile";
            // 
            // tbxTerulet
            // 
            tbxTerulet.BackColor = SystemColors.Control;
            tbxTerulet.Location = new Point(159, 123);
            tbxTerulet.Name = "tbxTerulet";
            tbxTerulet.Size = new Size(221, 23);
            tbxTerulet.TabIndex = 7;
            tbxTerulet.Text = "756950";
            tbxTerulet.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxNepesseg
            // 
            tbxNepesseg.BackColor = SystemColors.Control;
            tbxNepesseg.Location = new Point(159, 173);
            tbxNepesseg.Name = "tbxNepesseg";
            tbxNepesseg.Size = new Size(221, 23);
            tbxNepesseg.TabIndex = 8;
            tbxNepesseg.Text = "19458000";
            tbxNepesseg.TextAlign = HorizontalAlignment.Right;
            // 
            // tbxFovaros
            // 
            tbxFovaros.BackColor = SystemColors.Control;
            tbxFovaros.Location = new Point(159, 222);
            tbxFovaros.Name = "tbxFovaros";
            tbxFovaros.Size = new Size(221, 23);
            tbxFovaros.TabIndex = 9;
            tbxFovaros.Text = "Santiago";
            // 
            // tbxFovarosLakossag
            // 
            tbxFovarosLakossag.BackColor = SystemColors.Control;
            tbxFovarosLakossag.Location = new Point(159, 266);
            tbxFovarosLakossag.Name = "tbxFovarosLakossag";
            tbxFovarosLakossag.Size = new Size(221, 23);
            tbxFovarosLakossag.TabIndex = 10;
            tbxFovarosLakossag.Text = "6257516";
            tbxFovarosLakossag.TextAlign = HorizontalAlignment.Right;
            // 
            // btnMentes
            // 
            btnMentes.BackColor = SystemColors.Control;
            btnMentes.FlatStyle = FlatStyle.Flat;
            btnMentes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnMentes.Location = new Point(398, 81);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(114, 65);
            btnMentes.TabIndex = 11;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = false;
            // 
            // lblUzenet
            // 
            lblUzenet.Location = new Point(86, 302);
            lblUzenet.Name = "lblUzenet";
            lblUzenet.Size = new Size(305, 69);
            lblUzenet.TabIndex = 12;
            lblUzenet.Text = "Kérem adja meg az adatokat!";
            lblUzenet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnKilepes
            // 
            btnKilepes.BackColor = SystemColors.Control;
            btnKilepes.FlatStyle = FlatStyle.Flat;
            btnKilepes.Location = new Point(398, 351);
            btnKilepes.Name = "btnKilepes";
            btnKilepes.Size = new Size(115, 36);
            btnKilepes.TabIndex = 13;
            btnKilepes.Text = "Kilépés";
            btnKilepes.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(524, 399);
            Controls.Add(btnKilepes);
            Controls.Add(lblUzenet);
            Controls.Add(btnMentes);
            Controls.Add(tbxFovarosLakossag);
            Controls.Add(tbxFovaros);
            Controls.Add(tbxNepesseg);
            Controls.Add(tbxTerulet);
            Controls.Add(tbxOrszag);
            Controls.Add(lblFovarosLakossag);
            Controls.Add(lblFovaros);
            Controls.Add(lblNepesseg);
            Controls.Add(lblTerulet);
            Controls.Add(lblOrszag);
            Controls.Add(lblOrszagFelvetele);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FrmMain";
            Text = "Új ország felvétele";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrszagFelvetele;
        private Label lblOrszag;
        private Label lblTerulet;
        private Label lblNepesseg;
        private Label lblFovaros;
        private Label lblFovarosLakossag;
        private TextBox tbxOrszag;
        private TextBox tbxTerulet;
        private TextBox tbxNepesseg;
        private TextBox tbxFovaros;
        private TextBox tbxFovarosLakossag;
        private Button btnMentes;
        private Label lblUzenet;
        private Button btnKilepes;
    }
}
