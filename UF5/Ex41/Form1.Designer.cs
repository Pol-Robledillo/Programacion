namespace WinFormsApp1
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
            titleLabel = new Label();
            studentNameLabel = new Label();
            studentName = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            gradesGroup = new GroupBox();
            grade4 = new TextBox();
            grade3 = new TextBox();
            grade2 = new TextBox();
            grade1 = new TextBox();
            grade4Label = new Label();
            grade3Label = new Label();
            grade2Label = new Label();
            grade1Label = new Label();
            gradesAvgLabel = new Label();
            lowestGradeLabel = new Label();
            conditionLabel = new Label();
            gradesAvg = new Label();
            lowestGrade = new Label();
            condition = new Label();
            exitButton = new Button();
            gradesGroup.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(108, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(197, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "CONTROL DE PROMEDIO DE NOTAS";
            // 
            // studentNameLabel
            // 
            studentNameLabel.AutoSize = true;
            studentNameLabel.Location = new Point(12, 45);
            studentNameLabel.Name = "studentNameLabel";
            studentNameLabel.Size = new Size(58, 15);
            studentNameLabel.TabIndex = 1;
            studentNameLabel.Text = "ALUMNO";
            // 
            // studentName
            // 
            studentName.Location = new Point(12, 63);
            studentName.Name = "studentName";
            studentName.Size = new Size(156, 23);
            studentName.TabIndex = 2;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(12, 92);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "CALCULAR";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(93, 92);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 4;
            clearButton.Text = "LIMPIAR";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // gradesGroup
            // 
            gradesGroup.Controls.Add(grade4);
            gradesGroup.Controls.Add(grade3);
            gradesGroup.Controls.Add(grade2);
            gradesGroup.Controls.Add(grade1);
            gradesGroup.Controls.Add(grade4Label);
            gradesGroup.Controls.Add(grade3Label);
            gradesGroup.Controls.Add(grade2Label);
            gradesGroup.Controls.Add(grade1Label);
            gradesGroup.Location = new Point(201, 45);
            gradesGroup.Name = "gradesGroup";
            gradesGroup.Size = new Size(215, 70);
            gradesGroup.TabIndex = 6;
            gradesGroup.TabStop = false;
            gradesGroup.Text = "REGISTRO DE NOTAS";
            // 
            // grade4
            // 
            grade4.Location = new Point(162, 39);
            grade4.Name = "grade4";
            grade4.Size = new Size(46, 23);
            grade4.TabIndex = 7;
            grade4.Validating += grade4_Validating;
            // 
            // grade3
            // 
            grade3.Location = new Point(110, 39);
            grade3.Name = "grade3";
            grade3.Size = new Size(46, 23);
            grade3.TabIndex = 6;
            grade3.Validating += grade3_Validating;
            // 
            // grade2
            // 
            grade2.Location = new Point(58, 39);
            grade2.Name = "grade2";
            grade2.Size = new Size(46, 23);
            grade2.TabIndex = 5;
            grade2.Validating += grade2_Validating;
            // 
            // grade1
            // 
            grade1.Location = new Point(6, 39);
            grade1.Name = "grade1";
            grade1.Size = new Size(46, 23);
            grade1.TabIndex = 4;
            grade1.Validating += grade1_Validating;
            // 
            // grade4Label
            // 
            grade4Label.AutoSize = true;
            grade4Label.Location = new Point(162, 21);
            grade4Label.Name = "grade4Label";
            grade4Label.Size = new Size(46, 15);
            grade4Label.TabIndex = 3;
            grade4Label.Text = "NOTA 4";
            // 
            // grade3Label
            // 
            grade3Label.AutoSize = true;
            grade3Label.Location = new Point(110, 21);
            grade3Label.Name = "grade3Label";
            grade3Label.Size = new Size(46, 15);
            grade3Label.TabIndex = 2;
            grade3Label.Text = "NOTA 3";
            // 
            // grade2Label
            // 
            grade2Label.AutoSize = true;
            grade2Label.Location = new Point(58, 21);
            grade2Label.Name = "grade2Label";
            grade2Label.Size = new Size(46, 15);
            grade2Label.TabIndex = 1;
            grade2Label.Text = "NOTA 2";
            // 
            // grade1Label
            // 
            grade1Label.AutoSize = true;
            grade1Label.Location = new Point(6, 21);
            grade1Label.Name = "grade1Label";
            grade1Label.Size = new Size(46, 15);
            grade1Label.TabIndex = 0;
            grade1Label.Text = "NOTA 1";
            // 
            // gradesAvgLabel
            // 
            gradesAvgLabel.AutoSize = true;
            gradesAvgLabel.Location = new Point(12, 144);
            gradesAvgLabel.Name = "gradesAvgLabel";
            gradesAvgLabel.Size = new Size(123, 15);
            gradesAvgLabel.TabIndex = 7;
            gradesAvgLabel.Text = "PROMEDIO DE NOTAS";
            // 
            // lowestGradeLabel
            // 
            lowestGradeLabel.AutoSize = true;
            lowestGradeLabel.Location = new Point(12, 168);
            lowestGradeLabel.Name = "lowestGradeLabel";
            lowestGradeLabel.Size = new Size(96, 15);
            lowestGradeLabel.TabIndex = 8;
            lowestGradeLabel.Text = "NOTA MAS BAJA";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new Point(12, 192);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new Size(73, 15);
            conditionLabel.TabIndex = 9;
            conditionLabel.Text = "CONDICION";
            // 
            // gradesAvg
            // 
            gradesAvg.AutoSize = true;
            gradesAvg.Location = new Point(141, 144);
            gradesAvg.Name = "gradesAvg";
            gradesAvg.Size = new Size(28, 15);
            gradesAvg.TabIndex = 10;
            gradesAvg.Text = "0.00";
            // 
            // lowestGrade
            // 
            lowestGrade.AutoSize = true;
            lowestGrade.Location = new Point(141, 168);
            lowestGrade.Name = "lowestGrade";
            lowestGrade.Size = new Size(28, 15);
            lowestGrade.TabIndex = 11;
            lowestGrade.Text = "0.00";
            // 
            // condition
            // 
            condition.AutoSize = true;
            condition.Location = new Point(141, 192);
            condition.Name = "condition";
            condition.Size = new Size(12, 15);
            condition.TabIndex = 12;
            condition.Text = "?";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(341, 204);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 13;
            exitButton.Text = "SALIR";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 239);
            Controls.Add(exitButton);
            Controls.Add(condition);
            Controls.Add(lowestGrade);
            Controls.Add(gradesAvg);
            Controls.Add(conditionLabel);
            Controls.Add(lowestGradeLabel);
            Controls.Add(gradesAvgLabel);
            Controls.Add(gradesGroup);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(studentName);
            Controls.Add(studentNameLabel);
            Controls.Add(titleLabel);
            Name = "Form1";
            Text = "Form1";
            gradesGroup.ResumeLayout(false);
            gradesGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label studentNameLabel;
        private TextBox studentName;
        private Button calculateButton;
        private Button clearButton;
        private GroupBox gradesGroup;
        private Label grade1Label;
        private Label grade2Label;
        private TextBox grade4;
        private TextBox grade3;
        private TextBox grade2;
        private TextBox grade1;
        private Label grade4Label;
        private Label grade3Label;
        private Label gradesAvgLabel;
        private Label lowestGradeLabel;
        private Label conditionLabel;
        private Label gradesAvg;
        private Label lowestGrade;
        private Label condition;
        private Button exitButton;
    }
}
