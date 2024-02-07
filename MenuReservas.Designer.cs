namespace Automobile
{
    partial class MenuReservas
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
            this.labelTitleReservas = new System.Windows.Forms.Label();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitleReservas
            // 
            this.labelTitleReservas.AutoSize = true;
            this.labelTitleReservas.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleReservas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelTitleReservas.Location = new System.Drawing.Point(29, 27);
            this.labelTitleReservas.Name = "labelTitleReservas";
            this.labelTitleReservas.Size = new System.Drawing.Size(228, 55);
            this.labelTitleReservas.TabIndex = 4;
            this.labelTitleReservas.Text = "Reservas";
            // 
            // voltarButton
            // 
            this.voltarButton.Location = new System.Drawing.Point(39, 378);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(114, 27);
            this.voltarButton.TabIndex = 10;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // MenuReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.labelTitleReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuReservas";
            this.Text = "MenuReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitleReservas;
        private System.Windows.Forms.Button voltarButton;
    }
}