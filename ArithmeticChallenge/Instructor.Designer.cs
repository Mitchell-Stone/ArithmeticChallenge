namespace ArithmeticChallenge
{
    partial class Instructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_firstNumber = new System.Windows.Forms.TextBox();
            this.tb_secondNumber = new System.Windows.Forms.TextBox();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.dd_operator = new System.Windows.Forms.ComboBox();
            this.dgv_questionsAsked = new System.Windows.Forms.DataGridView();
            this.dgv_correctAnswers = new System.Windows.Forms.DataGridView();
            this.dgv_incorrectAnswers = new System.Windows.Forms.DataGridView();
            this.btn_send = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.rtb_linkList = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionsAsked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_correctAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incorrectAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter question, then click Send.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Second Number:";
            // 
            // tb_firstNumber
            // 
            this.tb_firstNumber.Location = new System.Drawing.Point(143, 96);
            this.tb_firstNumber.Name = "tb_firstNumber";
            this.tb_firstNumber.Size = new System.Drawing.Size(100, 20);
            this.tb_firstNumber.TabIndex = 5;
            this.tb_firstNumber.TextChanged += new System.EventHandler(this.tb_firstNumber_TextChanged);
            // 
            // tb_secondNumber
            // 
            this.tb_secondNumber.Location = new System.Drawing.Point(143, 156);
            this.tb_secondNumber.Name = "tb_secondNumber";
            this.tb_secondNumber.Size = new System.Drawing.Size(100, 20);
            this.tb_secondNumber.TabIndex = 7;
            this.tb_secondNumber.TextChanged += new System.EventHandler(this.tb_secondNumber_TextChanged);
            // 
            // tb_answer
            // 
            this.tb_answer.Location = new System.Drawing.Point(143, 184);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.ReadOnly = true;
            this.tb_answer.Size = new System.Drawing.Size(100, 20);
            this.tb_answer.TabIndex = 8;
            // 
            // dd_operator
            // 
            this.dd_operator.FormattingEnabled = true;
            this.dd_operator.Location = new System.Drawing.Point(143, 127);
            this.dd_operator.Name = "dd_operator";
            this.dd_operator.Size = new System.Drawing.Size(100, 21);
            this.dd_operator.TabIndex = 9;
            this.dd_operator.SelectedIndexChanged += new System.EventHandler(this.dd_operator_SelectedIndexChanged);
            // 
            // dgv_questionsAsked
            // 
            this.dgv_questionsAsked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questionsAsked.Location = new System.Drawing.Point(303, 70);
            this.dgv_questionsAsked.Name = "dgv_questionsAsked";
            this.dgv_questionsAsked.Size = new System.Drawing.Size(455, 150);
            this.dgv_questionsAsked.TabIndex = 10;
            // 
            // dgv_correctAnswers
            // 
            this.dgv_correctAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_correctAnswers.Location = new System.Drawing.Point(385, 289);
            this.dgv_correctAnswers.Name = "dgv_correctAnswers";
            this.dgv_correctAnswers.Size = new System.Drawing.Size(373, 269);
            this.dgv_correctAnswers.TabIndex = 11;
            // 
            // dgv_incorrectAnswers
            // 
            this.dgv_incorrectAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_incorrectAnswers.Location = new System.Drawing.Point(394, 276);
            this.dgv_incorrectAnswers.Name = "dgv_incorrectAnswers";
            this.dgv_incorrectAnswers.Size = new System.Drawing.Size(364, 269);
            this.dgv_incorrectAnswers.TabIndex = 12;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(168, 210);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 13;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sort 1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Sort 2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(664, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Sort 3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Pre-Order";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 593);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(303, 593);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "In-Order";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(222, 593);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 20;
            this.button7.Text = "Display";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(512, 593);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 25;
            this.button8.Text = "Save";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(471, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Post-Order";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(431, 593);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "Dislpay";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(683, 593);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 39);
            this.label9.TabIndex = 27;
            this.label9.Text = "Instructor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Answer:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(497, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "List of incorrect answers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Binary Tree";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(460, 227);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 30;
            this.button10.Text = "Sort 3";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // rtb_linkList
            // 
            this.rtb_linkList.Location = new System.Drawing.Point(12, 276);
            this.rtb_linkList.Name = "rtb_linkList";
            this.rtb_linkList.Size = new System.Drawing.Size(366, 140);
            this.rtb_linkList.TabIndex = 31;
            this.rtb_linkList.Text = "";
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 637);
            this.Controls.Add(this.rtb_linkList);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.dgv_incorrectAnswers);
            this.Controls.Add(this.dgv_correctAnswers);
            this.Controls.Add(this.dgv_questionsAsked);
            this.Controls.Add(this.dd_operator);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.tb_secondNumber);
            this.Controls.Add(this.tb_firstNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Instructor";
            this.Text = "Instructor";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionsAsked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_correctAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_incorrectAnswers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_firstNumber;
        private System.Windows.Forms.TextBox tb_secondNumber;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.ComboBox dd_operator;
        private System.Windows.Forms.DataGridView dgv_questionsAsked;
        private System.Windows.Forms.DataGridView dgv_correctAnswers;
        private System.Windows.Forms.DataGridView dgv_incorrectAnswers;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.RichTextBox rtb_linkList;
    }
}

