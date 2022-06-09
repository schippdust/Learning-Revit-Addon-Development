
namespace RenumberingTest
{
    partial class RenumberRoomsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.begin = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.startIntLabel = new System.Windows.Forms.Label();
            this.incrementLabel = new System.Windows.Forms.Label();
            this.prefixData = new System.Windows.Forms.TextBox();
            this.incrementData = new System.Windows.Forms.NumericUpDown();
            this.startData = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.incrementData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startData)).BeginInit();
            this.SuspendLayout();
            // 
            // begin
            // 
            this.begin.AutoEllipsis = true;
            this.begin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.begin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.begin.FlatAppearance.BorderSize = 2;
            this.begin.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.begin.Location = new System.Drawing.Point(200, 172);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(146, 35);
            this.begin.TabIndex = 0;
            this.begin.Text = "Begin Renumbering";
            this.begin.UseVisualStyleBackColor = false;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // cancel
            // 
            this.cancel.AutoEllipsis = true;
            this.cancel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(41, 172);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(153, 35);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Renumber Rooms";
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixLabel.Location = new System.Drawing.Point(14, 133);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(207, 18);
            this.prefixLabel.TabIndex = 3;
            this.prefixLabel.Text = "Use Prefix When Renumbering";
            // 
            // startIntLabel
            // 
            this.startIntLabel.AutoSize = true;
            this.startIntLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startIntLabel.Location = new System.Drawing.Point(14, 95);
            this.startIntLabel.Name = "startIntLabel";
            this.startIntLabel.Size = new System.Drawing.Size(168, 18);
            this.startIntLabel.TabIndex = 4;
            this.startIntLabel.Text = "Start Numbering From...";
            // 
            // incrementLabel
            // 
            this.incrementLabel.AutoSize = true;
            this.incrementLabel.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementLabel.Location = new System.Drawing.Point(14, 56);
            this.incrementLabel.Name = "incrementLabel";
            this.incrementLabel.Size = new System.Drawing.Size(136, 18);
            this.incrementLabel.TabIndex = 5;
            this.incrementLabel.Text = "Use Increment Of...";
            // 
            // prefixData
            // 
            this.prefixData.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefixData.Location = new System.Drawing.Point(277, 126);
            this.prefixData.Name = "prefixData";
            this.prefixData.Size = new System.Drawing.Size(64, 25);
            this.prefixData.TabIndex = 8;
            this.prefixData.TextChanged += new System.EventHandler(this.prefixData_TextChanged);
            // 
            // incrementData
            // 
            this.incrementData.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incrementData.Location = new System.Drawing.Point(277, 49);
            this.incrementData.Name = "incrementData";
            this.incrementData.Size = new System.Drawing.Size(64, 25);
            this.incrementData.TabIndex = 9;
            this.incrementData.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.incrementData.ValueChanged += new System.EventHandler(this.incrementData_ValueChanged);
            // 
            // startData
            // 
            this.startData.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startData.Location = new System.Drawing.Point(277, 88);
            this.startData.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.startData.Name = "startData";
            this.startData.Size = new System.Drawing.Size(64, 25);
            this.startData.TabIndex = 10;
            this.startData.ValueChanged += new System.EventHandler(this.startData_ValueChanged);
            // 
            // RenumberRoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 224);
            this.Controls.Add(this.startData);
            this.Controls.Add(this.incrementData);
            this.Controls.Add(this.prefixData);
            this.Controls.Add(this.incrementLabel);
            this.Controls.Add(this.startIntLabel);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.begin);
            this.Name = "RenumberRoomsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.incrementData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label startIntLabel;
        private System.Windows.Forms.Label incrementLabel;
        private System.Windows.Forms.TextBox prefixData;
        private System.Windows.Forms.NumericUpDown incrementData;
        private System.Windows.Forms.NumericUpDown startData;
    }
}