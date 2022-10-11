
namespace NeuralNetwork {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.hiddenFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.IL_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.OL_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_feedforward = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hiddenFlowLayoutPanel
            // 
            this.hiddenFlowLayoutPanel.AutoScroll = true;
            this.hiddenFlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.hiddenFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.hiddenFlowLayoutPanel.Location = new System.Drawing.Point(248, 58);
            this.hiddenFlowLayoutPanel.Name = "hiddenFlowLayoutPanel";
            this.hiddenFlowLayoutPanel.Size = new System.Drawing.Size(710, 480);
            this.hiddenFlowLayoutPanel.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(248, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 40);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add HL";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(384, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 40);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete HL";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // IL_flowLayoutPanel
            // 
            this.IL_flowLayoutPanel.Location = new System.Drawing.Point(12, 58);
            this.IL_flowLayoutPanel.Name = "IL_flowLayoutPanel";
            this.IL_flowLayoutPanel.Size = new System.Drawing.Size(230, 450);
            this.IL_flowLayoutPanel.TabIndex = 3;
            // 
            // OL_flowLayoutPanel
            // 
            this.OL_flowLayoutPanel.Location = new System.Drawing.Point(964, 58);
            this.OL_flowLayoutPanel.Name = "OL_flowLayoutPanel";
            this.OL_flowLayoutPanel.Size = new System.Drawing.Size(230, 450);
            this.OL_flowLayoutPanel.TabIndex = 4;
            // 
            // btn_feedforward
            // 
            this.btn_feedforward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_feedforward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_feedforward.Location = new System.Drawing.Point(808, 12);
            this.btn_feedforward.Name = "btn_feedforward";
            this.btn_feedforward.Size = new System.Drawing.Size(150, 40);
            this.btn_feedforward.TabIndex = 5;
            this.btn_feedforward.Text = "FeedForward";
            this.btn_feedforward.UseVisualStyleBackColor = false;
            this.btn_feedforward.Click += new System.EventHandler(this.btn_feedforward_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(89, 560);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(57, 20);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(8, 560);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(75, 20);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Status: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 589);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.btn_feedforward);
            this.Controls.Add(this.OL_flowLayoutPanel);
            this.Controls.Add(this.IL_flowLayoutPanel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.hiddenFlowLayoutPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel hiddenFlowLayoutPanel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.FlowLayoutPanel IL_flowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel OL_flowLayoutPanel;
        private System.Windows.Forms.Button btn_feedforward;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label lbl_status;
    }
}