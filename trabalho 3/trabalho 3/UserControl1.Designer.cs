namespace trabalho_3
{
    partial class UserControl1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.button_exec = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_inf = new System.Windows.Forms.RichTextBox();
            this.textBox_comp = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_inf = new System.Windows.Forms.Panel();
            this.panel_comp = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Agitação",
            "Bolha",
            "HeapSort",
            "Inserção",
            "Pente",
            "Quick",
            "Seleção",
            "ShellSort"});
            this.comboBox.Location = new System.Drawing.Point(41, 25);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(189, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.Text = "Selecione o metodo";
            // 
            // button_iniciar
            // 
            this.button_iniciar.Location = new System.Drawing.Point(247, 25);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(75, 23);
            this.button_iniciar.TabIndex = 1;
            this.button_iniciar.Text = "iniciar";
            this.button_iniciar.UseVisualStyleBackColor = true;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(328, 25);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(75, 23);
            this.button_limpar.TabIndex = 2;
            this.button_limpar.Text = "limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // button_exec
            // 
            this.button_exec.Location = new System.Drawing.Point(370, 370);
            this.button_exec.Name = "button_exec";
            this.button_exec.Size = new System.Drawing.Size(75, 23);
            this.button_exec.TabIndex = 3;
            this.button_exec.Text = "executar";
            this.button_exec.UseVisualStyleBackColor = true;
            this.button_exec.Click += new System.EventHandler(this.button_exec_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(244, 372);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(120, 20);
            this.textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "quantidade de numeros que deseja gerar";
            // 
            // textBox_inf
            // 
            this.textBox_inf.HideSelection = false;
            this.textBox_inf.Location = new System.Drawing.Point(41, 85);
            this.textBox_inf.Name = "textBox_inf";
            this.textBox_inf.ReadOnly = true;
            this.textBox_inf.Size = new System.Drawing.Size(351, 273);
            this.textBox_inf.TabIndex = 6;
            this.textBox_inf.Text = "";
            // 
            // textBox_comp
            // 
            this.textBox_comp.HideSelection = false;
            this.textBox_comp.Location = new System.Drawing.Point(427, 85);
            this.textBox_comp.Name = "textBox_comp";
            this.textBox_comp.ReadOnly = true;
            this.textBox_comp.Size = new System.Drawing.Size(351, 273);
            this.textBox_comp.TabIndex = 7;
            this.textBox_comp.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "informações sobre os metodos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "comportamento do metodos";
            // 
            // panel_inf
            // 
            this.panel_inf.Location = new System.Drawing.Point(41, 69);
            this.panel_inf.Name = "panel_inf";
            this.panel_inf.Size = new System.Drawing.Size(351, 289);
            this.panel_inf.TabIndex = 10;
            // 
            // panel_comp
            // 
            this.panel_comp.Location = new System.Drawing.Point(427, 69);
            this.panel_comp.Name = "panel_comp";
            this.panel_comp.Size = new System.Drawing.Size(351, 289);
            this.panel_comp.TabIndex = 11;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_comp);
            this.Controls.Add(this.panel_inf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_comp);
            this.Controls.Add(this.textBox_inf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_exec);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.comboBox);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(800, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Button button_exec;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox textBox_inf;
        private System.Windows.Forms.RichTextBox textBox_comp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_inf;
        private System.Windows.Forms.Panel panel_comp;
    }
}
