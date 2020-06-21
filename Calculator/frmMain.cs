using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmMain : Form
    {
        private bool 
              IsNewEntry              //used for detect a new entry or not
            , HasEqualPressed         //used for detect a multiple "=" pressing
            , IsOperatorFoundAsLast   //used for detect wheather the last char of lblsec an operator or not
            , IsfrmAboutOpen          //used for detect wheather the frmAbout is open or not
            , IsEngineReady = false;  //used for detect wheather the scriptContorl is ready and lblMain contains "." || "-"
        
        private string 
              LastOperand             //used for store the last operand
            , LastOperator;           //used for store the last operator

        MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl(); //Creating the engine
        
        //==========================
        //Calculator Basic Functions
        //==========================

        //--------------FormLoad, Form functions------------------

        public frmMain()
        {
            InitializeComponent();    //UI Componenet Initializing
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sc.Language = "VBScript"; //Changing the script Language to VBScript
            IsEngineReady = true;
            LastOperand = "0";
            LastOperator = "0";
            HasEqualPressed = false;
            IsOperatorFoundAsLast = false;
            IsNewEntry = true;
        }

        //-----------btnClose Closing Event--------------
        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //-----------btnMinimize Minimizing Event--------------
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //-----------frmAbout Open, TopMost Fuctions--------------
        private void btnAbout_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmAbout")
                {
                    IsfrmAboutOpen = true;
                    Application.OpenForms["frmAbout"].TopMost = true;
                }
                else
                {
                    IsfrmAboutOpen = false;
                }
            }
            if (!IsfrmAboutOpen)
            {
                frmAbout frmAbout = new frmAbout();
                frmAbout.Show();
            }
        }

        //===========================
        //Calculator Button Functions
        //===========================

        //--------------+,-,x,/ buttons-----------------------
        private void OperatorClick(object sender, EventArgs e)
        {
            Guna2TileButton button = (Guna2TileButton)sender;
            IsEngineReady = true;

            if (IsOperatorFoundAsLast)
            {
                lblSec.Text = lblSec.Text.Remove(lblSec.Text.Length - 1) + button.AccessibleName;
            }
            else
            {
                lblSec.Text += lblMain.Text + button.AccessibleName;
            }

            LastOperand = lblMain.Text;
            LastOperator = button.AccessibleName;
            HasEqualPressed = false;
            IsNewEntry = true;
            IsOperatorFoundAsLast = true;
        }

        //-----------1,2,3,4,5,6,7,8,9,.,0 buttons--------------
        private void OperandClick(object sender, EventArgs e)
        {
            Guna2TileButton button = (Guna2TileButton)sender;
            IsEngineReady = true;

            if (lblSec.Text.Contains("=")) 
            {
                lblSec.Text = "";
                lblMain.Text = button.Text;
                HasEqualPressed = false;
            }
            else
            {
                if (IsNewEntry)
                {
                    lblMain.Text = button.Text;
                    IsNewEntry = false;
                }
                else if (lblMain.Text.Length <= 29)
                {
                        lblMain.Text = lblMain.Text.Insert(lblMain.Text.Length, button.Text);
                }
            }
            IsOperatorFoundAsLast = false;
        }

        private void btnDot_Click_1(object sender, EventArgs e)
        {
            if (!lblMain.Text.Contains("."))
            {
                lblMain.Text = lblMain.Text.Insert(lblMain.Text.Length, ".");
                IsEngineReady = false;
                IsNewEntry = false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            IsEngineReady = true;

            if (lblMain.Text != "0")
            {
                if (IsNewEntry)
                    lblMain.Text = "0";
                else
                    lblMain.Text += "0";
            }
        }

        //------------Equal, Sqrt, Square, NegPos, Backspace, Clear Clicking Event------------
        private void btnEqual_Click(object sender, EventArgs e)
        {
            IsNewEntry = true;
            IsOperatorFoundAsLast = true;

            if (HasEqualPressed)
            {
                PerformLastOperation();
            }
            else
            {
                HasEqualPressed = true;
                LastOperand = lblMain.Text;
                lblSec.Text = lblSec.Text.Insert(lblSec.Text.Length,lblMain.Text);
                lblMain.Text = sc.Eval(lblSec.Text).ToString();
                lblSec.Text = lblSec.Text.Insert(lblSec.Text.Length,"=");
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(lblMain.Text);
            IsOperatorFoundAsLast = false;
            IsEngineReady = false;

            if (lblSec.Text.Contains("="))
                lblSec.Text = "";

            lblMain.Text = Math.Pow(Base, (double)2).ToString();
            IsNewEntry = true;
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double Base = Convert.ToDouble(lblMain.Text);
            IsOperatorFoundAsLast = false;
            IsEngineReady = false;

            if (lblSec.Text.Contains("="))
                lblSec.Text = "";
                
            lblMain.Text = Math.Sqrt(Base).ToString();
            IsNewEntry = true;
        }

        private void btn1overX_Click(object sender, EventArgs e)
        {
            IsEngineReady = false;
            IsNewEntry = true;
            IsOperatorFoundAsLast = false;

            double Base = Convert.ToDouble(lblMain.Text);
            double Result = 1 / Base;

            if (lblSec.Text.Contains("="))
                lblSec.Text = "";

            lblMain.Text = Result.ToString();
            IsNewEntry = true;
        }

        private void btnNegPos_Click(object sender, EventArgs e)
        {
            decimal num = Convert.ToDecimal(lblMain.Text);
            num = num * -1;
            IsEngineReady = false;
            lblMain.Text = num.ToString();
        }

        private void btnClearlblMain_Click(object sender, EventArgs e)
        {
            IsEngineReady = false;
            IsNewEntry = true;
            lblMain.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            IsEngineReady = false;

            if (lblMain.Text.Length == 1)
            {
                IsNewEntry = true;
                lblMain.Text = "0";
            }
            else
            {
                lblMain.Text = lblMain.Text.Remove(lblMain.Text.Length - 1, 1);
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IsNewEntry = true;
            lblSec.Text = "";
            lblMain.Text = "0";
        }

        //PerformLastCalculation Method Declaring
        public void PerformLastOperation() 
        {
            lblSec.Text = lblMain.Text + LastOperator + LastOperand;
            lblMain.Text = sc.Eval(lblSec.Text).ToString();
            lblSec.Text += "=";
        }

        //Function to display realtime solutions : lblMain Font resizing, quick solution displaying
        private void timerCheckingLength_Tick(object sender, EventArgs e)
        {
            lblMain.Select();

            if (IsEngineReady)
            {
                if (IsOperatorFoundAsLast && lblSec.Text != "")
                {
                    string lblWithoutOperator = lblSec.Text.Remove(lblSec.Text.Length - 1, 1);
                    lblMain.Text = sc.Eval(lblWithoutOperator).ToString();
                }
            }

            if (lblMain.Text.Length <= 14)
                lblMain.Font = new Font("Consolas", 28, FontStyle.Bold);
            else if (lblMain.Text.Length <= 15)
                lblMain.Font = new Font("Consolas", 26, FontStyle.Bold);
            else if (lblMain.Text.Length <= 16)
                lblMain.Font = new Font("Consolas", 24, FontStyle.Bold);
            else if (lblMain.Text.Length <= 18)
                lblMain.Font = new Font("Consolas", 22, FontStyle.Bold);
            else if (lblMain.Text.Length <= 20)
                lblMain.Font = new Font("Consolas", 20, FontStyle.Bold);
            else if (lblMain.Text.Length <= 23)
                lblMain.Font = new Font("Consolas", 18, FontStyle.Bold);
            else if (lblMain.Text.Length <= 25)
                lblMain.Font = new Font("Consolas", 16, FontStyle.Bold);
            else if (lblMain.Text.Length <= 29)
                lblMain.Font = new Font("Consolas", 14, FontStyle.Bold);
        }

        //Function to react key press
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.C:
                    btnClear.PerformClick();
                    break;
                case Keys.D0:
                    btn0.Select();
                    SendKeys.Send(Keys.Space.ToString());
                    break;
                case Keys.D1:
                    btn1.PerformClick();
                    break;
                case Keys.D2:
                    btn2.PerformClick();
                    break;
                case Keys.D3:
                    btn3.PerformClick();
                    break;
                case Keys.D4:
                    btn4.PerformClick();
                    break;
                case Keys.D5:
                    btn5.PerformClick();
                    break;
                case Keys.D6:
                    btn6.PerformClick();
                    break;
                case Keys.D7:
                    btn7.PerformClick();
                    break;
                case Keys.D8:
                    if (e.Modifiers == Keys.Shift) { btnMultiply.PerformClick(); }
                    else { btn8.PerformClick(); }
                    break;
                case Keys.D9:
                    btn9.PerformClick();
                    break;
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                case Keys.OemPeriod:
                    btnDot.PerformClick();
                    break;
                case Keys.Decimal:
                    btnDot.PerformClick();
                    break;
                case Keys.Back:
                    btnBackspace.PerformClick();
                    break;
                case Keys.Oemplus:
                    if (e.Modifiers == Keys.Shift) { btnPlus.PerformClick(); }
                    else { btnEqual.PerformClick(); }
                    break;
                case Keys.OemMinus:
                    btnMinus.PerformClick();
                    break;
                case Keys.OemQuestion:
                    if (e.Modifiers == Keys.Shift) { } else { btnDivide.PerformClick(); }
                    break;
                case Keys.Divide:
                    btnDivide.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMultiply.PerformClick();
                    break;
                case Keys.Enter:
                    btnEqual.PerformClick();
                    break;
            }
        }
    }
}