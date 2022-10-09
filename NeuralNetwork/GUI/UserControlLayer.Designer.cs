
namespace NeuralNetwork.GUI {
    partial class UserControlLayer {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.btn_layerOptions = new System.Windows.Forms.Button();
            this.layerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_layerName = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_layerOptions
            // 
            this.btn_layerOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_layerOptions.Location = new System.Drawing.Point(10, 39);
            this.btn_layerOptions.Name = "btn_layerOptions";
            this.btn_layerOptions.Size = new System.Drawing.Size(100, 40);
            this.btn_layerOptions.TabIndex = 0;
            this.btn_layerOptions.Text = "Options";
            this.btn_layerOptions.UseVisualStyleBackColor = true;
            this.btn_layerOptions.Click += new System.EventHandler(this.btn_layerOptions_Click);
            // 
            // layerFlowLayoutPanel
            // 
            this.layerFlowLayoutPanel.AutoScroll = true;
            this.layerFlowLayoutPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.layerFlowLayoutPanel.Location = new System.Drawing.Point(12, 85);
            this.layerFlowLayoutPanel.Name = "layerFlowLayoutPanel";
            this.layerFlowLayoutPanel.Size = new System.Drawing.Size(200, 300);
            this.layerFlowLayoutPanel.TabIndex = 2;
            // 
            // lbl_layerName
            // 
            this.lbl_layerName.AutoSize = true;
            this.lbl_layerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_layerName.Location = new System.Drawing.Point(4, 4);
            this.lbl_layerName.Name = "lbl_layerName";
            this.lbl_layerName.Size = new System.Drawing.Size(178, 32);
            this.lbl_layerName.TabIndex = 3;
            this.lbl_layerName.Text = "Layer Name";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(10, 391);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 40);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(122, 391);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(90, 40);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // UserControlLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_layerName);
            this.Controls.Add(this.layerFlowLayoutPanel);
            this.Controls.Add(this.btn_layerOptions);
            this.Name = "UserControlLayer";
            this.Size = new System.Drawing.Size(230, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_layerOptions;
        private System.Windows.Forms.FlowLayoutPanel layerFlowLayoutPanel;
        private System.Windows.Forms.Label lbl_layerName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
    }
}
