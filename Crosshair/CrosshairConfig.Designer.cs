namespace Crosshair
{
    partial class CrosshairConfig
    {
        private System.ComponentModel.IContainer components = null;

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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrosshairConfig));
            label1 = new Label();
            sizeVal = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            xOffsetVal = new NumericUpDown();
            yOffsetVal = new NumericUpDown();
            shortcutButton = new Button();
            startButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            bVal = new NumericUpDown();
            gVal = new NumericUpDown();
            rVal = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            aVal = new NumericUpDown();
            label10 = new Label();
            label11 = new Label();
            shortcutConfirm = new Label();
            hideInRecording = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)sizeVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xOffsetVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yOffsetVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rVal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aVal).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Size:";
            // 
            // sizeVal
            // 
            sizeVal.Location = new Point(62, 37);
            sizeVal.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            sizeVal.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            sizeVal.Name = "sizeVal";
            sizeVal.Size = new Size(34, 23);
            sizeVal.TabIndex = 0;
            sizeVal.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 0;
            label2.Text = "X offset:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 95);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Y offset:";
            // 
            // xOffsetVal
            // 
            xOffsetVal.Location = new Point(83, 65);
            xOffsetVal.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            xOffsetVal.Minimum = new decimal(new int[] { 2000, 0, 0, int.MinValue });
            xOffsetVal.Name = "xOffsetVal";
            xOffsetVal.Size = new Size(58, 23);
            xOffsetVal.TabIndex = 1;
            // 
            // yOffsetVal
            // 
            yOffsetVal.Location = new Point(83, 93);
            yOffsetVal.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            yOffsetVal.Minimum = new decimal(new int[] { 2000, 0, 0, int.MinValue });
            yOffsetVal.Name = "yOffsetVal";
            yOffsetVal.Size = new Size(58, 23);
            yOffsetVal.TabIndex = 2;
            // 
            // shortcutButton
            // 
            shortcutButton.Location = new Point(12, 171);
            shortcutButton.Name = "shortcutButton";
            shortcutButton.Size = new Size(143, 34);
            shortcutButton.TabIndex = 7;
            shortcutButton.Text = "Create Shortcut";
            shortcutButton.UseVisualStyleBackColor = true;
            shortcutButton.Click += shortcutButton_Click;
            // 
            // startButton
            // 
            startButton.Location = new Point(169, 171);
            startButton.Name = "startButton";
            startButton.Size = new Size(143, 34);
            startButton.TabIndex = 8;
            startButton.Text = "Start Crosshair";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // label4
            // 
            label4.Location = new Point(205, 11);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 0;
            label4.Text = "Color [0 - 255]";
            // 
            // label5
            // 
            label5.Location = new Point(188, 95);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 0;
            label5.Text = "Blue";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.Location = new Point(188, 67);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 0;
            label6.Text = "Green";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // bVal
            // 
            bVal.Location = new Point(241, 93);
            bVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            bVal.Name = "bVal";
            bVal.Size = new Size(50, 23);
            bVal.TabIndex = 5;
            bVal.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // gVal
            // 
            gVal.Location = new Point(241, 65);
            gVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            gVal.Name = "gVal";
            gVal.Size = new Size(50, 23);
            gVal.TabIndex = 4;
            gVal.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // rVal
            // 
            rVal.Location = new Point(241, 37);
            rVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            rVal.Name = "rVal";
            rVal.Size = new Size(50, 23);
            rVal.TabIndex = 3;
            // 
            // label7
            // 
            label7.Location = new Point(188, 39);
            label7.Name = "label7";
            label7.Size = new Size(49, 21);
            label7.TabIndex = 0;
            label7.Text = "Red";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.Location = new Point(188, 123);
            label8.Name = "label8";
            label8.Size = new Size(48, 21);
            label8.TabIndex = 0;
            label8.Text = "Opacity";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // aVal
            // 
            aVal.Location = new Point(241, 121);
            aVal.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            aVal.Name = "aVal";
            aVal.Size = new Size(50, 23);
            aVal.TabIndex = 6;
            aVal.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(58, 11);
            label10.Name = "label10";
            label10.Size = new Size(53, 15);
            label10.TabIndex = 0;
            label10.Text = "Location";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(102, 39);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 0;
            label11.Text = "[0, 10]";
            // 
            // shortcutConfirm
            // 
            shortcutConfirm.AutoSize = true;
            shortcutConfirm.Location = new Point(12, 153);
            shortcutConfirm.Name = "shortcutConfirm";
            shortcutConfirm.Size = new Size(150, 15);
            shortcutConfirm.TabIndex = 0;
            shortcutConfirm.Text = "Shortcut saved on desktop!";
            shortcutConfirm.Visible = false;
            // 
            // hideInRecording
            // 
            hideInRecording.AutoSize = true;
            hideInRecording.CheckAlign = ContentAlignment.MiddleRight;
            hideInRecording.Location = new Point(27, 123);
            hideInRecording.Name = "hideInRecording";
            hideInRecording.Size = new Size(118, 19);
            hideInRecording.TabIndex = 10;
            hideInRecording.Text = "Hide in recording";
            hideInRecording.UseVisualStyleBackColor = true;
            // 
            // CrosshairConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 217);
            Controls.Add(hideInRecording);
            Controls.Add(label8);
            Controls.Add(aVal);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(bVal);
            Controls.Add(gVal);
            Controls.Add(rVal);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(startButton);
            Controls.Add(shortcutButton);
            Controls.Add(shortcutConfirm);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(yOffsetVal);
            Controls.Add(xOffsetVal);
            Controls.Add(sizeVal);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrosshairConfig";
            Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)sizeVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)xOffsetVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)yOffsetVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)bVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)gVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)rVal).EndInit();
            ((System.ComponentModel.ISupportInitialize)aVal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown sizeVal;
        private Label label2;
        private Label label3;
        private NumericUpDown xOffsetVal;
        private NumericUpDown yOffsetVal;
        private Button shortcutButton;
        private Button startButton;
        private Label label4;
        private Label label5;
        private Label label6;
        private NumericUpDown bVal;
        private NumericUpDown gVal;
        private NumericUpDown rVal;
        private Label label7;
        private Label label8;
        private NumericUpDown aVal;
        private Label label10;
        private Label label11;
        private Label shortcutConfirm;
        private CheckBox hideInRecording;
    }
}