namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Button();
            this.Player2 = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.panel_game = new System.Windows.Forms.Panel();
            this.A1 = new System.Windows.Forms.Button();
            this.text = new System.Windows.Forms.Label();
            this.panel_game.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(159, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tic Tac Toe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(22)))), ((int)(((byte)(61)))));
            this.Player1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Player1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player1.Location = new System.Drawing.Point(162, 60);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(131, 57);
            this.Player1.TabIndex = 1;
            this.Player1.Text = "1 Player";
            this.Player1.UseVisualStyleBackColor = false;
            this.Player1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(22)))), ((int)(((byte)(61)))));
            this.Player2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Player2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Player2.Location = new System.Drawing.Point(299, 60);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(131, 57);
            this.Player2.TabIndex = 2;
            this.Player2.Text = "2 Players";
            this.Player2.UseVisualStyleBackColor = false;
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(22)))), ((int)(((byte)(61)))));
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Start.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Start.Location = new System.Drawing.Point(228, 474);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(131, 57);
            this.Start.TabIndex = 3;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Transparent;
            this.A2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.A2.FlatAppearance.BorderSize = 2;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A2.Location = new System.Drawing.Point(128, 9);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(100, 100);
            this.A2.TabIndex = 8;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.button_Click);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Transparent;
            this.A3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.A3.FlatAppearance.BorderSize = 2;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A3.Location = new System.Drawing.Point(246, 9);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(100, 100);
            this.A3.TabIndex = 9;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.button_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.B1.FlatAppearance.BorderSize = 2;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B1.Location = new System.Drawing.Point(8, 118);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 100);
            this.B1.TabIndex = 10;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.button_Click);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.B2.FlatAppearance.BorderSize = 2;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B2.Location = new System.Drawing.Point(128, 118);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(100, 100);
            this.B2.TabIndex = 11;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.button_Click);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.B3.FlatAppearance.BorderSize = 2;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.B3.Location = new System.Drawing.Point(246, 117);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(100, 100);
            this.B3.TabIndex = 12;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.button_Click);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Transparent;
            this.C3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.C3.FlatAppearance.BorderSize = 2;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C3.Location = new System.Drawing.Point(246, 224);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(100, 100);
            this.C3.TabIndex = 13;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.button_Click);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Transparent;
            this.C2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.C2.FlatAppearance.BorderSize = 2;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C2.Location = new System.Drawing.Point(128, 224);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(100, 100);
            this.C2.TabIndex = 14;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.button_Click);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Transparent;
            this.C1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.C1.FlatAppearance.BorderSize = 2;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.C1.Location = new System.Drawing.Point(8, 224);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(100, 100);
            this.C1.TabIndex = 15;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.button_Click);
            // 
            // panel_game
            // 
            this.panel_game.BackColor = System.Drawing.Color.Transparent;
            this.panel_game.Controls.Add(this.A1);
            this.panel_game.Controls.Add(this.C1);
            this.panel_game.Controls.Add(this.C2);
            this.panel_game.Controls.Add(this.C3);
            this.panel_game.Controls.Add(this.B3);
            this.panel_game.Controls.Add(this.B2);
            this.panel_game.Controls.Add(this.B1);
            this.panel_game.Controls.Add(this.A3);
            this.panel_game.Controls.Add(this.A2);
            this.panel_game.Location = new System.Drawing.Point(114, 136);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(355, 333);
            this.panel_game.TabIndex = 4;
            this.panel_game.Visible = false;
            this.panel_game.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(46)))));
            this.A1.FlatAppearance.BorderSize = 2;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.A1.Location = new System.Drawing.Point(8, 9);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 100);
            this.A1.TabIndex = 16;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.button_Click);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.Transparent;
            this.text.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.text.Location = new System.Drawing.Point(247, 533);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(95, 19);
            this.text.TabIndex = 5;
            this.text.Text = "Press Start";
            this.text.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.text);
            this.Controls.Add(this.panel_game);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_game.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Player1;
        private System.Windows.Forms.Button Player2;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Panel panel_game;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Label text;
    }
}

