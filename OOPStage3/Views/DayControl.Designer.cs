namespace OOPStage3.Views
{
    partial class DayControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.labelCustomEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(3, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 15);
            this.label.TabIndex = 3;
            this.label.Text = "label1";
            // 
            // labelCustomEvent
            // 
            this.labelCustomEvent.AutoSize = true;
            this.labelCustomEvent.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomEvent.Location = new System.Drawing.Point(3, 13);
            this.labelCustomEvent.Name = "labelCustomEvent";
            this.labelCustomEvent.Size = new System.Drawing.Size(32, 22);
            this.labelCustomEvent.TabIndex = 2;
            this.labelCustomEvent.Text = "00";
            // 
            // DayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.labelCustomEvent);
            this.Name = "DayControl";
            this.Size = new System.Drawing.Size(210, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelCustomEvent;
    }
}
