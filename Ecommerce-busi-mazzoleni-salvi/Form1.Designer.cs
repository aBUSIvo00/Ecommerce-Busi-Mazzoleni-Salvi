namespace Ecommerce_busi_mazzoleni_salvi
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
            button1 = new Button();
            button2 = new Button();
            CARRELLO = new ListBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(287, 238);
            button1.Name = "button1";
            button1.Size = new Size(98, 58);
            button1.TabIndex = 0;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(391, 238);
            button2.Name = "button2";
            button2.Size = new Size(98, 58);
            button2.TabIndex = 1;
            button2.Text = "RIMUOVI";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CARRELLO
            // 
            CARRELLO.FormattingEnabled = true;
            CARRELLO.ItemHeight = 15;
            CARRELLO.Location = new Point(328, 138);
            CARRELLO.Name = "CARRELLO";
            CARRELLO.Size = new Size(120, 94);
            CARRELLO.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(339, 302);
            button3.Name = "button3";
            button3.Size = new Size(98, 58);
            button3.TabIndex = 3;
            button3.Text = "SVUOTA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(CARRELLO);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox CARRELLO;
        private Button button3;
    }
}