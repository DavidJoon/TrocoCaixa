
namespace TrocoCaixa
{
    partial class TelaPrincipal
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelCompra = new System.Windows.Forms.Label();
            this.labelDinheiro = new System.Windows.Forms.Label();
            this.labelTroco = new System.Windows.Forms.Label();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.textBoxDinheiro = new System.Windows.Forms.TextBox();
            this.textBoxTroco = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelMoeda1 = new System.Windows.Forms.Label();
            this.labelMoeda5 = new System.Windows.Forms.Label();
            this.labelMoeda4 = new System.Windows.Forms.Label();
            this.labelMoeda3 = new System.Windows.Forms.Label();
            this.labelMoeda2 = new System.Windows.Forms.Label();
            this.labelMoeda6 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label001 = new System.Windows.Forms.Label();
            this.label005 = new System.Windows.Forms.Label();
            this.label010 = new System.Windows.Forms.Label();
            this.label025 = new System.Windows.Forms.Label();
            this.label050 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.BackColor = System.Drawing.Color.PaleGreen;
            this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(180, 67);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(437, 55);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Troco para Compras";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCompra
            // 
            this.labelCompra.BackColor = System.Drawing.Color.Orange;
            this.labelCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCompra.Location = new System.Drawing.Point(121, 165);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(192, 23);
            this.labelCompra.TabIndex = 2;
            this.labelCompra.Text = "Valor da Compra:";
            this.labelCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDinheiro
            // 
            this.labelDinheiro.BackColor = System.Drawing.Color.Orange;
            this.labelDinheiro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDinheiro.Location = new System.Drawing.Point(121, 217);
            this.labelDinheiro.Name = "labelDinheiro";
            this.labelDinheiro.Size = new System.Drawing.Size(192, 23);
            this.labelDinheiro.TabIndex = 3;
            this.labelDinheiro.Text = "Valor em Dinheiro:";
            this.labelDinheiro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTroco
            // 
            this.labelTroco.BackColor = System.Drawing.Color.Orange;
            this.labelTroco.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTroco.Location = new System.Drawing.Point(121, 269);
            this.labelTroco.Name = "labelTroco";
            this.labelTroco.Size = new System.Drawing.Size(192, 23);
            this.labelTroco.TabIndex = 4;
            this.labelTroco.Text = "Troco";
            this.labelTroco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompra.Location = new System.Drawing.Point(329, 164);
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(193, 29);
            this.textBoxCompra.TabIndex = 5;
            this.textBoxCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDinheiro
            // 
            this.textBoxDinheiro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDinheiro.Location = new System.Drawing.Point(330, 216);
            this.textBoxDinheiro.Name = "textBoxDinheiro";
            this.textBoxDinheiro.Size = new System.Drawing.Size(193, 29);
            this.textBoxDinheiro.TabIndex = 6;
            this.textBoxDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTroco
            // 
            this.textBoxTroco.Enabled = false;
            this.textBoxTroco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTroco.Location = new System.Drawing.Point(331, 268);
            this.textBoxTroco.Name = "textBoxTroco";
            this.textBoxTroco.ReadOnly = true;
            this.textBoxTroco.Size = new System.Drawing.Size(192, 29);
            this.textBoxTroco.TabIndex = 7;
            this.textBoxTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCalcular.Location = new System.Drawing.Point(249, 328);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(158, 35);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelMoeda1
            // 
            this.labelMoeda1.AutoSize = true;
            this.labelMoeda1.BackColor = System.Drawing.Color.MistyRose;
            this.labelMoeda1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda1.Location = new System.Drawing.Point(648, 164);
            this.labelMoeda1.Name = "labelMoeda1";
            this.labelMoeda1.Size = new System.Drawing.Size(108, 19);
            this.labelMoeda1.TabIndex = 9;
            this.labelMoeda1.Text = "Moedas R$ 1,00";
            // 
            // labelMoeda5
            // 
            this.labelMoeda5.AutoSize = true;
            this.labelMoeda5.BackColor = System.Drawing.Color.MistyRose;
            this.labelMoeda5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda5.Location = new System.Drawing.Point(648, 292);
            this.labelMoeda5.Name = "labelMoeda5";
            this.labelMoeda5.Size = new System.Drawing.Size(110, 19);
            this.labelMoeda5.TabIndex = 10;
            this.labelMoeda5.Text = "Moedas R$ 0,05";
            // 
            // labelMoeda4
            // 
            this.labelMoeda4.AutoSize = true;
            this.labelMoeda4.BackColor = System.Drawing.Color.MistyRose;
            this.labelMoeda4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda4.Location = new System.Drawing.Point(648, 260);
            this.labelMoeda4.Name = "labelMoeda4";
            this.labelMoeda4.Size = new System.Drawing.Size(108, 19);
            this.labelMoeda4.TabIndex = 11;
            this.labelMoeda4.Text = "Moedas R$ 0,10";
            // 
            // labelMoeda3
            // 
            this.labelMoeda3.AutoSize = true;
            this.labelMoeda3.BackColor = System.Drawing.Color.MistyRose;
            this.labelMoeda3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda3.Location = new System.Drawing.Point(648, 228);
            this.labelMoeda3.Name = "labelMoeda3";
            this.labelMoeda3.Size = new System.Drawing.Size(110, 19);
            this.labelMoeda3.TabIndex = 12;
            this.labelMoeda3.Text = "Moedas R$ 0,25";
            // 
            // labelMoeda2
            // 
            this.labelMoeda2.AutoSize = true;
            this.labelMoeda2.BackColor = System.Drawing.Color.MistyRose;
            this.labelMoeda2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda2.Location = new System.Drawing.Point(648, 196);
            this.labelMoeda2.Name = "labelMoeda2";
            this.labelMoeda2.Size = new System.Drawing.Size(110, 19);
            this.labelMoeda2.TabIndex = 13;
            this.labelMoeda2.Text = "Moedas R$ 0,50";
            // 
            // labelMoeda6
            // 
            this.labelMoeda6.AutoSize = true;
            this.labelMoeda6.BackColor = System.Drawing.Color.MistyRose;
            this.labelMoeda6.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMoeda6.Location = new System.Drawing.Point(648, 324);
            this.labelMoeda6.Name = "labelMoeda6";
            this.labelMoeda6.Size = new System.Drawing.Size(108, 19);
            this.labelMoeda6.TabIndex = 14;
            this.labelMoeda6.Text = "Moedas R$ 0,01";
            // 
            // label100
            // 
            this.label100.BackColor = System.Drawing.Color.MintCream;
            this.label100.Location = new System.Drawing.Point(604, 164);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(38, 19);
            this.label100.TabIndex = 15;
            this.label100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label001
            // 
            this.label001.BackColor = System.Drawing.Color.MintCream;
            this.label001.Location = new System.Drawing.Point(604, 324);
            this.label001.Name = "label001";
            this.label001.Size = new System.Drawing.Size(38, 19);
            this.label001.TabIndex = 16;
            this.label001.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label005
            // 
            this.label005.BackColor = System.Drawing.Color.MintCream;
            this.label005.Location = new System.Drawing.Point(604, 292);
            this.label005.Name = "label005";
            this.label005.Size = new System.Drawing.Size(38, 19);
            this.label005.TabIndex = 17;
            this.label005.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label010
            // 
            this.label010.BackColor = System.Drawing.Color.MintCream;
            this.label010.Location = new System.Drawing.Point(604, 260);
            this.label010.Name = "label010";
            this.label010.Size = new System.Drawing.Size(38, 19);
            this.label010.TabIndex = 18;
            this.label010.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label025
            // 
            this.label025.BackColor = System.Drawing.Color.MintCream;
            this.label025.Location = new System.Drawing.Point(604, 228);
            this.label025.Name = "label025";
            this.label025.Size = new System.Drawing.Size(38, 19);
            this.label025.TabIndex = 19;
            this.label025.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label050
            // 
            this.label050.BackColor = System.Drawing.Color.MintCream;
            this.label050.Location = new System.Drawing.Point(604, 196);
            this.label050.Name = "label050";
            this.label050.Size = new System.Drawing.Size(38, 19);
            this.label050.TabIndex = 20;
            this.label050.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label050);
            this.Controls.Add(this.label025);
            this.Controls.Add(this.label010);
            this.Controls.Add(this.label005);
            this.Controls.Add(this.label001);
            this.Controls.Add(this.label100);
            this.Controls.Add(this.labelMoeda6);
            this.Controls.Add(this.labelMoeda2);
            this.Controls.Add(this.labelMoeda3);
            this.Controls.Add(this.labelMoeda4);
            this.Controls.Add(this.labelMoeda5);
            this.Controls.Add(this.labelMoeda1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxTroco);
            this.Controls.Add(this.textBoxDinheiro);
            this.Controls.Add(this.textBoxCompra);
            this.Controls.Add(this.labelTroco);
            this.Controls.Add(this.labelDinheiro);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caixa :: Troco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelCompra;
        private System.Windows.Forms.Label labelDinheiro;
        private System.Windows.Forms.Label labelTroco;
        private System.Windows.Forms.TextBox textBoxCompra;
        private System.Windows.Forms.TextBox textBoxDinheiro;
        private System.Windows.Forms.TextBox textBoxTroco;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelMoeda1;
        private System.Windows.Forms.Label labelMoeda5;
        private System.Windows.Forms.Label labelMoeda4;
        private System.Windows.Forms.Label labelMoeda3;
        private System.Windows.Forms.Label labelMoeda2;
        private System.Windows.Forms.Label labelMoeda6;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label001;
        private System.Windows.Forms.Label label005;
        private System.Windows.Forms.Label label010;
        private System.Windows.Forms.Label label025;
        private System.Windows.Forms.Label label050;
    }
}

