
namespace NeuralNetwork.GUI {
    partial class WeightListItem {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.lbl_weightNr = new System.Windows.Forms.Label();
            this.numericUpDown_weightValue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_weightNr
            // 
            this.lbl_weightNr.AutoSize = true;
            this.lbl_weightNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_weightNr.Location = new System.Drawing.Point(3, 5);
            this.lbl_weightNr.Name = "lbl_weightNr";
            this.lbl_weightNr.Size = new System.Drawing.Size(74, 25);
            this.lbl_weightNr.TabIndex = 0;
            this.lbl_weightNr.Text = "Weight";
            // 
            // numericUpDown_weightValue
            // 
            this.numericUpDown_weightValue.DecimalPlaces = 2;
            this.numericUpDown_weightValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_weightValue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_weightValue.Location = new System.Drawing.Point(83, 3);
            this.numericUpDown_weightValue.Name = "numericUpDown_weightValue";
            this.numericUpDown_weightValue.Size = new System.Drawing.Size(100, 30);
            this.numericUpDown_weightValue.TabIndex = 1;
            // 
            // WeightListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.numericUpDown_weightValue);
            this.Controls.Add(this.lbl_weightNr);
            this.Name = "WeightListItem";
            this.Size = new System.Drawing.Size(200, 40);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_weightValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_weightNr;
        private System.Windows.Forms.NumericUpDown numericUpDown_weightValue;
    }
}
