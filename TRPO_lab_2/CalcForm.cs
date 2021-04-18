using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRPO_lab_2
{
    public partial class CalcForm : Form
    {
        //контроллер перевода систем счисления и истории
        Utils.Calc_Control control = new Utils.Calc_Control();

        public CalcForm()
        {
            InitializeComponent();


            //добавления слушателя на все кнопки, для ввода чисел
            foreach (var button in Controls.OfType<Button>())
                button.Click += button_Click;

            UpdateUI();
        }


        //ввод чисел с кнопок
        private void button_Click(object sender, EventArgs eventArgs)
        {
            var text = ((Button)sender).Text;

            var isNumeric = int.TryParse(text, out int n);
            var isLetter = text.Length == 1 && Utils.Extensions.IsLetter(text[0]);
            var isOperand = text.Length == 1 && Utils.Extensions.IsOperand(text[0]);
            var isPower = text.Equals("1/x") || text.Equals("x^2");

            if (isNumeric || isLetter)
            {
                control.AddDigit(text[0]);
                UpdateUI();
            } else if (isOperand)
            {
                control.SetOperation(Utils.Extensions.GetOperand(text[0]));
                UpdateUI();
            } else if (isPower)
            {
                control.SetFunction(Utils.Extensions.GetFunction(text));
                UpdateUI();
            }
        }

        //метод обновления интерфейса, вызываемый при обновлении данных, производящий вычисления
        private void UpdateUI()
        {
            if (numericFrom.Value != control.GetPIn())
                numericFrom.Value = control.GetPIn();

            if (textBoxFrom.Text != control.GetNumber())
                textBoxFrom.Text = control.GetNumber();

            labelMemUsed.Visible = !control.IsMemEmpty();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            control.Clear();
            UpdateUI();
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            control.AddDelim();
            UpdateUI();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            control.Bs();
            UpdateUI();
        }

        //обработка изменения поля системы исходного числа
        private void numericFrom_ValueChanged(object sender, EventArgs e)
        {
            //установка новой СС числа
            control.SetPIn((int)numericFrom.Value);
            UpdateUI();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            control.ClearMem();
            UpdateUI();
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            control.ReadMem();
            UpdateUI();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            control.SaveMem();
            UpdateUI();
        }

        private void buttonMP_Click(object sender, EventArgs e)
        {
            control.PlusMem();
            UpdateUI();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            try
            {
                control.Calculate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UpdateUI();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcHistoryForm historyForm = new CalcHistoryForm(control);
            historyForm.ShowDialog();
            UpdateUI();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcFAQForm faqForm = new CalcFAQForm();
            faqForm.Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelAcuracy.Text = "Точность: " + trackBar1.Value;
            control.acuracy = trackBar1.Value;
        }

        private void конвертерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConverterForm form = new ConverterForm();
            form.Show();
        }
    }
}
