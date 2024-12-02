namespace CreatingTxtFile
{
    partial class FormLab1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtInput1 = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // txtInput1
            // 
            txtInput1.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInput1.Location = new Point(36, 44);
            txtInput1.Multiline = true;
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(239, 66);
            txtInput1.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(80, 154);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(152, 46);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // FormLab1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 239);
            Controls.Add(btnCreate);
            Controls.Add(txtInput1);
            Name = "FormLab1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private Button btnCreate;
    }
}
