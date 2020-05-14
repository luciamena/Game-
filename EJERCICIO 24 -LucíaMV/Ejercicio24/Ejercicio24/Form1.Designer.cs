namespace Ejercicio24
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
            this.planificador = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_personas_Ce = new System.Windows.Forms.Label();
            this.txtBx_coste_Ce = new System.Windows.Forms.TextBox();
            this.Num_Ce = new System.Windows.Forms.NumericUpDown();
            this.ckBx_Saludable_Ce = new System.Windows.Forms.CheckBox();
            this.lbl_coste_Ce = new System.Windows.Forms.Label();
            this.ckBx_lujo_Ce = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBx_coste_Cu = new System.Windows.Forms.TextBox();
            this.lbl_coste_Cu = new System.Windows.Forms.Label();
            this.txtBx_txtTarta_Cu = new System.Windows.Forms.TextBox();
            this.lbl_txtTarta_Cu = new System.Windows.Forms.Label();
            this.ckBx_lujo_Cu = new System.Windows.Forms.CheckBox();
            this.Num_Cu = new System.Windows.Forms.NumericUpDown();
            this.lbl_personas_Cu = new System.Windows.Forms.Label();
            this.planificador.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ce)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Cu)).BeginInit();
            this.SuspendLayout();
            // 
            // planificador
            // 
            this.planificador.Controls.Add(this.tabPage1);
            this.planificador.Controls.Add(this.tabPage2);
            this.planificador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planificador.Location = new System.Drawing.Point(0, 0);
            this.planificador.Margin = new System.Windows.Forms.Padding(4);
            this.planificador.Name = "planificador";
            this.planificador.SelectedIndex = 0;
            this.planificador.Size = new System.Drawing.Size(358, 383);
            this.planificador.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.lbl_personas_Ce);
            this.tabPage1.Controls.Add(this.txtBx_coste_Ce);
            this.tabPage1.Controls.Add(this.Num_Ce);
            this.tabPage1.Controls.Add(this.ckBx_Saludable_Ce);
            this.tabPage1.Controls.Add(this.lbl_coste_Ce);
            this.tabPage1.Controls.Add(this.ckBx_lujo_Ce);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(350, 350);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cenas";
            // 
            // lbl_personas_Ce
            // 
            this.lbl_personas_Ce.AutoSize = true;
            this.lbl_personas_Ce.Location = new System.Drawing.Point(23, 48);
            this.lbl_personas_Ce.Name = "lbl_personas_Ce";
            this.lbl_personas_Ce.Size = new System.Drawing.Size(167, 20);
            this.lbl_personas_Ce.TabIndex = 0;
            this.lbl_personas_Ce.Text = "Número de Personas";
            // 
            // txtBx_coste_Ce
            // 
            this.txtBx_coste_Ce.Location = new System.Drawing.Point(104, 283);
            this.txtBx_coste_Ce.Name = "txtBx_coste_Ce";
            this.txtBx_coste_Ce.ReadOnly = true;
            this.txtBx_coste_Ce.Size = new System.Drawing.Size(100, 26);
            this.txtBx_coste_Ce.TabIndex = 5;
            // 
            // Num_Ce
            // 
            this.Num_Ce.Location = new System.Drawing.Point(220, 46);
            this.Num_Ce.Name = "Num_Ce";
            this.Num_Ce.Size = new System.Drawing.Size(55, 26);
            this.Num_Ce.TabIndex = 1;
            this.Num_Ce.ValueChanged += new System.EventHandler(this.Num_Ce_ValueChanged);
            // 
            // ckBx_Saludable_Ce
            // 
            this.ckBx_Saludable_Ce.AutoSize = true;
            this.ckBx_Saludable_Ce.Location = new System.Drawing.Point(27, 154);
            this.ckBx_Saludable_Ce.Name = "ckBx_Saludable_Ce";
            this.ckBx_Saludable_Ce.Size = new System.Drawing.Size(162, 24);
            this.ckBx_Saludable_Ce.TabIndex = 3;
            this.ckBx_Saludable_Ce.Text = "Opción Saludable";
            this.ckBx_Saludable_Ce.UseVisualStyleBackColor = true;
            this.ckBx_Saludable_Ce.CheckedChanged += new System.EventHandler(this.ckBx_Saludable_Ce_CheckedChanged);
            // 
            // lbl_coste_Ce
            // 
            this.lbl_coste_Ce.AutoSize = true;
            this.lbl_coste_Ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coste_Ce.Location = new System.Drawing.Point(23, 286);
            this.lbl_coste_Ce.Name = "lbl_coste_Ce";
            this.lbl_coste_Ce.Size = new System.Drawing.Size(64, 20);
            this.lbl_coste_Ce.TabIndex = 4;
            this.lbl_coste_Ce.Text = "Coste:";
            // 
            // ckBx_lujo_Ce
            // 
            this.ckBx_lujo_Ce.AutoSize = true;
            this.ckBx_lujo_Ce.Location = new System.Drawing.Point(27, 114);
            this.ckBx_lujo_Ce.Name = "ckBx_lujo_Ce";
            this.ckBx_lujo_Ce.Size = new System.Drawing.Size(177, 24);
            this.ckBx_lujo_Ce.TabIndex = 2;
            this.ckBx_lujo_Ce.Text = "Decoración de Lujo";
            this.ckBx_lujo_Ce.UseVisualStyleBackColor = true;
            this.ckBx_lujo_Ce.CheckedChanged += new System.EventHandler(this.ckBx_lujo_Ce_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.txtBx_coste_Cu);
            this.tabPage2.Controls.Add(this.lbl_coste_Cu);
            this.tabPage2.Controls.Add(this.txtBx_txtTarta_Cu);
            this.tabPage2.Controls.Add(this.lbl_txtTarta_Cu);
            this.tabPage2.Controls.Add(this.ckBx_lujo_Cu);
            this.tabPage2.Controls.Add(this.Num_Cu);
            this.tabPage2.Controls.Add(this.lbl_personas_Cu);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(350, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cumpleaños";
            // 
            // txtBx_coste_Cu
            // 
            this.txtBx_coste_Cu.Location = new System.Drawing.Point(103, 283);
            this.txtBx_coste_Cu.Name = "txtBx_coste_Cu";
            this.txtBx_coste_Cu.ReadOnly = true;
            this.txtBx_coste_Cu.Size = new System.Drawing.Size(100, 26);
            this.txtBx_coste_Cu.TabIndex = 9;
            // 
            // lbl_coste_Cu
            // 
            this.lbl_coste_Cu.AutoSize = true;
            this.lbl_coste_Cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coste_Cu.Location = new System.Drawing.Point(22, 286);
            this.lbl_coste_Cu.Name = "lbl_coste_Cu";
            this.lbl_coste_Cu.Size = new System.Drawing.Size(64, 20);
            this.lbl_coste_Cu.TabIndex = 8;
            this.lbl_coste_Cu.Text = "Coste:";
            // 
            // txtBx_txtTarta_Cu
            // 
            this.txtBx_txtTarta_Cu.Location = new System.Drawing.Point(26, 217);
            this.txtBx_txtTarta_Cu.Name = "txtBx_txtTarta_Cu";
            this.txtBx_txtTarta_Cu.Size = new System.Drawing.Size(249, 26);
            this.txtBx_txtTarta_Cu.TabIndex = 7;
            this.txtBx_txtTarta_Cu.TextChanged += new System.EventHandler(this.txtBx_txtTarta_Cu_TextChanged);
            // 
            // lbl_txtTarta_Cu
            // 
            this.lbl_txtTarta_Cu.AutoSize = true;
            this.lbl_txtTarta_Cu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txtTarta_Cu.Location = new System.Drawing.Point(22, 177);
            this.lbl_txtTarta_Cu.Name = "lbl_txtTarta_Cu";
            this.lbl_txtTarta_Cu.Size = new System.Drawing.Size(158, 20);
            this.lbl_txtTarta_Cu.TabIndex = 6;
            this.lbl_txtTarta_Cu.Text = "Texto en la Tarta:";
            // 
            // ckBx_lujo_Cu
            // 
            this.ckBx_lujo_Cu.AutoSize = true;
            this.ckBx_lujo_Cu.Location = new System.Drawing.Point(26, 114);
            this.ckBx_lujo_Cu.Name = "ckBx_lujo_Cu";
            this.ckBx_lujo_Cu.Size = new System.Drawing.Size(177, 24);
            this.ckBx_lujo_Cu.TabIndex = 5;
            this.ckBx_lujo_Cu.Text = "Decoración de Lujo";
            this.ckBx_lujo_Cu.UseVisualStyleBackColor = true;
            this.ckBx_lujo_Cu.CheckedChanged += new System.EventHandler(this.ckBx_lujo_Cu_CheckedChanged);
            // 
            // Num_Cu
            // 
            this.Num_Cu.Location = new System.Drawing.Point(220, 46);
            this.Num_Cu.Name = "Num_Cu";
            this.Num_Cu.Size = new System.Drawing.Size(55, 26);
            this.Num_Cu.TabIndex = 4;
            this.Num_Cu.ValueChanged += new System.EventHandler(this.Num_Cu_ValueChanged);
            // 
            // lbl_personas_Cu
            // 
            this.lbl_personas_Cu.AutoSize = true;
            this.lbl_personas_Cu.Location = new System.Drawing.Point(22, 48);
            this.lbl_personas_Cu.Name = "lbl_personas_Cu";
            this.lbl_personas_Cu.Size = new System.Drawing.Size(167, 20);
            this.lbl_personas_Cu.TabIndex = 3;
            this.lbl_personas_Cu.Text = "Número de Personas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(358, 383);
            this.Controls.Add(this.planificador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Planificador de Eventos";
            this.planificador.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Ce)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Cu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl planificador;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtBx_coste_Ce;
        private System.Windows.Forms.Label lbl_coste_Ce;
        private System.Windows.Forms.CheckBox ckBx_Saludable_Ce;
        private System.Windows.Forms.CheckBox ckBx_lujo_Ce;
        private System.Windows.Forms.NumericUpDown Num_Ce;
        private System.Windows.Forms.Label lbl_personas_Ce;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBx_coste_Cu;
        private System.Windows.Forms.Label lbl_coste_Cu;
        private System.Windows.Forms.TextBox txtBx_txtTarta_Cu;
        private System.Windows.Forms.Label lbl_txtTarta_Cu;
        private System.Windows.Forms.CheckBox ckBx_lujo_Cu;
        private System.Windows.Forms.NumericUpDown Num_Cu;
        private System.Windows.Forms.Label lbl_personas_Cu;
    }
}

