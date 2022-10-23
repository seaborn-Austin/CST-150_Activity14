using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_Activity14
{
    public partial class coffeeBarFrm : Form
    {
        public coffeeBarFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (drinkListBox.SelectedIndex == 0 && iceRadioBtn.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED COFFEE";
            }
            else if (drinkListBox.SelectedIndex == 0 && hotRadioBtn.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT COFFEE";
            }
            if (drinkListBox.SelectedIndex == 1 && iceRadioBtn.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED TEA";
            }
            else if (drinkListBox.SelectedIndex == 1 && hotRadioBtn.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT TEA";
            }
            if (drinkListBox.SelectedIndex == 0 && iceRadioBtn.Checked && milkCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED COFFEE WITH MILK";
            }
            else if (drinkListBox.SelectedIndex == 0 && hotRadioBtn.Checked && milkCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT COFFEE WITH MILK";
            }
            if (drinkListBox.SelectedIndex == 1 && iceRadioBtn.Checked && milkCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED TEA WITH MILK";
            }
            else if (drinkListBox.SelectedIndex == 1 && hotRadioBtn.Checked && milkCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT TEA WITH MILK";
            }
            if (drinkListBox.SelectedIndex == 0 && iceRadioBtn.Checked && milkCheckBox.Checked
                && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED COFFEE WITH MILK AND VANILLA SYRUP";
            }
            else if (drinkListBox.SelectedIndex == 0 && hotRadioBtn.Checked && milkCheckBox.Checked
                    && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT COFFEE WITH MILK AND VANILLA SYRUP";
            }
            if (drinkListBox.SelectedIndex == 1 && iceRadioBtn.Checked && milkCheckBox.Checked
                && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED TEA WITH MILK AND VANILLA SYRUP";
            }
            else if (drinkListBox.SelectedIndex == 1 && hotRadioBtn.Checked && milkCheckBox.Checked
                    && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT TEA WITH MILK AND VANILLA SYRUP";
            }

            if (drinkListBox.SelectedIndex == 0 && iceRadioBtn.Checked && milkCheckBox.Checked
                && vanillaSyrupCheckBox.Checked && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED COFFEE WITH MILK, SUGAR, AND VANILLA SYRUP";
            }
            else if (drinkListBox.SelectedIndex == 0 && hotRadioBtn.Checked && milkCheckBox.Checked
                    && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT COFFEE WITH MILK, SUGAR, AND VANILLA SYRUP";
            }
            if (drinkListBox.SelectedIndex == 1 && iceRadioBtn.Checked && milkCheckBox.Checked
                && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED TEA WITH MILK, SUGAR, AND VANILLA SYRUP";
            }
            else if (drinkListBox.SelectedIndex == 1 && hotRadioBtn.Checked && milkCheckBox.Checked
                    && vanillaSyrupCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT TEA WITH MILK, SUGAR, AND VANILLA SYRUP";
            }

            if (drinkListBox.SelectedIndex == 0 && iceRadioBtn.Checked && milkCheckBox.Checked
                && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED COFFEE WITH MILK AND SUGAR";
            }
            else if (drinkListBox.SelectedIndex == 0 && hotRadioBtn.Checked && milkCheckBox.Checked
                    && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT COFFEE WITH MILK AND SUGAR";
            }
            if (drinkListBox.SelectedIndex == 1 && iceRadioBtn.Checked && milkCheckBox.Checked
                && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED TEA WITH MILK AND SUGAR";
            }
            else if (drinkListBox.SelectedIndex == 1 && hotRadioBtn.Checked && milkCheckBox.Checked
                    && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT TEA WITH MILK AND SUGAR";
            }

            if (drinkListBox.SelectedIndex == 0 && iceRadioBtn.Checked && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED COFFEE WITH SUGAR";
            }
            else if (drinkListBox.SelectedIndex == 0 && hotRadioBtn.Checked && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT COFFEE WITH SUGAR";
            }
            if (drinkListBox.SelectedIndex == 1 && iceRadioBtn.Checked && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n ICED TEA WITH SUGAR";
            }
            else if (drinkListBox.SelectedIndex == 1 && hotRadioBtn.Checked && sugarCheckBox.Checked)
            {
                orderTxt.Text = "Order has been created. \n\n HOT TEA WITH SUGAR";
            }
        }
    }
}
