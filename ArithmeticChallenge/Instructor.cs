using ArithmeticChallenge.Controllers;
using ArithmeticChallenge.NodeFunctions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticChallenge
{
    public partial class Instructor : Form
    {
        //list of all current equations
        List<EquationProperties> equations = new List<EquationProperties>();

        EquationNodeList equationNodeList = new EquationNodeList();

        //symbols used in the dropdown to select for calculationss
        string[] operators = { "+", "-", "x", "/" };

        

        public Instructor()
        {
            InitializeComponent();
            dd_operator.DataSource = operators;

            LoadQuestionsDataGridView();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            EquationProperties equation = new EquationProperties()
            {
                FirstNumber = Convert.ToInt32(tb_firstNumber.Text),
                SecondNumber = Convert.ToInt32(tb_secondNumber.Text),
                Symbol = dd_operator.Text,
                Result = Convert.ToInt32(tb_answer.Text)
            };
            equations.Add(equation);

            equationNodeList.AddEquationNode(new EquationNode(equation));

            StringBuilder sb = new StringBuilder();

            if (rtb_linkList.Text == "")
            {
                sb.Append("Head <-> ");
                sb.Append(equationNodeList.getCurrentNode().NodeToString());
            }
            else
            {
                sb.Append(rtb_linkList.Text);
                sb.Append(" <-> ");
                sb.Append(equationNodeList.getCurrentNode().NodeToString());
            }

            rtb_linkList.Text = sb.ToString();

            RefreshResultDatagrid();

        }

        //loads the data grid view and allocates the data source values to the correct columns
        public void LoadQuestionsDataGridView()
        {
            dgv_questionsAsked.AutoGenerateColumns = false;
            dgv_questionsAsked.DataSource = equations;

            DataGridViewTextBoxColumn columnFirst = new DataGridViewTextBoxColumn();
            columnFirst.DataPropertyName = "FirstNumber";
            columnFirst.Name = "First";
            dgv_questionsAsked.Columns.Add(columnFirst);

            DataGridViewTextBoxColumn columnOperator = new DataGridViewTextBoxColumn();
            columnOperator.DataPropertyName = "Symbol";
            columnOperator.Name = "Operator";
            dgv_questionsAsked.Columns.Add(columnOperator);

            DataGridViewTextBoxColumn columnSecond = new DataGridViewTextBoxColumn();
            columnSecond.DataPropertyName = "SecondNumber";
            columnSecond.Name = "Second";
            dgv_questionsAsked.Columns.Add(columnSecond);

            DataGridViewTextBoxColumn columnResult = new DataGridViewTextBoxColumn();
            columnResult.DataPropertyName = "Result";
            columnResult.Name = "Result";
            dgv_questionsAsked.Columns.Add(columnResult);
        }

        //refreshes the data grid when a new object is added to the data source
        private void RefreshResultDatagrid()
        {
            dgv_questionsAsked.DataSource = null;

            dgv_questionsAsked.DataSource = equations;
        }

        #region Update result text box when calculation is changed
        private void dd_operator_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_answer.Text = InstructorController.PerformCalculation(
                tb_firstNumber.Text,
                tb_secondNumber.Text,
                dd_operator.Text).ToString();
        }

        private void tb_firstNumber_TextChanged(object sender, EventArgs e)
        {
            tb_answer.Text = InstructorController.PerformCalculation(
                tb_firstNumber.Text,
                tb_secondNumber.Text,
                dd_operator.Text).ToString();
        }

        private void tb_secondNumber_TextChanged(object sender, EventArgs e)
        {
            tb_answer.Text = InstructorController.PerformCalculation(
                tb_firstNumber.Text,
                tb_secondNumber.Text,
                dd_operator.Text).ToString();
        }
        #endregion
    }
}
