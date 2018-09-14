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
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_printPreOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_savePreOrder = new System.Windows.Forms.Button();
            this.btn_saveInOrder = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_printInOrder = new System.Windows.Forms.Button();
            this.btn_savePostOrder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_printPostOrder = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtb_binaryTree = new System.Windows.Forms.RichTextBox();
            this.rtb_linkList = new System.Windows.Forms.RichTextBox();
            this.lbl_clientCount = new System.Windows.Forms.Label();
            this.btn_sortOne = new System.Windows.Forms.Button();
            this.btn_sortTwo = new System.Windows.Forms.Button();
            this.btn_sortThree = new System.Windows.Forms.Button();
            this.btn_sortFour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questionsAsked)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a question, then click Send.";
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
            this.tb_firstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_firstNumber.Location = new System.Drawing.Point(143, 96);
            this.tb_firstNumber.Name = "tb_firstNumber";
            this.tb_firstNumber.Size = new System.Drawing.Size(100, 22);
            this.tb_firstNumber.TabIndex = 5;
            this.tb_firstNumber.TextChanged += new System.EventHandler(this.tb_firstNumber_TextChanged);
            // 
            // tb_secondNumber
            // 
            this.tb_secondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_secondNumber.Location = new System.Drawing.Point(143, 156);
            this.tb_secondNumber.Name = "tb_secondNumber";
            this.tb_secondNumber.Size = new System.Drawing.Size(100, 22);
            this.tb_secondNumber.TabIndex = 7;
            this.tb_secondNumber.TextChanged += new System.EventHandler(this.tb_secondNumber_TextChanged);
            // 
            // tb_answer
            // 
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(143, 184);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.ReadOnly = true;
            this.tb_answer.Size = new System.Drawing.Size(100, 22);
            this.tb_answer.TabIndex = 8;
            // 
            // dd_operator
            // 
            this.dd_operator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd_operator.FormattingEnabled = true;
            this.dd_operator.Location = new System.Drawing.Point(143, 127);
            this.dd_operator.Name = "dd_operator";
            this.dd_operator.Size = new System.Drawing.Size(100, 24);
            this.dd_operator.TabIndex = 9;
            this.dd_operator.SelectedIndexChanged += new System.EventHandler(this.dd_operator_SelectedIndexChanged);
            // 
            // dgv_questionsAsked
            // 
            this.dgv_questionsAsked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questionsAsked.Location = new System.Drawing.Point(303, 70);
            this.dgv_questionsAsked.Name = "dgv_questionsAsked";
            this.dgv_questionsAsked.Size = new System.Drawing.Size(455, 172);
            this.dgv_questionsAsked.TabIndex = 10;
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
            // btn_printPreOrder
            // 
            this.btn_printPreOrder.Location = new System.Drawing.Point(8, 593);
            this.btn_printPreOrder.Name = "btn_printPreOrder";
            this.btn_printPreOrder.Size = new System.Drawing.Size(80, 32);
            this.btn_printPreOrder.TabIndex = 17;
            this.btn_printPreOrder.Text = "Display";
            this.btn_printPreOrder.UseVisualStyleBackColor = true;
            this.btn_printPreOrder.Click += new System.EventHandler(this.btn_printPreOrder_Click);
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
            // btn_savePreOrder
            // 
            this.btn_savePreOrder.Location = new System.Drawing.Point(94, 593);
            this.btn_savePreOrder.Name = "btn_savePreOrder";
            this.btn_savePreOrder.Size = new System.Drawing.Size(86, 32);
            this.btn_savePreOrder.TabIndex = 19;
            this.btn_savePreOrder.Text = "Save";
            this.btn_savePreOrder.UseVisualStyleBackColor = true;
            this.btn_savePreOrder.Click += new System.EventHandler(this.btn_savePreOrder_Click);
            // 
            // btn_saveInOrder
            // 
            this.btn_saveInOrder.Location = new System.Drawing.Point(303, 593);
            this.btn_saveInOrder.Name = "btn_saveInOrder";
            this.btn_saveInOrder.Size = new System.Drawing.Size(84, 32);
            this.btn_saveInOrder.TabIndex = 22;
            this.btn_saveInOrder.Text = "Save";
            this.btn_saveInOrder.UseVisualStyleBackColor = true;
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
            // btn_printInOrder
            // 
            this.btn_printInOrder.Location = new System.Drawing.Point(216, 593);
            this.btn_printInOrder.Name = "btn_printInOrder";
            this.btn_printInOrder.Size = new System.Drawing.Size(81, 32);
            this.btn_printInOrder.TabIndex = 20;
            this.btn_printInOrder.Text = "Display";
            this.btn_printInOrder.UseVisualStyleBackColor = true;
            this.btn_printInOrder.Click += new System.EventHandler(this.btn_printInOrder_Click);
            // 
            // btn_savePostOrder
            // 
            this.btn_savePostOrder.Location = new System.Drawing.Point(512, 593);
            this.btn_savePostOrder.Name = "btn_savePostOrder";
            this.btn_savePostOrder.Size = new System.Drawing.Size(84, 32);
            this.btn_savePostOrder.TabIndex = 25;
            this.btn_savePostOrder.Text = "Save";
            this.btn_savePostOrder.UseVisualStyleBackColor = true;
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
            // btn_printPostOrder
            // 
            this.btn_printPostOrder.Location = new System.Drawing.Point(423, 593);
            this.btn_printPostOrder.Name = "btn_printPostOrder";
            this.btn_printPostOrder.Size = new System.Drawing.Size(83, 32);
            this.btn_printPostOrder.TabIndex = 23;
            this.btn_printPostOrder.Text = "Dislpay";
            this.btn_printPostOrder.UseVisualStyleBackColor = true;
            this.btn_printPostOrder.Click += new System.EventHandler(this.btn_printPostOrder_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(641, 593);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 32);
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
            this.label10.Location = new System.Drawing.Point(5, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "List of incorrect answers";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 396);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Binary Tree";
            // 
            // rtb_binaryTree
            // 
            this.rtb_binaryTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_binaryTree.Location = new System.Drawing.Point(8, 430);
            this.rtb_binaryTree.Name = "rtb_binaryTree";
            this.rtb_binaryTree.ReadOnly = true;
            this.rtb_binaryTree.Size = new System.Drawing.Size(750, 117);
            this.rtb_binaryTree.TabIndex = 31;
            this.rtb_binaryTree.Text = "";
            // 
            // rtb_linkList
            // 
            this.rtb_linkList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_linkList.Location = new System.Drawing.Point(8, 293);
            this.rtb_linkList.Name = "rtb_linkList";
            this.rtb_linkList.ReadOnly = true;
            this.rtb_linkList.Size = new System.Drawing.Size(750, 100);
            this.rtb_linkList.TabIndex = 32;
            this.rtb_linkList.Text = "";
            // 
            // lbl_clientCount
            // 
            this.lbl_clientCount.AutoSize = true;
            this.lbl_clientCount.Location = new System.Drawing.Point(13, 632);
            this.lbl_clientCount.Name = "lbl_clientCount";
            this.lbl_clientCount.Size = new System.Drawing.Size(0, 13);
            this.lbl_clientCount.TabIndex = 33;
            // 
            // btn_sortOne
            // 
            this.btn_sortOne.Location = new System.Drawing.Point(337, 248);
            this.btn_sortOne.Name = "btn_sortOne";
            this.btn_sortOne.Size = new System.Drawing.Size(75, 23);
            this.btn_sortOne.TabIndex = 34;
            this.btn_sortOne.Text = "Sort 1";
            this.btn_sortOne.UseVisualStyleBackColor = true;
            this.btn_sortOne.Click += new System.EventHandler(this.btn_sortOne_Click);
            // 
            // btn_sortTwo
            // 
            this.btn_sortTwo.Location = new System.Drawing.Point(445, 248);
            this.btn_sortTwo.Name = "btn_sortTwo";
            this.btn_sortTwo.Size = new System.Drawing.Size(75, 23);
            this.btn_sortTwo.TabIndex = 35;
            this.btn_sortTwo.Text = "Sort 2";
            this.btn_sortTwo.UseVisualStyleBackColor = true;
            this.btn_sortTwo.Click += new System.EventHandler(this.btn_sortTwo_Click);
            // 
            // btn_sortThree
            // 
            this.btn_sortThree.Location = new System.Drawing.Point(553, 248);
            this.btn_sortThree.Name = "btn_sortThree";
            this.btn_sortThree.Size = new System.Drawing.Size(75, 23);
            this.btn_sortThree.TabIndex = 36;
            this.btn_sortThree.Text = "Sort 3";
            this.btn_sortThree.UseVisualStyleBackColor = true;
            this.btn_sortThree.Click += new System.EventHandler(this.btn_sortThree_Click);
            // 
            // btn_sortFour
            // 
            this.btn_sortFour.Location = new System.Drawing.Point(658, 248);
            this.btn_sortFour.Name = "btn_sortFour";
            this.btn_sortFour.Size = new System.Drawing.Size(75, 23);
            this.btn_sortFour.TabIndex = 37;
            this.btn_sortFour.Text = "Sort 4";
            this.btn_sortFour.UseVisualStyleBackColor = true;
            this.btn_sortFour.Click += new System.EventHandler(this.btn_sortFour_Click);
            // 
            // Instructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 652);
            this.Controls.Add(this.btn_sortFour);
            this.Controls.Add(this.btn_sortThree);
            this.Controls.Add(this.btn_sortTwo);
            this.Controls.Add(this.btn_sortOne);
            this.Controls.Add(this.lbl_clientCount);
            this.Controls.Add(this.rtb_linkList);
            this.Controls.Add(this.rtb_binaryTree);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_savePostOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_printPostOrder);
            this.Controls.Add(this.btn_saveInOrder);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_printInOrder);
            this.Controls.Add(this.btn_savePreOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_printPreOrder);
            this.Controls.Add(this.btn_send);
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
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_printPreOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_savePreOrder;
        private System.Windows.Forms.Button btn_saveInOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_printInOrder;
        private System.Windows.Forms.Button btn_savePostOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_printPostOrder;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtb_binaryTree;
        private System.Windows.Forms.RichTextBox rtb_linkList;
        private System.Windows.Forms.Label lbl_clientCount;
        private System.Windows.Forms.Button btn_sortOne;
        private System.Windows.Forms.Button btn_sortTwo;
        private System.Windows.Forms.Button btn_sortThree;
        private System.Windows.Forms.Button btn_sortFour;
    }
}

