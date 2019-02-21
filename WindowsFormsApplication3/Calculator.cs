using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        readonly List<Operation> opNumber = new List<Operation>();
        public Calculator()
        {
            InitializeComponent();
            opNumber.Add(new Plus());
            opNumber.Add(new Minus());
            opNumber.Add(new Multi());
            opNumber.Add(new Div());
            opNumber.Add(new Pow());
            opNumber.Add(new Factorial());
        }


        #region Фокус текстбоксов
        //Создана переменная сохраняющая значение последнего фокуса одного из текстбоксов
        private int _tbf = 1;
        private void tbX_Enter(object sender, EventArgs e)
        {
            _tbf = 1;
            tbX.BackColor = Color.White;
            tbY.BackColor = Color.LightSeaGreen;
        }

        private void tbY_Enter(object sender, EventArgs e)
        {
            _tbf = 2;
            tbY.BackColor = Color.White;
            tbX.BackColor = Color.LightSeaGreen;
        }
        #endregion
        int operation = 0;
        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                int x;int y;
                if (tbX.Text != "")
                {
                    x = int.Parse(tbX.Text);
                }
                else
                {
                    tbX.Text = "0";
                    x = int.Parse(tbX.Text);
                }
                if (tbY.Text != "")
                {
                    y = int.Parse(tbX.Text);
                }
                else
                {
                    tbX.Text = "0";
                    y = int.Parse(tbY.Text);
                }
                
                switch (operation)
                {
                    case 1:
                        rtbResult.Text = Convert.ToString(opNumber[0].Calculate(x, y));
                        break;
                    case 2:
                        rtbResult.Text = Convert.ToString(opNumber[1].Calculate(x, y));
                        break;
                    case 3:
                        rtbResult.Text = Convert.ToString(opNumber[2].Calculate(x, y));
                        break;
                    case 4:
                        rtbResult.Text = Convert.ToString(opNumber[3].Calculate(x, y));
                        break;
                    case 5:
                        rtbResult.Text = Convert.ToString(opNumber[4].Calculate(x, y));
                        break;
                    case 6:
                        y = 0;
                        rtbResult.Text = Convert.ToString(opNumber[5].Calculate(x, y));
                        break;
                    default:
                        MessageBox.Show(@"Не выбран оператор");
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Введённый формат данных является недопустимым\nError:" + ex.Message);
            }
        }
        #region Кнопки операций
        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblOperation.Text = @"+";
            operation = 1;
            tbY.Visible = true;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblOperation.Text = @"-";
            operation = 2;
            tbY.Visible = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            lblOperation.Text = @"*";
            operation = 3;
            tbY.Visible = true;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblOperation.Text = @"/";
            operation = 4;
            tbY.Visible = true;
        }

        private void bp_Click(object sender, EventArgs e)
        {
            lblOperation.Text = @"^";
            operation = 5;
            tbY.Visible = true;
        }

        private void bf_Click(object sender, EventArgs e)
        {
            lblOperation.Text = @"!";
            tbY.Text = @"0";
            operation = 6;
            tbY.Visible = false;
        }
        #endregion
        #region Кнопки ввода
        private void b0_Click(object sender, EventArgs e)
        {
            const string number = "0";
            InPut(number);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            const string number = "1";
            InPut(number);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            const string number = "2";
            InPut(number);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            const string number = "3";
            InPut(number);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            const string number = "4";
            InPut(number);
        }
        
        private void b5_Click(object sender, EventArgs e)
        {
            const string number = "5";
            InPut(number);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            const string number = "6";
            InPut(number);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            const string number = "7";
            InPut(number);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            const string number = "8";
            InPut(number);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            const string number = "9";
            InPut(number);
        }

        private void btnErase_Click(object sender, EventArgs e)
        {

            if (_tbf == 1)
                if (tbX.Text.Length!=0) tbX.Text = tbX.Text.Substring(0, tbX.Text.Length - 1);
            if (_tbf == 2)
                if (tbY.Text.Length != 0) tbY.Text = tbY.Text.Substring(0, tbY.Text.Length - 1);
        }


        private void btnEraseall_Click(object sender, EventArgs e)
        {
            tbY.Text = "";
            tbX.Text = "";
            rtbResult.Text = "";
            lblOperation.Text = "";
            operation = 0;
            tbY.Visible = true;
        }

        private void InPut(string number)
        {
            if (_tbf == 1)
                tbX.Text += number;
            else
                tbY.Text += number;
        }
        #endregion
        #region info
        private void lblinfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Выполнил Галиуллин Ильнур Камилович. \n " +
                "По вопросам и предложениям обращаться по почте ilnurgal1994@gmail.com\n");
            //если есть предложения по коду, можете написать на почту :) буду рад рассмотреть!
        }
        #endregion
        #region Наследование. Операции с числами
        public class Plus : Operation
        {
            public override decimal Calculate(decimal a, decimal b)
            {
                return a + b;
            }
        }
        public class Minus : Operation
        {
            public override decimal Calculate(decimal a, decimal b)
            {
                return a - b;
            }
        }
        public class Multi : Operation
        {
            public override decimal Calculate(decimal a, decimal b)
            {
                return a * b;
            }
        }
        public class Div : Operation
        {
            public override decimal Calculate(decimal a, decimal b)
            {
                return a / b;
            }
        }
        public class Pow : Operation
        {
            public override decimal Calculate(decimal a, decimal b)
            {
                return Convert.ToDecimal(System.Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)));
            }
        }
        public class Factorial : Operation
        {
            public override decimal Calculate(decimal a, decimal b)
            {
                int f = 1;
                for (int i = 1; i <= a; i++)
                {
                    f = f * i;
                }

                return f;
            }
        }

        public abstract class Operation
        {
            public abstract decimal Calculate(decimal a, decimal b);
        }
    }
#endregion
}
