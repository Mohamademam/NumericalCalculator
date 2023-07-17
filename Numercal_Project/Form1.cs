using MathNet.Symbolics;
using org.mariuszgromada.math.mxparser;
using System;
using System.Windows.Forms;
using Expression = org.mariuszgromada.math.mxparser.Expression;
using Function = org.mariuszgromada.math.mxparser.Function;

namespace Numerical_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FROPdashbourd_btn_Click(object sender, EventArgs e)
        {

            FINDING_ROOTS_OF_POLYNOMIALS.BringToFront();
        }

        private void Return_to_Dashboard_btn_Click(object sender, EventArgs e)
        {
            Dashboard.BringToFront();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AboutUS.BringToFront();
        }

        private void Signout_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //--------------------------------------------Finding root Panel------------------------------------//




        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void enterEstmatedError_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BisectionMethod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------------//

        private void enterFunc_textbox1_Focus(object sender, EventArgs e)
        {
            if (enterFunc_textbox1.Text == "Please Enter the Function")
                enterFunc_textbox1.Text = "";
        }

        private void enterFunc_textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterFunc_textbox1.Text))
                enterFunc_textbox1.Text = "Please Enter the Function";
        }

        private void enterXLvalue_Textbox1_Focus(object sender, EventArgs e)
        {
            if (enterXLvalue_Textbox1.Text == "Please Enter the Value of XL")
                enterXLvalue_Textbox1.Text = "";
        }

        private void enterXLvalue_Textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterXLvalue_Textbox1.Text))
                enterXLvalue_Textbox1.Text = "Please Enter the Value of XL";
        }

        private void enterXu_textbox1_Focus(object sender, EventArgs e)
        {
            if (enterXu_textbox1.Text == "Please Enter the Value of Xu")
                enterXu_textbox1.Text = "";
        }

        private void enterXu_textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterXu_textbox1.Text))
                enterXu_textbox1.Text = "Please Enter the Value of Xu";
        }

        private void enterEstmatedError_textbox1_Focus(object sender, EventArgs e)
        {
            if (enterEstmatedError1.Text == "Please Enter the Value of Estimated Error")
                enterEstmatedError1.Text = "";
        }

        private void enterEstmatedError_textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterEstmatedError1.Text))
                enterEstmatedError1.Text = "Please Enter the Value of Estimated Error";
        }

        private void Finding_Root_Bisection_Click(object sender, EventArgs e)
        {
            BisectionMethod.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset1_Click(this, EventArgs.Empty);
            Reset2_Click(this, EventArgs.Empty);
            Reset3_Click(this, EventArgs.Empty);
            Reset4_Click(this, EventArgs.Empty);
            Reset5_Click(this, EventArgs.Empty);
            FINDING_ROOTS_OF_POLYNOMIALS.BringToFront();
        }

        private void Finding_Root_FalsePostion_Click(object sender, EventArgs e)
        {
            FalsePositionMethod.BringToFront();
        }

        private void Finding_Root_SimpleFixedPoint_Click(object sender, EventArgs e)
        {
            SimpleFixedPoint.BringToFront();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
        private void enterFunc_textbox3_Focus(object sender, EventArgs e)
        {
            if (enterFunc_textbox3.Text == "Please Enter the Function")
                enterFunc_textbox3.Text = "";
        }

        private void enterFunc_textbox3_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterFunc_textbox3.Text))
                enterFunc_textbox3.Text = "Please Enter the Function";
        }
        private void enterEstmatedError3_textbox1_Focus(object sender, EventArgs e)
        {
            if (enterEstmatedError3.Text == "Please Enter the Value of Estimated Error")
                enterEstmatedError3.Text = "";
        }

        private void enterEstmatedError3_textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterEstmatedError3.Text))
                enterEstmatedError3.Text = "Please Enter the Value of Estimated Error";
        }
        private void textBoxEnterXoV_Focus(object sender, EventArgs e)
        {
            if (textBoxEnterXoV.Text == "Please Enter the Value of Xo")
                textBoxEnterXoV.Text = "";
        }

        private void textBoxEnterXoV_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEnterXoV.Text))
                textBoxEnterXoV.Text = "Please Enter the Value of Xo";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Newton.BringToFront();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Secant_Method.BringToFront();
        }

        private void Newton_Paint(object sender, PaintEventArgs e)
        {

        }
        private void enterFunc_textbox2_Focus(object sender, EventArgs e)
        {
            if (enterFunc_textbox2.Text == "Please Enter the Function")
                enterFunc_textbox2.Text = "";
        }

        private void enterFunc_textbox2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterFunc_textbox2.Text))
                enterFunc_textbox2.Text = "Please Enter the Function";
        }

        private void enterXLvalue_Textbox2_Focus(object sender, EventArgs e)
        {
            if (enterXLvalue_Textbox2.Text == "Please Enter the Value of XL")
                enterXLvalue_Textbox2.Text = "";
        }

        private void enterXLvalue_Textbox2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterXLvalue_Textbox2.Text))
                enterXLvalue_Textbox2.Text = "Please Enter the Value of XL";
        }

        private void enterXu_textbox2_Focus(object sender, EventArgs e)
        {
            if (enterXu_textbox2.Text == "Please Enter the Value of Xu")
                enterXu_textbox2.Text = "";
        }

        private void eenterXu_textbox2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterXu_textbox2.Text))
                enterXu_textbox2.Text = "Please Enter the Value of Xu";
        }

        private void enterEstmatedError2_Focus(object sender, EventArgs e)
        {
            if (enterEstmatedError2.Text == "Please Enter the Value of Estimated Error")
                enterEstmatedError2.Text = "";
        }

        private void enterEstmatedError2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterEstmatedError2.Text))
                enterEstmatedError2.Text = "Please Enter the Value of Estimated Error";
        }
        private void enterfunc2_textbox3_Focus(object sender, EventArgs e)
        {
            if (enterfunc2.Text == "Please Enter the Function")
                enterfunc2.Text = "";
        }

        private void enterFunc2_textbox3_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterfunc2.Text))
                enterfunc2.Text = "Please Enter the Function";
        }
        private void EnterXoValueTextBox_Focus(object sender, EventArgs e)
        {
            if (EnterXoValueTextBox.Text == "Please Enter the Value of Xo")
                EnterXoValueTextBox.Text = "";
        }

        private void EnterXoValueTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EnterXoValueTextBox.Text))
                EnterXoValueTextBox.Text = "Please Enter the Value of Xo";
        }
        private void enterError2_textbox1_Focus(object sender, EventArgs e)
        {
            if (enterError2.Text == "Please Enter the Value of Estimated Error")
                enterError2.Text = "";
        }

        private void enterError2_textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterError2.Text))
                enterError2.Text = "Please Enter the Value of Estimated Error";
        }
        private void enterXoValue2_Focus(object sender, EventArgs e)
        {
            if (enterXoValue2.Text == "Please Enter the Value of Xo")
                enterXoValue2.Text = "";
        }

        private void enterXoValue2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterXoValue2.Text))
                enterXoValue2.Text = "Please Enter the Value of Xo";
        }

        private void enterFunc5_textbox3_Focus(object sender, EventArgs e)
        {
            if (enterFunc5.Text == "Please Enter the Function")
                enterFunc5.Text = "";
        }

        private void enterFunc5_textbox3_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterFunc5.Text))
                enterFunc5.Text = "Please Enter the Function";
        }
        private void enterError5_textbox1_Focus(object sender, EventArgs e)
        {
            if (enterError5.Text == "Please Enter the Value of Estimated Error")
                enterError5.Text = "";
        }

        private void enterError5_textbox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterError5.Text))
                enterError5.Text = "Please Enter the Value of Estimated Error";
        }
        private void enterXi5_Focus(object sender, EventArgs e)
        {
            if (enterXi_1.Text == "Please Enter the Value of Xi - 1")
                enterXi_1.Text = "";
        }

        private void enterXi5_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(enterXi_1.Text))
                enterXi_1.Text = "Please Enter the Value of Xi - 1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            linear_algebraic_equation.BringToFront();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Dashboard.BringToFront();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ResetCramer_Click(this, EventArgs.Empty);
            ResetGuass_Click(this, EventArgs.Empty);
            ResetLU_Click(this, EventArgs.Empty);
            ResetGJ_Click(this, EventArgs.Empty);
            linear_algebraic_equation.BringToFront();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            GuassElimination.BringToFront();
        }

        private void Reset1_Click(object sender, EventArgs e)
        {
            enterFunc_textbox1.Text = "Please Enter the Function";
            enterXLvalue_Textbox1.Text = "Please Enter the Value of XL";
            enterXu_textbox1.Text = "Please Enter the Value of Xu";
            enterEstmatedError1.Text = "Please Enter the Value of Estimated Error";
            rootBisection.Text = "";
            ErrorBisection.Text = "";
            BisectionDataGridView.Rows.Clear();
        }

        private void Reset2_Click(object sender, EventArgs e)
        {
            enterFunc_textbox3.Text = "Please Enter the Function";
            enterEstmatedError3.Text = "Please Enter the Value of Estimated Error";
            EnterXoValueTextBox.Text = "Please Enter the Value of Xo";
            RootSimpleFixed.Text = "";
            ErrorSimpleFixed.Text = "";
            SimpleFixedPointDGV.Rows.Clear();
        }

        private void Reset3_Click(object sender, EventArgs e)
        {
            enterFunc_textbox2.Text = "Please Enter the Function";
            enterEstmatedError2.Text = "Please Enter the Value of Estimated Error";
            enterXLvalue_Textbox2.Text = "Please Enter the Value of XL";
            enterXu_textbox2.Text = "Please Enter the Value of Xu";
            RootFalsePosition.Text = "";
            ErrorFalsePosition.Text = "";
            FalsePositionDGV.Rows.Clear();
        }

        private void Reset4_Click(object sender, EventArgs e)
        {
            enterfunc2.Text = "Please Enter the Function";
            enterXoValue2.Text = "Please Enter the Value of Xi";
            enterError2.Text = "Please Enter the Value of Estimated Error";
            RootNewton.Text = "";
            ErrorNewton.Text = "";
            NewtonDGV.Rows.Clear();
        }

        private void Reset5_Click(object sender, EventArgs e)
        {
            enterFunc5.Text = "Please Enter the Function";
            enterXi_1.Text = "Please Enter the Value of Xi - 1";
            enterError5.Text = "Please Enter the Value of Estimated Error";
            textBoxEnterXoV.Text = "Please Enter the Value of Xo";
            RootSecant.Text = "";
            errorSecant.Text = "";
            SecantDGV.Rows.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            LU_Decomposition.BringToFront();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            CramerRule.BringToFront();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            GaussJordan.BringToFront();
        }

        //------------------------------Finding Root of polynomial Functions-----------------------------------------------//

        public double f(string func, string x)
        {
            string s = "f(x)=";
            string ss = "x=";
            Function fn = new Function(s + func);
            Argument a = new Argument(ss + x);
            Expression e1 = new Expression("f(x)", fn, a);
            return e1.calculate();
        }

        private double fDash(double x)
        {
            var expressionString = enterfunc2.Text;
            var symbolExpr = SymbolicExpression.Parse(expressionString);
            var derivative = symbolExpr.Differentiate("x");
            var lambda = derivative.Compile("x");
            return lambda(x);
        }

        private void solveBisection_Click(object sender, EventArgs e)
        {
            BisectionDataGridView.Rows.Clear();
            double Xl, Xu, error, XrOld, iter = 0, Xr = 0; ;
            string func;
            try
            {
                func = enterFunc_textbox1.Text;
                Xl = Double.Parse(enterXLvalue_Textbox1.Text);
                Xu = Double.Parse(enterXu_textbox1.Text);

                foreach (DataGridViewColumn col in BisectionDataGridView.Columns)
                    col.DefaultCellStyle.Format = "F3";
                if (f(func, Xl.ToString()) * f(func, Xu.ToString()) > 0)
                {
                    MessageBox.Show("No Root in this Range");
                    return;
                }
                else
                {
                    do
                    {
                        XrOld = Xr;
                        Xr = (Xl + Xu) / 2;
                        error = Math.Abs((Xr - XrOld) / Xr) * 100;
                        if (iter == 0)
                            BisectionDataGridView.Rows.Add(iter, Xl, f(func, Xl.ToString()), Xu, f(func, Xu.ToString()), Xr, f(func, Xr.ToString()), "--");
                        else
                            BisectionDataGridView.Rows.Add(iter, Xl, f(func, Xl.ToString()), Xu, f(func, Xu.ToString()), Xr, f(func, Xr.ToString()), error);

                        if (f(func, Xr.ToString()) * f(func, Xl.ToString()) > 0)
                            Xl = Xr;
                        else
                            Xu = Xr;
                        iter++;
                    } while (error >= Double.Parse(enterEstmatedError1.Text));
                    rootBisection.Text = Xr.ToString("F3");
                    ErrorBisection.Text = error.ToString("F3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void SolveFalsePosition_Click(object sender, EventArgs e)
        {
            FalsePositionDGV.Rows.Clear();
            double Xl, Xu, error = 0, Xr = 0, XrOld, iter = 0;
            string func;
            try
            {
                func = enterFunc_textbox2.Text;
                Xl = Double.Parse(enterXLvalue_Textbox2.Text);
                Xu = Double.Parse(enterXu_textbox2.Text);
                foreach (DataGridViewColumn col in FalsePositionDGV.Columns)
                    col.DefaultCellStyle.Format = "F3";
                if (f(func, Xl.ToString()) * f(func, Xu.ToString()) > 0)
                {
                    MessageBox.Show("No Root in this Range");
                    return;
                }
                else
                {
                    do
                    {
                        XrOld = Xr;
                        Xr = Xu - (f(func, Xu.ToString()) * (Xl - Xu)) / (f(func, Xl.ToString()) - f(func, Xu.ToString()));
                        error = Math.Abs((Xr - XrOld) / Xr) * 100;
                        if (iter == 0)
                            FalsePositionDGV.Rows.Add(iter, Xl, f(func, Xl.ToString()), Xu, f(func, Xu.ToString()), Xr, f(func, Xr.ToString()), "--");
                        else
                            FalsePositionDGV.Rows.Add(iter, Xl, f(func, Xl.ToString()), Xu, f(func, Xu.ToString()), Xr, f(func, Xr.ToString()), error);

                        if (f(func, Xl.ToString()) * f(func, Xr.ToString()) > 0)
                            Xl = Xr;
                        else
                            Xu = Xr;
                        iter++;
                    } while (error >= Double.Parse(enterEstmatedError2.Text) || iter == 0);

                    RootFalsePosition.Text = Xr.ToString("F3");
                    ErrorFalsePosition.Text = error.ToString("F3");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void SolveSimpleFixedPoint_Click(object sender, EventArgs e)
        {
            SimpleFixedPointDGV.Rows.Clear();
            double Xi, iter = 0;
            double XiPlus1 = 0;
            double error = 0;
            double eps = 0;
            string func;
            try
            {
                func = enterFunc_textbox3.Text;
                Xi = Double.Parse(EnterXoValueTextBox.Text);
                eps = Double.Parse(enterEstmatedError3.Text);
                foreach (DataGridViewColumn col in SimpleFixedPointDGV.Columns)
                    col.DefaultCellStyle.Format = "F3";
                do
                {
                    XiPlus1 = f(func, Xi.ToString());
                    error = Math.Abs((XiPlus1 - Xi) / XiPlus1) * 100;
                    if (iter == 0)
                        SimpleFixedPointDGV.Rows.Add(iter, Xi, "--");
                    else
                        SimpleFixedPointDGV.Rows.Add(iter, Xi, error);
                    Xi = XiPlus1;
                    iter++;
                } while (error >= eps);

                SimpleFixedPointDGV.Rows.Add(iter, Xi, error);
                RootSimpleFixed.Text = Xi.ToString("F3");
                ErrorSimpleFixed.Text = error.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void solveNewtonMethod_Click(object sender, EventArgs e)
        {
            NewtonDGV.Rows.Clear();
            double iter = 0, error = 0, x, X0, xplus, eps = Double.Parse(enterError2.Text);
            string func = enterfunc2.Text;
            X0 = Double.Parse(enterXoValue2.Text);
            //try
            //{
                x = X0;
                do
                {
                    xplus = x - (f(func, x.ToString()) / fDash(x));
                    error = Math.Abs((xplus - x) / xplus) * 100;
                    NewtonDGV.Rows.Add(iter, x, f(func, x.ToString()), fDash(x), error);
                    x = xplus;
                    iter++;
                } while (error >= eps);
                RootNewton.Text = x.ToString();
                ErrorNewton.Text = error.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void SolveSecantMethod_Click(object sender, EventArgs e)
        {
            SecantDGV.Rows.Clear();
            double iter = 0, error = 0, Ximin1, X0, temp, XiPlus1;
            string func;
            try
            {
                func = enterFunc5.Text;
                X0 = Double.Parse(textBoxEnterXoV.Text);
                Ximin1 = Double.Parse(enterXi_1.Text);
                foreach (DataGridViewColumn col in SecantDGV.Columns)
                    col.DefaultCellStyle.Format = "F3";
                do
                {
                    XiPlus1 = X0 - ((f(func, X0.ToString()) * (Ximin1 - X0)) / (f(func, Ximin1.ToString()) - f(func, X0.ToString())));
                    error = Math.Abs((XiPlus1 - X0) / XiPlus1) * 100;
                    if (iter == 0)
                        SecantDGV.Rows.Add(iter, Ximin1, f(func, Ximin1.ToString()), X0, f(func, X0.ToString()), "--");
                    else
                        SecantDGV.Rows.Add(iter, Ximin1, f(func, Ximin1.ToString()), X0, f(func, X0.ToString()), error);
                    temp = XiPlus1;
                    Ximin1 = X0;
                    X0 = temp;
                    iter++;
                } while (error >= Double.Parse(enterError5.Text) || iter == 0);
                SecantDGV.Rows.Add(iter, Ximin1, f(func, Ximin1.ToString()), X0, f(func, X0.ToString()), error);
                RootSecant.Text = XiPlus1.ToString("F3");
                errorSecant.Text = error.ToString("F3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        //--------------------------------Linear Algebraic eq-----------------------------------  //

        private void ResetGuass_Click(object sender, EventArgs e)
        {
            a00_Guass.Text = string.Empty;
            a01_Guass.Text = string.Empty;
            a02_Guass.Text = string.Empty;
            a03_Guass.Text = string.Empty;
            a10_Guass.Text = string.Empty;
            a11_Guass.Text = string.Empty;
            a12_Guass.Text = string.Empty;
            a13_Guass.Text = string.Empty;
            a20_Guass.Text = string.Empty;
            a21_Guass.Text = string.Empty;
            a22_Guass.Text = string.Empty;
            a23_Guass.Text = string.Empty;
            M21Gauss.Text = string.Empty;
            M31Gauss.Text = string.Empty;
            M32Gauss.Text = string.Empty;
            M21GuassDGV.Rows.Clear();
            M31GuassDGV.Rows.Clear();
            M32GuassDGV.Rows.Clear();
            X1Guass.Text = string.Empty;
            X2Guass.Text = string.Empty;
            X3Guass.Text = string.Empty;
        }
        private void ResetLU_Click(object sender, EventArgs e)
        {
            a00_LU.Text = string.Empty;
            a01_LU.Text = string.Empty;
            a02_LU.Text = string.Empty;
            a03_LU.Text = string.Empty;
            a10_LU.Text = string.Empty;
            a11_LU.Text = string.Empty;
            a12_LU.Text = string.Empty;
            a13_LU.Text = string.Empty;
            a20_LU.Text = string.Empty;
            a21_LU.Text = string.Empty;
            a22_LU.Text = string.Empty;
            a23_LU.Text = string.Empty;
            M21_LU.Text = string.Empty;
            M31_LU.Text = string.Empty;
            M32_LU.Text = string.Empty;
            C1_LU.Text = string.Empty;
            C2_LU.Text = string.Empty;
            C3_LU.Text = string.Empty;
            X1_LU.Text = string.Empty;
            X2_LU.Text = string.Empty;
            X3_LU.Text = string.Empty;
            LDGV_LU.Rows.Clear();
            UDGV.Rows.Clear();
        }
        private void ResetCramer_Click(object sender, EventArgs e)
        {
            a00_Cramer.Text = string.Empty;
            a01_Cramer.Text = string.Empty;
            a02_Cramer.Text = string.Empty;
            a03_Cramer.Text = string.Empty;
            a10_Cramer.Text = string.Empty;
            a11_Cramer.Text = string.Empty;
            a12_Cramer.Text = string.Empty;
            a13_Cramer.Text = string.Empty;
            a20_Cramer.Text = string.Empty;
            a21_Cramer.Text = string.Empty;
            a22_Cramer.Text = string.Empty;
            a23_Cramer.Text = string.Empty;
            A_Cramer.Text = string.Empty;
            A1_Cramer.Text = string.Empty;
            A2_Cramer.Text = string.Empty;
            A3_Cramer.Text = string.Empty;
            A_DGV_Cramer.Rows.Clear();
            A1_DGV_Cramer.Rows.Clear();
            A2_DGV_Cramer.Rows.Clear();
            A3_DGV_Cramer.Rows.Clear();
            X1_Cramer.Text = string.Empty;
            X2_Cramer.Text = string.Empty;
            X3_Cramer.Text = string.Empty;
        }

        private void ResetGJ_Click(object sender, EventArgs e)
        {
            a00_GJ.Text = string.Empty;
            a01_GJ.Text = string.Empty;
            a02_GJ.Text = string.Empty;
            a03_GJ.Text = string.Empty;
            a10_GJ.Text = string.Empty;
            a11_GJ.Text = string.Empty;
            a12_GJ.Text = string.Empty;
            a13_GJ.Text = string.Empty;
            a20_GJ.Text = string.Empty;
            a21_GJ.Text = string.Empty;
            a22_GJ.Text = string.Empty;
            a23_GJ.Text = string.Empty;
            X1_GJ.Text = string.Empty;
            X2_GJ.Text = string.Empty;
            X3_GJ.Text = string.Empty;
            Matrix1_GJ_DGV.Rows.Clear();
            Matrix2_GJ_DGV.Rows.Clear();
        }
        private static void SwapRows(double[,] matrix, int row1, int row2)
        {
            int cols = matrix.GetLength(1);
            for (int j = 0; j < cols; j++)
            {
                double temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
            }
        }
        private static void SwapRows(double[] array, int row1, int row2)
        {
            double temp = array[row1];
            array[row1] = array[row2];
            array[row2] = temp;
        }

        private double Det(double[,] matrix)
        {
            double det = 0;
            for (int i = 0; i < 3; i++)
                det += (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
            return det;
        }

        private void copyMatrix(double[,] matrix1, double[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    matrix1[i, j] = matrix2[i, j];
                }
            }
        }
        public double[,] MultiplyFourMatrices(double[,] matrix1, double[,] matrix2, double[,] matrix3, double[,] matrix4)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);
            int rows3 = matrix3.GetLength(0);
            int cols3 = matrix3.GetLength(1);
            int rows4 = matrix4.GetLength(0);
            int cols4 = matrix4.GetLength(1);

            // Check if the matrices are compatible for multiplication
            if (cols1 != rows2 || cols2 != rows3 || cols3 != rows4)
            {
                throw new ArgumentException("Matrices are not compatible for multiplication.");
            }

            // Create the result matrix
            double[,] result = new double[rows1, cols4];

            // Perform matrix multiplication
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols4; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    for (int k = 0; k < cols2; k++)
                    {
                        sum += matrix3[i, k] * matrix4[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }


        private void print(DataGridView dataGridView, double[,] matrix, int numberOfRows, int numberOfCells)
        {
            dataGridView.RowCount = numberOfRows;
            dataGridView.ColumnCount = numberOfCells;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
            dataGridView.ClearSelection();
        }

        private void SolveGauss_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 4];
            double m21, m31, m32, x1, x2, x3;
            try
            {
                matrix[0, 0] = Double.Parse(a00_Guass.Text);
                matrix[0, 1] = Double.Parse(a01_Guass.Text);
                matrix[0, 2] = Double.Parse(a02_Guass.Text);
                matrix[0, 3] = Double.Parse(a03_Guass.Text);
                matrix[1, 0] = Double.Parse(a10_Guass.Text);
                matrix[1, 1] = Double.Parse(a11_Guass.Text);
                matrix[1, 2] = Double.Parse(a12_Guass.Text);
                matrix[1, 3] = Double.Parse(a13_Guass.Text);
                matrix[2, 0] = Double.Parse(a20_Guass.Text);
                matrix[2, 1] = Double.Parse(a21_Guass.Text);
                matrix[2, 2] = Double.Parse(a22_Guass.Text);
                matrix[2, 3] = Double.Parse(a23_Guass.Text);

                if (GuassPPCheckBox.Checked)
                {
                    if (matrix[1, 0] > matrix[0, 0])
                        SwapRows(matrix, 0, 1);
                    if (matrix[2, 0] > matrix[0, 0])
                        SwapRows(matrix, 0, 2);
                    if (matrix[2, 0] > matrix[1, 0])
                        SwapRows(matrix, 1, 2);

                    m21 = matrix[1, 0] / matrix[0, 0];
                    m31 = matrix[2, 0] / matrix[0, 0];

                    M21Gauss.Text = Convert.ToString(m21);
                    M31Gauss.Text = Convert.ToString(m31);

                    // R2 - (m21) R1 --> R2
                    for (int i = 0; i < 4; i++)
                        matrix[1, i] = matrix[1, i] - m21 * matrix[0, i];
                    print(M21GuassDGV, matrix, 3, 4);

                    //R3 - (m31) R1 --> R3
                    for (int i = 0; i < 4; i++)
                        matrix[2, i] = matrix[2, i] - m31 * matrix[0, i];
                    print(M31GuassDGV, matrix, 3, 4);

                    if (matrix[2, 1] > matrix[1, 1])
                        SwapRows(matrix, 1, 2);
                    //R3 - (m32) R2 --> R3
                    m32 = matrix[2, 1] / matrix[1, 1];
                    M32Gauss.Text = Convert.ToString(m32);
                    for (int i = 0; i < 4; i++)
                    {
                        matrix[2, i] = matrix[2, i] - m32 * matrix[1, i];
                    }
                    print(M32GuassDGV, matrix, 3, 4);

                    //Calculate X value
                    x3 = matrix[2, 3] / matrix[2, 2];
                    x2 = ((matrix[1, 2] * x3 * -1) + matrix[1, 3]) / matrix[1, 1];
                    x1 = ((matrix[0, 1] * x2 * -1) + (matrix[0, 2] * x3 * -1) + matrix[0, 3]) / matrix[0, 0];
                    X1Guass.Text = Convert.ToString(x1);
                    X2Guass.Text = Convert.ToString(x2);
                    X3Guass.Text = Convert.ToString(x3);
                }
                else
                {
                    m21 = Double.Parse(a10_Guass.Text) / Double.Parse(a00_Guass.Text);
                    m31 = Double.Parse(a20_Guass.Text) / Double.Parse(a00_Guass.Text);

                    M21Gauss.Text = Convert.ToString(m21);
                    M31Gauss.Text = Convert.ToString(m31);

                    // R2 - (m21) R1 --> R2
                    for (int i = 0; i < 4; i++)
                    {
                        matrix[1, i] = matrix[1, i] - m21 * matrix[0, i];
                    }
                    print(M21GuassDGV, matrix, 3, 4);

                    //R3 - (m31) R1 --> R3
                    for (int i = 0; i < 4; i++)
                    {
                        matrix[2, i] = matrix[2, i] - m31 * matrix[0, i];
                    }
                    print(M31GuassDGV, matrix, 3, 4);

                    //R3 - (m32) R2 --> R3
                    m32 = matrix[2, 1] / matrix[1, 1];
                    M32Gauss.Text = Convert.ToString(m32);

                    for (int i = 0; i < 4; i++)
                    {
                        matrix[2, i] = matrix[2, i] - m32 * matrix[1, i];
                    }
                    print(M32GuassDGV, matrix, 3, 4);

                    //Calculate X value
                    x3 = matrix[2, 3] / matrix[2, 2];
                    x2 = ((matrix[1, 2] * x3 * -1) + matrix[1, 3]) / matrix[1, 1];
                    x1 = ((matrix[0, 1] * x2 * -1) + (matrix[0, 2] * x3 * -1) + matrix[0, 3]) / matrix[0, 0];
                    X1Guass.Text = Convert.ToString(x1);
                    X2Guass.Text = Convert.ToString(x2);
                    X3Guass.Text = Convert.ToString(x3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SolveLU_Click(object sender, EventArgs e)
        {
            double[,] A = new double[3, 3];
            double m21, m31, m32, X1, X2, X3, c1, c2, c3;
            double[] B = new double[3];
            double[,] L = new double[3, 3];
            double[,] U = new double[3, 3];
            double[,] P01 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            double[,] P02 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            double[,] P12 = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            try
            {
                A[0, 0] = Double.Parse(a00_LU.Text);
                A[0, 1] = Double.Parse(a01_LU.Text);
                A[0, 2] = Double.Parse(a02_LU.Text);
                A[1, 0] = Double.Parse(a10_LU.Text);
                A[1, 1] = Double.Parse(a11_LU.Text);
                A[1, 2] = Double.Parse(a12_LU.Text);
                A[2, 0] = Double.Parse(a20_LU.Text);
                A[2, 1] = Double.Parse(a21_LU.Text);
                A[2, 2] = Double.Parse(a22_LU.Text);
                B[0] = Double.Parse(a03_LU.Text);
                B[1] = Double.Parse(a13_LU.Text);
                B[2] = Double.Parse(a23_LU.Text);

                if (LUPPCheckBox.Checked)
                {
                    if (A[1, 0] > A[0, 0])
                    {
                        SwapRows(A, 0, 1);
                        SwapRows(B, 0, 1);
                        SwapRows(P01, 0, 1);
                    }
                    if (A[2, 0] > A[0, 0])
                    {
                        SwapRows(A, 0, 2);
                        SwapRows(B, 0, 2);
                        SwapRows(P02, 0, 2);
                    }
                    if (A[2, 0] > A[1, 0])
                    {
                        SwapRows(A, 1, 2);
                        SwapRows(B, 1, 2);
                        SwapRows(P12, 1, 2);
                    }

                    m21 = A[1, 0] / A[0, 0];
                    m31 = A[2, 0] / A[0, 0];

                    M21_LU.Text = Convert.ToString(m21);
                    M31_LU.Text = Convert.ToString(m31);

                    // R2 - (m21) R1 --> R2
                    for (int i = 0; i < 3; i++)
                        A[1, i] = A[1, i] - m21 * A[0, i];

                    //R3 - (m31) R1 --> R3
                    for (int i = 0; i < 3; i++)
                        A[2, i] = A[2, i] - m31 * A[0, i];

                    //R3 - (m32) R2 --> R3
                    if (A[2, 1] > A[1, 1])
                    {
                        SwapRows(A, 1, 2);
                        SwapRows(B, 1, 2);
                        SwapRows(P12, 1, 2);
                    }
                    m32 = A[2, 1] / A[1, 1];
                    M32_LU.Text = Convert.ToString(m32);

                    for (int i = 0; i < 3; i++)
                        A[2, i] = A[2, i] - m32 * A[1, i];

                    copyMatrix(U, A);
                    print(UDGV, U, 3, 3);
                
                    // Calculate L
                    double[,] lfirst = { { 1, 0, 0 }, { m21, 1, 0 }, { m31, m32, 1 } };
                    L = MultiplyFourMatrices(P01, P12, P02, lfirst);
                    print(LDGV_LU, L, 3, 3);

                    // Calculate C ---> LC = B
                    c1 = B[0];
                    c2 = ((L[1, 0] * c1 * -1) + B[1]) / L[1, 1];
                    c3 = ((L[2, 1] * c2 * -1) + (L[2, 0] * c1 * -1) + B[2]) / L[2, 2];
                    C1_LU.Text = Convert.ToString(c1);
                    C2_LU.Text = Convert.ToString(c2);
                    C3_LU.Text = Convert.ToString(c3);

                    // Calculate X ---> UX = C
                    X3 = c3 / U[2, 2];
                    X2 = ((U[1, 2] * X3 * -1) + c2) / U[1, 1];
                    X1 = ((U[0, 1] * X2 * -1) + (U[0, 2] * X3 * -1) + c1) / U[0, 0];
                    X1_LU.Text = Convert.ToString(X1);
                    X2_LU.Text = Convert.ToString(X2);
                    X3_LU.Text = Convert.ToString(X3);
                }
                else
                {
                    m21 = Double.Parse(a10_LU.Text) / Double.Parse(a00_LU.Text);
                    m31 = Double.Parse(a20_LU.Text) / Double.Parse(a00_LU.Text);

                    M21_LU.Text = Convert.ToString(m21);
                    M31_LU.Text = Convert.ToString(m31);

                    // R2 - (m21) R1 --> R2
                    for (int i = 0; i < 3; i++)
                    {
                        A[1, i] = A[1, i] - m21 * A[0, i];
                    }

                    //R3 - (m31) R1 --> R3
                    for (int i = 0; i < 3; i++)
                    {
                        A[2, i] = A[2, i] - m31 * A[0, i];
                    }
                    //R3 - (m32) R2 --> R3
                    m32 = A[2, 1] / A[1, 1];
                    M32_LU.Text = Convert.ToString(m32);

                    for (int i = 0; i < 3; i++)
                    {
                        A[2, i] = A[2, i] - m32 * A[1, i];
                    }
                    copyMatrix(U, A);
                    print(UDGV, U, 3, 3);

                    // Calculate L
                    double[,] lCopy = { { 1, 0, 0 }, { m21, 1, 0 }, { m31, m32, 1 } };
                    copyMatrix(L, lCopy);
                    print(LDGV_LU, L, 3, 3);

                    // Calculate C ---> LC = B
                    c1 = B[0];
                    c2 = ((L[1, 0] * c1 * -1) + B[1]) / L[1, 1];
                    c3 = ((L[2, 1] * c2 * -1) + (L[2, 0] * c1 * -1) + B[2]) / L[2, 2];
                    C1_LU.Text = Convert.ToString(c1);
                    C2_LU.Text = Convert.ToString(c2);
                    C3_LU.Text = Convert.ToString(c3);

                    // Calculate X ---> UX = C
                    X3 = c3 / U[2, 2];
                    X2 = ((U[1, 2] * X3 * -1) + c2) / U[1, 1];
                    X1 = ((U[0, 1] * X2 * -1) + (U[0, 2] * X3 * -1) + c1) / U[0, 0];
                    X1_LU.Text = Convert.ToString(X1);
                    X2_LU.Text = Convert.ToString(X2);
                    X3_LU.Text = Convert.ToString(X3);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SolveCramer_Click(object sender, EventArgs e)
        {
            double A1, A2, A3, A;
            double[] B = new double[3];
            double[,] Matrix_A = new double[3, 3];
            double[,] Matrix_A1 = new double[3, 3];
            double[,] Matrix_A2 = new double[3, 3];
            double[,] Matrix_A3 = new double[3, 3];
            try
            {
                //Matrix A 
                Matrix_A[0, 0] = Double.Parse(a00_Cramer.Text);
                Matrix_A[0, 1] = Double.Parse(a01_Cramer.Text);
                Matrix_A[0, 2] = Double.Parse(a02_Cramer.Text);
                Matrix_A[1, 0] = Double.Parse(a10_Cramer.Text);
                Matrix_A[1, 1] = Double.Parse(a11_Cramer.Text);
                Matrix_A[1, 2] = Double.Parse(a12_Cramer.Text);
                Matrix_A[2, 0] = Double.Parse(a20_Cramer.Text);
                Matrix_A[2, 1] = Double.Parse(a21_Cramer.Text);
                Matrix_A[2, 2] = Double.Parse(a22_Cramer.Text);
                B[0] = Double.Parse(a03_Cramer.Text);
                B[1] = Double.Parse(a13_Cramer.Text);
                B[2] = Double.Parse(a23_Cramer.Text);
                A = Det(Matrix_A);
                A_Cramer.Text = Convert.ToString(A);
                print(A_DGV_Cramer, Matrix_A, 3, 3);

                //Calculate A1
                copyMatrix(Matrix_A1, Matrix_A);
                for (int i = 0; i < 3; i++)
                    Matrix_A1[i, 0] = B[i];
                A1 = Det(Matrix_A1);
                A1_Cramer.Text = Convert.ToString(A1);
                print(A1_DGV_Cramer, Matrix_A1, 3, 3);

                //Calculate A2
                copyMatrix(Matrix_A2, Matrix_A);
                for (int i = 0; i < 3; i++)
                    Matrix_A2[i, 1] = B[i];
                A2 = Det(Matrix_A2);
                A2_Cramer.Text = Convert.ToString(A2);
                print(A2_DGV_Cramer, Matrix_A2, 3, 3);

                //Calculate A3
                copyMatrix(Matrix_A3, Matrix_A);
                for (int i = 0; i < 3; i++)
                    Matrix_A3[i, 2] = B[i];
                A3 = Det(Matrix_A3);
                A3_Cramer.Text = Convert.ToString(A3);
                print(A3_DGV_Cramer, Matrix_A3, 3, 3);

                //Print X Value 
                X1_Cramer.Text = Convert.ToString(A1 / A);
                X2_Cramer.Text = Convert.ToString(A2 / A);
                X3_Cramer.Text = Convert.ToString(A3 / A);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SolveGJ_Click(object sender, EventArgs e)
        {
            double[,] matrix = new double[3, 4];
            double m21, m31, m32, m12, m13, m23;
            try
            {
                matrix[0, 0] = Double.Parse(a00_GJ.Text);
                matrix[0, 1] = Double.Parse(a01_GJ.Text);
                matrix[0, 2] = Double.Parse(a02_GJ.Text);
                matrix[0, 3] = Double.Parse(a03_GJ.Text);
                matrix[1, 0] = Double.Parse(a10_GJ.Text);
                matrix[1, 1] = Double.Parse(a11_GJ.Text);
                matrix[1, 2] = Double.Parse(a12_GJ.Text);
                matrix[1, 3] = Double.Parse(a13_GJ.Text);
                matrix[2, 0] = Double.Parse(a20_GJ.Text);
                matrix[2, 1] = Double.Parse(a21_GJ.Text);
                matrix[2, 2] = Double.Parse(a22_GJ.Text);
                matrix[2, 3] = Double.Parse(a23_GJ.Text);

                if (checkBox1.Checked)
                {
                    if (matrix[1, 0] > matrix[0, 0])
                        SwapRows(matrix, 0, 1);
                    if (matrix[2, 0] > matrix[0, 0])
                        SwapRows(matrix, 0, 2);
                    if (matrix[2, 0] > matrix[1, 0])
                        SwapRows(matrix, 1, 2);

                    m21 = matrix[1, 0] / matrix[0, 0];
                    m31 = matrix[2, 0] / matrix[0, 0];

                    for (int i = 0; i < 4; i++)
                        matrix[1, i] -= m21 * matrix[0, i];

                    for (int i = 0; i < 4; i++)
                        matrix[2, i] -= m31 * matrix[0, i];

                    if (matrix[2, 1] > matrix[1, 1])
                        SwapRows(matrix, 1, 2);
                    m32 = matrix[2, 1] / matrix[1, 1];
                    for (int i = 0; i < 4; i++)
                        matrix[2, i] -= m32 * matrix[1, i];
                    double m00 = matrix[0, 0], m11 = matrix[1, 1], m22 = matrix[2, 2];

                    for (int i = 0; i < 4; i++)
                    {
                        matrix[0, i] /= m00;
                        matrix[1, i] /= m11;
                        matrix[2, i] /= m22;
                    }
                    print(Matrix1_GJ_DGV, matrix, 3, 4);

                    //R2 - (m23) R3 --> R2
                    //R1 - (m13) R3 --> R1
                    //R1 - (m12) R2 --> R1
                    m23 = matrix[1, 2] / matrix[2, 2];

                    for (int i = 0; i < 4; i++)
                        matrix[1, i] -= m23 * matrix[2, i];

                    m13 = matrix[0, 2] / matrix[2, 2];

                    for (int i = 0; i < 4; i++)
                        matrix[0, i] -= m13 * matrix[2, i];


                    m12 = matrix[0, 1] / matrix[1, 1];
                    for (int i = 0; i < 4; i++)
                        matrix[0, i] -= m12 * matrix[1, i];


                    print(Matrix2_GJ_DGV, matrix, 3, 4);

                    //Calculate X value
                    X1_GJ.Text = matrix[0, 3].ToString();
                    X2_GJ.Text = matrix[1, 3].ToString();
                    X3_GJ.Text = matrix[2, 3].ToString();
                }
                else
                {
                    //R2 - (m21) R1 --> R2
                    //R3 - (m31) R1 --> R3
                    //R3 - (m32) R2 --> R3

                    m21 = matrix[1, 0] / matrix[0, 0];
                    m31 = matrix[2, 0] / matrix[0, 0];


                    for (int i = 0; i < 4; i++)
                        matrix[1, i] -= m21 * matrix[0, i];

                    for (int i = 0; i < 4; i++)
                        matrix[2, i] -= m31 * matrix[0, i];

                    m32 = matrix[2, 1] / matrix[1, 1];
                    for (int i = 0; i < 4; i++)
                        matrix[2, i] -= m32 * matrix[1, i];
                    double m00 = matrix[0, 0], m11 = matrix[1, 1], m22 = matrix[2, 2];

                    for (int i = 0; i < 4; i++)
                    {
                        matrix[0, i] /= m00;
                        matrix[1, i] /= m11;
                        matrix[2, i] /= m22;
                    }
                    print(Matrix1_GJ_DGV, matrix, 3, 4);

                    //R2 - (m23) R3 --> R2
                    //R1 - (m13) R3 --> R1
                    //R1 - (m12) R2 --> R1
                    m23 = matrix[1, 2] / matrix[2, 2];

                    for (int i = 0; i < 4; i++)
                        matrix[1, i] -= m23 * matrix[2, i];

                    m13 = matrix[0, 2] / matrix[2, 2];

                    for (int i = 0; i < 4; i++)
                        matrix[0, i] -= m13 * matrix[2, i];


                    m12 = matrix[0, 1] / matrix[1, 1];
                    for (int i = 0; i < 4; i++)
                        matrix[0, i] -= m12 * matrix[1, i];


                    print(Matrix2_GJ_DGV, matrix, 3, 4);

                    //Calculate X value
                    X1_GJ.Text = matrix[0, 3].ToString();
                    X2_GJ.Text = matrix[1, 3].ToString();
                    X3_GJ.Text = matrix[2, 3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }



        //private void pictureBox38_Click(object sender, EventArgs e)
        //{
        //    string websiteUrl = "https://www.linkedin.com/in/mohammademam/"; // Replace with your desired website URL
        //    System.Diagnostics.Process.Start(websiteUrl);
        //}
    }
}

