using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public string value = "";
        public string valueOld = "";
        List<string> ls = new List<string>();
        public string text = "";
        public string symbol = " ";
        public string symbols = "+-*/%";
        public Calculator()
        {
            InitializeComponent();
            textBoxMain.Text = "0";
            MyRefresh();
        }

        private void MyRefresh()
        {
            listBoxMain.DataSource = null;
            listBoxMain.DataSource = ls;
            listBoxMain.SelectedIndex = listBoxMain.Items.Count - 1;
        }

        private void vTovOld ()
        {
            if (symbol != "" && symbol != "=")
            {
                valueOld = value;
                value = "";
                text += valueOld;
                text += symbol;
                textBoxMain.Text = "0";
            }
        }

        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxMain.Text = "";
            switch (e.KeyChar)
            {
                case '\b':
                    if (value.Length > 1) 
                    value = value.Remove(value.Length-1, 1).Insert(value.Length - 1, '\0'.ToString());
                    break;
                case '.':
                case ',':
                    value += "."; 
                    break;
                case '0':
                    vTovOld();
                    value += "0";
                    break;
                case '1':
                    vTovOld();
                    value += "1";
                    break;
                case '2':
                    vTovOld();
                    value += "2";
                    break;
                case '3':
                    vTovOld();
                    value += "3";
                    break;
                case '4':
                    vTovOld();
                    value += "4";
                    break;
                case '5':
                    vTovOld();
                    value += "5";
                    break;
                case '6':
                    vTovOld();
                    value += "6";
                    break;
                case '7':
                    vTovOld();
                    value += "7";
                    break;
                case '8':
                    vTovOld();
                    value += "8";
                    break;
                case '9':
                    vTovOld();
                    value += "9";
                    break;
                case '=':
                case '\r':
                    text += value;
                    text += "=";
                    switch (symbol)
                    {
                        case "+":
                            if (valueOld == "" || value == "")
                            {
                                textBoxMain.Text = "0";
                                return;
                            }
                            textBoxMain.Text = Convert.ToString(Double.Parse(valueOld) + Double.Parse(value));
                            break;
                        case "-":
                            if (valueOld == "" || value == "")
                            {
                                textBoxMain.Text = "0";
                                return;
                            }
                            textBoxMain.Text = Convert.ToString(Double.Parse(valueOld) - Double.Parse(value));
                            break;
                        case "*":
                            if (valueOld == "" || value == "")
                            {
                                textBoxMain.Text = "0";
                                return;
                            }
                            textBoxMain.Text = Convert.ToString(Double.Parse(valueOld) * Double.Parse(value));
                            break;
                        case "/":
                            if (valueOld == "" || value == "")
                            {
                                textBoxMain.Text = "0";
                                return;
                            }
                            if (Convert.ToDouble(valueOld) == 0)
                            {
                                MessageBox.Show("На 0 делить нельзя", "Деление на 0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            textBoxMain.Text = Convert.ToString(Double.Parse(valueOld) / Double.Parse(value));
                            break;
                        default:
                            textBoxMain.Text = value;
                            break;
                    }
                    text += textBoxMain.Text;
                    ls.Add(text);
                    text = "";
                    valueOld = "";
                    value = textBoxMain.Text;
                    symbol = "=";
                    MyRefresh();
                    break;
                case '+':
                    //valueOld = value;
                    //value = "";
                    //text += valueOld;
                    symbol = "+";
                    //text += symbol;
                    //textBoxMain.Text = "0";
                    break;
                case '-':
                    //valueOld = value;
                    //value = "";
                    //text += valueOld;
                    symbol = "-";
                    //text += symbol;
                    //textBoxMain.Text = "0";
                    break;
                case '*':
                    //valueOld = value;
                    //value = "";
                    //text += valueOld;
                    symbol = "*";
                    //text += symbol;
                    //textBoxMain.Text = "0";
                    break;
                case '/':
                    //valueOld = value;
                    //value = "";
                    //text += valueOld;
                    symbol = "/";
                    //text += symbol;
                    //textBoxMain.Text = "0";
                    break;
                case '%':
                    if (Convert.ToDouble(valueOld) == (double)0.00)
                        value = "0";
                    else 
                        value = Convert.ToString(Double.Parse(valueOld) * 100 / Double.Parse(value));
                    text += valueOld;
                    text += "%";
                    text += value;
                    text += symbol;
                    break;
                default:
                    break;
            }
            listBoxMain.Focus();
            labelSymbol.Text = symbol;
            if (symbol == "=") return;
            if (symbols.IndexOf(symbol) == -1 || value.Length > 0)
                textBoxMain.Text = value;
        }
    }
}
