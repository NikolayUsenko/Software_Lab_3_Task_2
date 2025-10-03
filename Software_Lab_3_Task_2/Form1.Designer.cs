namespace Software_Lab_3_Task_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Expression = new Label();
            Variables = new Label();
            ForX = new TextBox();
            ForY = new TextBox();
            ForZ = new TextBox();
            X = new Label();
            Y = new Label();
            Z = new Label();
            ResultText = new Label();
            Result = new TextBox();
            SuspendLayout();
            // 
            // Expression
            // 
            Expression.AutoSize = true;
            Expression.BackColor = SystemColors.GradientInactiveCaption;
            Expression.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Expression.Location = new Point(12, 22);
            Expression.Name = "Expression";
            Expression.Size = new Size(405, 74);
            Expression.TabIndex = 0;
            Expression.Text = "Вычисление выражения\nz · cos(y) + √(e · 7) - |x + cos(y)|";
            // 
            // Variables
            // 
            Variables.AutoSize = true;
            Variables.BackColor = SystemColors.GradientInactiveCaption;
            Variables.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Variables.Location = new Point(12, 122);
            Variables.Name = "Variables";
            Variables.Size = new Size(194, 37);
            Variables.TabIndex = 7;
            Variables.Text = "Переменные:";
            // 
            // ForX
            // 
            ForX.BackColor = SystemColors.GradientInactiveCaption;
            ForX.BorderStyle = BorderStyle.None;
            ForX.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForX.Location = new Point(70, 159);
            ForX.Name = "ForX";
            ForX.ReadOnly = true;
            ForX.Size = new Size(136, 37);
            ForX.TabIndex = 11;
            // 
            // ForY
            // 
            ForY.BackColor = SystemColors.GradientInactiveCaption;
            ForY.BorderStyle = BorderStyle.None;
            ForY.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForY.Location = new Point(70, 196);
            ForY.Name = "ForY";
            ForY.ReadOnly = true;
            ForY.Size = new Size(136, 37);
            ForY.TabIndex = 10;
            // 
            // ForZ
            // 
            ForZ.BackColor = SystemColors.GradientInactiveCaption;
            ForZ.BorderStyle = BorderStyle.None;
            ForZ.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForZ.Location = new Point(70, 233);
            ForZ.Name = "ForZ";
            ForZ.Size = new Size(136, 37);
            ForZ.TabIndex = 12;
            ForZ.TextChanged += ForZ_TextChanged;
            // 
            // X
            // 
            X.AutoSize = true;
            X.BackColor = SystemColors.GradientInactiveCaption;
            X.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            X.Location = new Point(12, 159);
            X.Name = "X";
            X.Size = new Size(63, 37);
            X.TabIndex = 8;
            X.Text = "X = ";
            // 
            // Y
            // 
            Y.AutoSize = true;
            Y.BackColor = SystemColors.GradientInactiveCaption;
            Y.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Y.Location = new Point(12, 196);
            Y.Name = "Y";
            Y.Size = new Size(62, 37);
            Y.TabIndex = 9;
            Y.Text = "Y = ";
            // 
            // Z
            // 
            Z.AutoSize = true;
            Z.BackColor = SystemColors.GradientInactiveCaption;
            Z.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Z.Location = new Point(12, 233);
            Z.Name = "Z";
            Z.Size = new Size(60, 37);
            Z.TabIndex = 4;
            Z.Text = "Z = ";
            // 
            // ResultText
            // 
            ResultText.AutoSize = true;
            ResultText.BackColor = SystemColors.GradientInactiveCaption;
            ResultText.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ResultText.Location = new Point(12, 298);
            ResultText.Name = "ResultText";
            ResultText.Size = new Size(151, 37);
            ResultText.TabIndex = 5;
            ResultText.Text = "Результат:";
            // 
            // Result
            // 
            Result.BackColor = SystemColors.GradientInactiveCaption;
            Result.BorderStyle = BorderStyle.None;
            Result.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Result.Location = new Point(162, 298);
            Result.Name = "Result";
            Result.ReadOnly = true;
            Result.Size = new Size(326, 37);
            Result.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(969, 589);
            Controls.Add(Expression);
            Controls.Add(Variables);
            Controls.Add(ForX);
            Controls.Add(ForY);
            Controls.Add(ForZ);
            Controls.Add(X);
            Controls.Add(Y);
            Controls.Add(Z);
            Controls.Add(ResultText);
            Controls.Add(Result);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Задание №2";
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label Expression;
        private Label Variables;
        private TextBox ForX;
        private TextBox ForY;
        private TextBox ForZ;
        private Label X;
        private Label Y;
        private Label Z;
        private Label ResultText;
        private TextBox Result;
    }
}
