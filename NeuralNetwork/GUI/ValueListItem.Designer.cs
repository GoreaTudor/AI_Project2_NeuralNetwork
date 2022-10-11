
namespace NeuralNetwork.GUI {
    partial class ValueListItem {
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
            this.lbl_value = new System.Windows.Forms.Label();
            this.numericUpDown_value = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.Location = new System.Drawing.Point(3, 5);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(63, 25);
            this.lbl_value.TabIndex = 0;
            this.lbl_value.Text = "Value";
            // 
            // numericUpDown_value
            // 
            this.numericUpDown_value.DecimalPlaces = 2;
            this.numericUpDown_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_value.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_value.Location = new System.Drawing.Point(77, 3);
            this.numericUpDown_value.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.numericUpDown_value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147352576});
            this.numericUpDown_value.Name = "numericUpDown_value";
            this.numericUpDown_value.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_value.TabIndex = 1;
            // 
            // ValueListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.numericUpDown_value);
            this.Controls.Add(this.lbl_value);
            this.Name = "ValueListItem";
            this.Size = new System.Drawing.Size(200, 40);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.NumericUpDown numericUpDown_value;
    }
}
