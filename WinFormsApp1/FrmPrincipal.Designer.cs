﻿namespace WinFormsApp1
{
    partial class FrmPrincipal
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
            groupBox1 = new ReaLTaiizor.Controls.GroupBox();
            Comanda = new ReaLTaiizor.Controls.AirButton();
            Usuarios = new ReaLTaiizor.Controls.AirButton();
            Pedido = new ReaLTaiizor.Controls.AirButton();
            Cardapio = new ReaLTaiizor.Controls.AirButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackGColor = Color.AliceBlue;
            groupBox1.BaseColor = Color.Transparent;
            groupBox1.BorderColorG = Color.FromArgb(159, 159, 161);
            groupBox1.BorderColorH = Color.FromArgb(182, 180, 186);
            groupBox1.Controls.Add(Comanda);
            groupBox1.Controls.Add(Usuarios);
            groupBox1.Controls.Add(Pedido);
            groupBox1.Controls.Add(Cardapio);
            groupBox1.Font = new Font("Tahoma", 9F);
            groupBox1.ForeColor = Color.FromArgb(53, 53, 53);
            groupBox1.HeaderColor = Color.Transparent;
            groupBox1.Location = new Point(39, 88);
            groupBox1.MinimumSize = new Size(136, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 28, 5, 5);
            groupBox1.Size = new Size(715, 289);
            groupBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            groupBox1.TabIndex = 1;
            // 
            // Comanda
            // 
            Comanda.BackColor = SystemColors.ActiveCaptionText;
            Comanda.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            Comanda.Font = new Font("Segoe UI", 9F);
            Comanda.Image = null;
            Comanda.Location = new Point(197, 81);
            Comanda.Name = "Comanda";
            Comanda.NoRounding = false;
            Comanda.Size = new Size(146, 137);
            Comanda.TabIndex = 4;
            Comanda.Text = "Comanda";
            Comanda.Transparent = false;
            // 
            // Usuarios
            // 
            Usuarios.BackColor = SystemColors.ActiveCaptionText;
            Usuarios.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            Usuarios.Font = new Font("Segoe UI", 9F);
            Usuarios.Image = null;
            Usuarios.Location = new Point(537, 81);
            Usuarios.Name = "Usuarios";
            Usuarios.NoRounding = false;
            Usuarios.Size = new Size(146, 137);
            Usuarios.TabIndex = 3;
            Usuarios.Text = "Usuarios";
            Usuarios.Transparent = false;
            // 
            // Pedido
            // 
            Pedido.BackColor = SystemColors.ActiveCaptionText;
            Pedido.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            Pedido.Font = new Font("Segoe UI", 9F);
            Pedido.Image = null;
            Pedido.Location = new Point(368, 81);
            Pedido.Name = "Pedido";
            Pedido.NoRounding = false;
            Pedido.Size = new Size(146, 137);
            Pedido.TabIndex = 2;
            Pedido.Text = "Pedido";
            Pedido.Transparent = false;
            // 
            // Cardapio
            // 
            Cardapio.BackColor = SystemColors.ActiveCaptionText;
            Cardapio.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            Cardapio.Font = new Font("Segoe UI", 9F);
            Cardapio.Image = null;
            Cardapio.Location = new Point(30, 81);
            Cardapio.Name = "Cardapio";
            Cardapio.NoRounding = false;
            Cardapio.Size = new Size(146, 137);
            Cardapio.TabIndex = 1;
            Cardapio.Text = "Cardapio";
            Cardapio.Transparent = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "FrmPrincipal";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.GroupBox groupBox1;
        private ReaLTaiizor.Controls.AirButton Comanda;
        private ReaLTaiizor.Controls.AirButton Usuarios;
        private ReaLTaiizor.Controls.AirButton Pedido;
        private ReaLTaiizor.Controls.AirButton Cardapio;
    }
}
