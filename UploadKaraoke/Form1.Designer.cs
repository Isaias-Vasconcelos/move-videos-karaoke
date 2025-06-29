namespace UploadKaraoke
{
    partial class Form1
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
            label1 = new Label();
            selecionarPastaLida = new Button();
            pastaParaLer = new TextBox();
            label2 = new Label();
            pastaDestino = new TextBox();
            selecionarPastaDestino = new Button();
            button3 = new Button();
            label3 = new Label();
            contadorInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Pasta para ler";
            // 
            // selecionarPastaLida
            // 
            selecionarPastaLida.BackColor = SystemColors.Highlight;
            selecionarPastaLida.ForeColor = SystemColors.ControlLightLight;
            selecionarPastaLida.Location = new Point(380, 54);
            selecionarPastaLida.Name = "selecionarPastaLida";
            selecionarPastaLida.Size = new Size(213, 31);
            selecionarPastaLida.TabIndex = 1;
            selecionarPastaLida.Text = "SELECIONAR";
            selecionarPastaLida.UseVisualStyleBackColor = false;
            selecionarPastaLida.Click += selecionarPastaLida_Click;
            // 
            // pastaParaLer
            // 
            pastaParaLer.Location = new Point(116, 56);
            pastaParaLer.Name = "pastaParaLer";
            pastaParaLer.PlaceholderText = "Selecione a ser lida";
            pastaParaLer.Size = new Size(258, 27);
            pastaParaLer.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 3;
            label2.Text = "Pasta destino";
            // 
            // pastaDestino
            // 
            pastaDestino.Location = new Point(116, 115);
            pastaDestino.Name = "pastaDestino";
            pastaDestino.PlaceholderText = "Selecione a pasta destino";
            pastaDestino.Size = new Size(258, 27);
            pastaDestino.TabIndex = 4;
            // 
            // selecionarPastaDestino
            // 
            selecionarPastaDestino.BackColor = SystemColors.Highlight;
            selecionarPastaDestino.ForeColor = SystemColors.ControlLight;
            selecionarPastaDestino.Location = new Point(380, 115);
            selecionarPastaDestino.Name = "selecionarPastaDestino";
            selecionarPastaDestino.Size = new Size(213, 31);
            selecionarPastaDestino.TabIndex = 5;
            selecionarPastaDestino.Text = "SELECIONAR";
            selecionarPastaDestino.UseVisualStyleBackColor = false;
            selecionarPastaDestino.Click += selecionarPastaDestino_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Desktop;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(12, 222);
            button3.Name = "button3";
            button3.Size = new Size(581, 43);
            button3.TabIndex = 6;
            button3.Text = "Renomear arquivos";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 178);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 7;
            label3.Text = "Contador";
            // 
            // contadorInput
            // 
            contadorInput.Location = new Point(116, 175);
            contadorInput.Name = "contadorInput";
            contadorInput.PlaceholderText = "Digite o contador";
            contadorInput.Size = new Size(258, 27);
            contadorInput.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 291);
            Controls.Add(contadorInput);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(selecionarPastaDestino);
            Controls.Add(pastaDestino);
            Controls.Add(label2);
            Controls.Add(pastaParaLer);
            Controls.Add(selecionarPastaLida);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Renomear Arquivos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button selecionarPastaLida;
        private TextBox pastaParaLer;
        private Label label2;
        private TextBox pastaDestino;
        private Button selecionarPastaDestino;
        private Button button3;
        private Label label3;
        private TextBox contadorInput;
    }
}
