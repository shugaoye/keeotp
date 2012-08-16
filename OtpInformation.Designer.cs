﻿namespace KeeOtp
{
    partial class OtpInformation
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.radioButtonSix = new System.Windows.Forms.RadioButton();
            this.labelKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.radioButtonEight = new System.Windows.Forms.RadioButton();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(31, 31);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(231, 20);
            this.textBoxKey.TabIndex = 0;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(140, 65);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(23, 20);
            this.textBoxStep.TabIndex = 1;
            this.textBoxStep.TextChanged += new System.EventHandler(this.textBoxStep_TextChanged);
            // 
            // radioButtonSix
            // 
            this.radioButtonSix.AutoSize = true;
            this.radioButtonSix.Checked = true;
            this.radioButtonSix.Location = new System.Drawing.Point(140, 101);
            this.radioButtonSix.Name = "radioButtonSix";
            this.radioButtonSix.Size = new System.Drawing.Size(60, 17);
            this.radioButtonSix.TabIndex = 2;
            this.radioButtonSix.TabStop = true;
            this.radioButtonSix.Text = "6 Digits";
            this.radioButtonSix.UseVisualStyleBackColor = true;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(28, 15);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(110, 13);
            this.labelKey.TabIndex = 3;
            this.labelKey.Text = "Base32 Encoded Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time Step (Seconds)";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(79, 101);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(55, 13);
            this.labelSize.TabIndex = 5;
            this.labelSize.Text = "Code Size";
            // 
            // radioButtonEight
            // 
            this.radioButtonEight.AutoSize = true;
            this.radioButtonEight.Location = new System.Drawing.Point(140, 124);
            this.radioButtonEight.Name = "radioButtonEight";
            this.radioButtonEight.Size = new System.Drawing.Size(60, 17);
            this.radioButtonEight.TabIndex = 6;
            this.radioButtonEight.Text = "8 Digits";
            this.radioButtonEight.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(106, 167);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 7;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(187, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // OtpInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 202);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.radioButtonEight);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.radioButtonSix);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.textBoxKey);
            this.Name = "OtpInformation";
            this.Text = "OtpInformation";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OtpInformation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxStep;
        private System.Windows.Forms.RadioButton radioButtonSix;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.RadioButton radioButtonEight;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
    }
}