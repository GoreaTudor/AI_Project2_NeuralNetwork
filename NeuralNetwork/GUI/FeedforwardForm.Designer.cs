
namespace NeuralNetwork.GUI {
    partial class FeedforwardForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.lbl_input = new System.Windows.Forms.Label();
            this.flowLayoutPanel_inputs = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_outputs = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_arrow = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.btn_done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_input.Location = new System.Drawing.Point(12, 9);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(84, 29);
            this.lbl_input.TabIndex = 0;
            this.lbl_input.Text = "Input: ";
            // 
            // flowLayoutPanel_inputs
            // 
            this.flowLayoutPanel_inputs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel_inputs.Location = new System.Drawing.Point(17, 41);
            this.flowLayoutPanel_inputs.Name = "flowLayoutPanel_inputs";
            this.flowLayoutPanel_inputs.Size = new System.Drawing.Size(220, 300);
            this.flowLayoutPanel_inputs.TabIndex = 1;
            // 
            // flowLayoutPanel_outputs
            // 
            this.flowLayoutPanel_outputs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.flowLayoutPanel_outputs.Location = new System.Drawing.Point(356, 41);
            this.flowLayoutPanel_outputs.Name = "flowLayoutPanel_outputs";
            this.flowLayoutPanel_outputs.Size = new System.Drawing.Size(220, 300);
            this.flowLayoutPanel_outputs.TabIndex = 2;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(351, 9);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(104, 29);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "Output: ";
            // 
            // lbl_arrow
            // 
            this.lbl_arrow.AutoSize = true;
            this.lbl_arrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arrow.Location = new System.Drawing.Point(243, 167);
            this.lbl_arrow.Name = "lbl_arrow";
            this.lbl_arrow.Size = new System.Drawing.Size(97, 38);
            this.lbl_arrow.TabIndex = 4;
            this.lbl_arrow.Text = "===>";
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(17, 371);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(120, 40);
            this.btn_calculate.TabIndex = 5;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.Location = new System.Drawing.Point(496, 371);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(80, 40);
            this.btn_done.TabIndex = 6;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // FeedforwardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 433);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_arrow);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.flowLayoutPanel_outputs);
            this.Controls.Add(this.flowLayoutPanel_inputs);
            this.Controls.Add(this.lbl_input);
            this.Name = "FeedforwardForm";
            this.Text = "FeedforwardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_inputs;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_outputs;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_arrow;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Button btn_done;
    }
}