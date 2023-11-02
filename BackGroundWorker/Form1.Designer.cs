namespace BackGroundWorker
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
            pbProgreso = new ProgressBar();
            btnIniciar = new Button();
            btnDetener = new Button();
            bwHilo = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // pbProgreso
            // 
            pbProgreso.Location = new Point(76, 131);
            pbProgreso.Name = "pbProgreso";
            pbProgreso.Size = new Size(482, 27);
            pbProgreso.TabIndex = 0;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(76, 200);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(483, 200);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(75, 23);
            btnDetener.TabIndex = 2;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            // 
            // bwHilo
            // 
            bwHilo.WorkerReportsProgress = true;
            bwHilo.WorkerSupportsCancellation = true;
            bwHilo.DoWork += bwHilo_DoWork;
            bwHilo.ProgressChanged += bwHilo_ProgressChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 366);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(pbProgreso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar pbProgreso;
        private Button btnIniciar;
        private Button btnDetener;
        private System.ComponentModel.BackgroundWorker bwHilo;
    }
}