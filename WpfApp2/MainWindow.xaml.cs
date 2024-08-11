using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string num1, num2;
        private Calculator calculator = new Calculator();
        private int opration = 0;
        private bool oldResult = false;

        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OnButtonKeyDown);
        }

        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1)
            {
                Btn_1.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad2)
            {
                Btn_2.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad3)
            {
                Btn_3.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad4)
            {
                Btn_4.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad5)
            {
                Btn_5.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad6)
            {
                Btn_6.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad7)
            {
                Btn_7.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad8)
            {
                Btn_8.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad9)
            {
                Btn_9.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.NumPad0)
            {
                Btn_0.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            if (e.Key == Key.Add)
            {
                Btn_plus.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.OemMinus)
            {
                Btn_minus.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Multiply)
            {
                Btn_multiply.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Divide)
            {
                Btn_divide.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Enter)
            {
                Btn_equal.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Back)
            {
                if (txtBox.Text != null && txtBox.Text != "")
                {
                    txtBox.Text = txtBox.Text.Remove(txtBox.Text.Length - 1);
                }
            }
            else if(e.Key == Key.Decimal)
            {
                Btn_dot.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if(e.Key == Key.Delete)
            {
                Btn_clearHistory.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }


        }
        
        private void Btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if(opration == 0)
            {
                do { num1 = checkInput(); }
                while (num1 == null);
                opration = 1;
            }
            else
            {
                do { num2 = checkInput(); }
                while (num2 == null);
                txtBox.Text = result(num1, num2);
                oldResult = true;
                num1 = txtBox.Text;
                num2 = "";
                opration = 1;
            }
        }

        private void Btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (opration == 0)
            {
                do { num1 = checkInput(); }
                while (num1 == null);
                opration = 2;
            }
            else
            {
                do { num2 = checkInput(); }
                while (num2 == null);
                txtBox.Text = result(num1, num2);
                oldResult = true;
                num1 = txtBox.Text;
                num2 = "";
                opration = 2;
            }
        }

        private void Btn_multiply_Click_1(object sender, RoutedEventArgs e)
        {
            if (opration == 0)
            {
                do { num1 = checkInput(); }
                while (num1 == null);
                opration = 3;
            }
            else
            {
                do { num2 = checkInput(); }
                while (num2 == null);
                txtBox.Text = result(num1, num2);
                oldResult = true;
                num1 = txtBox.Text;
                num2 = "";
                opration = 3;
            }
        }

        private void Btn_divide_Click_1(object sender, RoutedEventArgs e)
        {
            if (opration == 0)
            {
                do { num1 = checkInput(); }
                while (num1 == null);
                opration = 4;
            }
            else
            {
                do { num2 = checkInput(); }
                while (num2 == null);
                txtBox.Text = result(num1, num2);
                oldResult = true;
                num1 = txtBox.Text;
                num2 = "";
                opration = 4;
            }
        }

        private void Btn_equal_Click_1(object sender, RoutedEventArgs e)
        {
            do { num2 = checkInput(); }
            while (num2 == null);
            txtBox.Text = result(num1, num2);
            opration = 0;

        }

        private void Btn_clearHistory_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
            num1 = "";
            num2 = "";
            opration = 0;
            oldResult = false;
        }

        private void Btn_clear_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Clear();
        }



        private string checkInput()
        {
            if (txtBox.Text != null)
            {
                if (double.TryParse(txtBox.Text, out double n1))
                {
                    txtBox.Clear();
                    return n1.ToString();
                }
                else
                {
                    txtBox.Clear();
                }
            }
            return null;
        }



        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "1";

        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "2";
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "3";
        }

        private void Button_Click(object sender, RoutedEventArgs e)//btn4
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "4";
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "5";
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "6";
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "7";
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "8";
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "9";
        }

        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + "0";
        }

        private void Btn_dot_Click(object sender, RoutedEventArgs e)
        {
            if (oldResult)
            {
                txtBox.Clear();
                oldResult = false;
            }
            txtBox.Text = txtBox.Text + ".";
        }

        private string result(string input1, string input2)
        {
            switch (opration)
            {
                case 1:
                    return calculator.add(input1, input2);
                case 2:
                    return calculator.minus(input1, input2);
                case 3:
                    return calculator.multiply(input1, input2);
                case 4:
                    return calculator.divide(input1, input2);
                default:
                    return null;

            }
        }

    }

}
