namespace gigi
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
            ButtonAdcionar = new Button();
            buttonCancelar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // ButtonAdcionar
            // 
            ButtonAdcionar.Location = new Point(12, 12);
            ButtonAdcionar.Name = "ButtonAdcionar";
            ButtonAdcionar.Size = new Size(75, 23);
            ButtonAdcionar.TabIndex = 0;
            ButtonAdcionar.Text = "Adicionar\r\n";
            ButtonAdcionar.UseVisualStyleBackColor = true;
            ButtonAdcionar.Click += ButtonAdcionar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(93, 12);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 1;
            buttonCancelar.Text = "Remover";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(156, 304);
            listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(204, 396);
            Controls.Add(listBox1);
            Controls.Add(buttonCancelar);
            Controls.Add(ButtonAdcionar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonAdcionar;
        private Button buttonCancelar;
        private ListBox listBox1;
    }
}
