
namespace NeuralNetwork.GUI {
    partial class LayerOptionsForm {
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
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.numericUpDown_theta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_g = new System.Windows.Forms.NumericUpDown();
            this.comboBox_inputFunction = new System.Windows.Forms.ComboBox();
            this.lbl_inputFunction = new System.Windows.Forms.Label();
            this.lbl_activationFunction = new System.Windows.Forms.Label();
            this.lbl_outputFunction = new System.Windows.Forms.Label();
            this.comboBox_activationFunction = new System.Windows.Forms.ComboBox();
            this.checkBox_outputFunction = new System.Windows.Forms.CheckBox();
            this.lbl_theta = new System.Windows.Forms.Label();
            this.lbl_g = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_theta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_g)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_theta
            // 
            this.numericUpDown_theta.DecimalPlaces = 2;
            this.numericUpDown_theta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_theta.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_theta.Location = new System.Drawing.Point(105, 159);
            this.numericUpDown_theta.Name = "numericUpDown_theta";
            this.numericUpDown_theta.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_theta.TabIndex = 0;
            // 
            // numericUpDown_g
            // 
            this.numericUpDown_g.DecimalPlaces = 2;
            this.numericUpDown_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_g.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_g.Location = new System.Drawing.Point(105, 194);
            this.numericUpDown_g.Name = "numericUpDown_g";
            this.numericUpDown_g.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_g.TabIndex = 1;
            this.numericUpDown_g.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_inputFunction
            // 
            this.comboBox_inputFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_inputFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_inputFunction.FormattingEnabled = true;
            this.comboBox_inputFunction.Items.AddRange(new object[] {
            "Sum",
            "Prod",
            "Min",
            "Max"});
            this.comboBox_inputFunction.Location = new System.Drawing.Point(227, 6);
            this.comboBox_inputFunction.Name = "comboBox_inputFunction";
            this.comboBox_inputFunction.Size = new System.Drawing.Size(121, 33);
            this.comboBox_inputFunction.TabIndex = 2;
            // 
            // lbl_inputFunction
            // 
            this.lbl_inputFunction.AutoSize = true;
            this.lbl_inputFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inputFunction.Location = new System.Drawing.Point(12, 9);
            this.lbl_inputFunction.Name = "lbl_inputFunction";
            this.lbl_inputFunction.Size = new System.Drawing.Size(146, 25);
            this.lbl_inputFunction.TabIndex = 3;
            this.lbl_inputFunction.Text = "Input Function: ";
            // 
            // lbl_activationFunction
            // 
            this.lbl_activationFunction.AutoSize = true;
            this.lbl_activationFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_activationFunction.Location = new System.Drawing.Point(12, 48);
            this.lbl_activationFunction.Name = "lbl_activationFunction";
            this.lbl_activationFunction.Size = new System.Drawing.Size(188, 25);
            this.lbl_activationFunction.TabIndex = 4;
            this.lbl_activationFunction.Text = "Activation Function: ";
            // 
            // lbl_outputFunction
            // 
            this.lbl_outputFunction.AutoSize = true;
            this.lbl_outputFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outputFunction.Location = new System.Drawing.Point(12, 84);
            this.lbl_outputFunction.Name = "lbl_outputFunction";
            this.lbl_outputFunction.Size = new System.Drawing.Size(162, 25);
            this.lbl_outputFunction.TabIndex = 5;
            this.lbl_outputFunction.Text = "Output Function: ";
            // 
            // comboBox_activationFunction
            // 
            this.comboBox_activationFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_activationFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_activationFunction.FormattingEnabled = true;
            this.comboBox_activationFunction.Items.AddRange(new object[] {
            "Step",
            "Sign",
            "Sigmoid",
            "TanH",
            "Linear"});
            this.comboBox_activationFunction.Location = new System.Drawing.Point(227, 45);
            this.comboBox_activationFunction.Name = "comboBox_activationFunction";
            this.comboBox_activationFunction.Size = new System.Drawing.Size(121, 33);
            this.comboBox_activationFunction.TabIndex = 6;
            // 
            // checkBox_outputFunction
            // 
            this.checkBox_outputFunction.AutoSize = true;
            this.checkBox_outputFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_outputFunction.Location = new System.Drawing.Point(227, 84);
            this.checkBox_outputFunction.Name = "checkBox_outputFunction";
            this.checkBox_outputFunction.Size = new System.Drawing.Size(89, 29);
            this.checkBox_outputFunction.TabIndex = 7;
            this.checkBox_outputFunction.Text = "Binary";
            this.checkBox_outputFunction.UseVisualStyleBackColor = true;
            // 
            // lbl_theta
            // 
            this.lbl_theta.AutoSize = true;
            this.lbl_theta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theta.Location = new System.Drawing.Point(13, 161);
            this.lbl_theta.Name = "lbl_theta";
            this.lbl_theta.Size = new System.Drawing.Size(66, 25);
            this.lbl_theta.TabIndex = 8;
            this.lbl_theta.Text = "theta: ";
            // 
            // lbl_g
            // 
            this.lbl_g.AutoSize = true;
            this.lbl_g.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_g.Location = new System.Drawing.Point(13, 196);
            this.lbl_g.Name = "lbl_g";
            this.lbl_g.Size = new System.Drawing.Size(86, 25);
            this.lbl_g.TabIndex = 9;
            this.lbl_g.Text = "g (or a): ";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(12, 275);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(170, 40);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save changes";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(248, 284);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_cancel.TabIndex = 11;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // LayerOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 336);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_g);
            this.Controls.Add(this.lbl_theta);
            this.Controls.Add(this.checkBox_outputFunction);
            this.Controls.Add(this.comboBox_activationFunction);
            this.Controls.Add(this.lbl_outputFunction);
            this.Controls.Add(this.lbl_activationFunction);
            this.Controls.Add(this.lbl_inputFunction);
            this.Controls.Add(this.comboBox_inputFunction);
            this.Controls.Add(this.numericUpDown_g);
            this.Controls.Add(this.numericUpDown_theta);
            this.Name = "LayerOptionsForm";
            this.Text = "LayerOptionsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_theta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_g)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_theta;
        private System.Windows.Forms.NumericUpDown numericUpDown_g;
        private System.Windows.Forms.ComboBox comboBox_inputFunction;
        private System.Windows.Forms.Label lbl_inputFunction;
        private System.Windows.Forms.Label lbl_activationFunction;
        private System.Windows.Forms.Label lbl_outputFunction;
        private System.Windows.Forms.ComboBox comboBox_activationFunction;
        private System.Windows.Forms.CheckBox checkBox_outputFunction;
        private System.Windows.Forms.Label lbl_theta;
        private System.Windows.Forms.Label lbl_g;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}