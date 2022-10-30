namespace Łukasz_Kulesza_184764
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Counter = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.RemainingTimeLabel = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Counter.Location = new System.Drawing.Point(12, 9);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(419, 32);
            this.Counter.TabIndex = 0;
            this.Counter.Text = "Liczba poprawnych kliknięć: 0";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // RemainingTimeLabel
            // 
            this.RemainingTimeLabel.AutoSize = true;
            this.RemainingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemainingTimeLabel.Location = new System.Drawing.Point(12, 41);
            this.RemainingTimeLabel.Name = "RemainingTimeLabel";
            this.RemainingTimeLabel.Size = new System.Drawing.Size(283, 32);
            this.RemainingTimeLabel.TabIndex = 1;
            this.RemainingTimeLabel.Text = "Pozostały czas: 60s";
            // 
            // RemainingTime
            // 
            this.RemainingTime.Enabled = true;
            this.RemainingTime.Interval = 1000;
            this.RemainingTime.Tick += new System.EventHandler(this.RemainingTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.RemainingTimeLabel);
            this.Controls.Add(this.Counter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label RemainingTimeLabel;
        private System.Windows.Forms.Timer RemainingTime;
    }
}

