using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Выпускной_проект1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserForm form = new UserForm();
            form.ShowDialog();

            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
            sumPeriodCombo.SelectedIndex = 0;
            sumAnnuitet.Checked = true;
        }

        private void exitTSMI_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutTSMI1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Архипов И. А. \n2020 г.", "О программе");
        }

        private void insertTimeTSMI_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToShortTimeString() + "\n");
            richTextBox1.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void saveTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog() 
                {
                    DefaultExt = ".rtf",
                    Filter = "Text documents (.rtf)|*.rtf"
                };

                if(dialog.ShowDialog() == DialogResult.OK)
                    richTextBox1.SaveFile(dialog.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message);
            }
        }

        private void loadTSMI_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog()
                {
                    DefaultExt = ".rtf",
                    Filter = "Text documents (.rtf)|*.rtf"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                    richTextBox1.LoadFile(dialog.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string from, to;

            from = listBox1.SelectedItem.ToString(); // 1 список
            to = listBox2.SelectedItem.ToString(); // 2 список

            if(from==to)
            {
                MessageBox.Show("Внимание! Это одна и та же валюта!");
            }
            else if (textBox1.Text=="")
            {
                MessageBox.Show("Введите количество валюты");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + textBox1.Text + "" + from + " %D0%B2 " + to);
            }
        }

        private void dgvGrafik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PaymentScheduleDiffer(double SumCredit, double InterestRateMonth, int CreditPeriod) // Метод расчета Дифференцированного платежа
        {
            double MainPayment = SumCredit / CreditPeriod; // платеж по основному долгу
                                                           // Заполняем график платежей
            double ItogCreditSum = 0;
            double OverPaymentSum = 0;
            for (int i = 0; i < CreditPeriod; ++i)
            {
                double procentPart = SumCredit * InterestRateMonth; //подсчет процентной части ежемесячного платежа
                SumCredit -= MainPayment; //подсчет остатка основного долга (с каждым месяцем уменьшается)
                dgvGrafik.Rows.Add(); //добавляем строку в таблицу
                dgvGrafik[0, i].Value = i + 1; //номер месяца
                dgvGrafik[1, i].Value = (MainPayment + procentPart).ToString("N2"); //полный ежемесячный платеж
                dgvGrafik[2, i].Value = MainPayment.ToString("N2"); //платеж по основному долгу
                dgvGrafik[3, i].Value = procentPart.ToString("N2"); //процентная часть ежемесячного платежа
                dgvGrafik[4, i].Value = SumCredit.ToString("N2"); //Остаток по основному долгу
            }
            for (int i = 0; i < CreditPeriod; ++i) //Подсчет итоговой стоимости и переплаты по кредиту
            {
                ItogCreditSum += Convert.ToDouble(dgvGrafik[1, i].Value);
                OverPaymentSum += Convert.ToDouble(dgvGrafik[3, i].Value);
            }
            double ItogPlus = Convert.ToDouble(dgvGrafik[4, dgvGrafik.RowCount - 1].Value);
            itogSum.Text = ItogCreditSum.ToString("N2");
            itogOverpayment.Text = (OverPaymentSum + ItogPlus).ToString("N2");
            itogPayment.Text = Convert.ToString(dgvGrafik[1, 0].Value) + "..." + Convert.ToString(dgvGrafik[1, dgvGrafik.RowCount - 1].Value);
        }


        private void PaymentScheduleAnnuitet(double SumCredit, double InterestRateYear, double InterestRateMonth, int CreditPeriod)
        {
            double Payment = SumCredit * (InterestRateMonth / (1 - Math.Pow(1 + InterestRateMonth, - CreditPeriod))); //Ежемесячный платеж
            double ItogCreditSum = Payment * CreditPeriod; // Итог сумма
            itogPayment.Text = Payment.ToString("N2"); //Вывод ежемес. платежа
            itogSum.Text = (ItogCreditSum).ToString("N2"); //Вывод итоговой суммы

            double SumCreditOperation = SumCredit;
            double ItogCreditSumOperation = ItogCreditSum;
            double ItogPlus = 0;
            for (int i=0; i<CreditPeriod; ++i)
            {
                double procent = SumCreditOperation * (InterestRateYear / 100) / 12;
                SumCreditOperation -= Payment - procent;
                dgvGrafik.Rows.Add(); //добавление
                dgvGrafik[0, i].Value = i + 1;//месяц
                dgvGrafik[1, i].Value = Payment.ToString("N2");// ежемесячный платеж
                dgvGrafik[2, i].Value = (Payment - procent).ToString("N2");//платеж - основной долг
                dgvGrafik[3, i].Value = procent.ToString("N2");// платеж - процент
                dgvGrafik[4, i].Value=SumCreditOperation.ToString("N2");//основной остаток
                ItogCreditSumOperation -= Payment;
                ItogPlus = Convert.ToDouble(dgvGrafik[4, i].Value);
            }
            itogOverpayment.Text = (ItogCreditSum - SumCredit + ItogPlus).ToString("N2");
        }

       

        private void butSumGo_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(sumCreditSum.Value)<0))
            {
                MessageBox.Show("Сумма кредита не может быть отрицательной или равной нулю.");
                return;
            }
            else
            {
                dgvGrafik.Rows.Clear(); //Очищаем таблицу
                double SumCredit = Convert.ToDouble(sumCreditSum.Text); // Сумма кредита
                double InterestRateYear = Convert.ToDouble(sumProcent.Value); // годовая процентная ставка
                double InterestRateMonth = InterestRateYear / 100 / 12; // месячная роцентная ставка
                int CreditPeriod = Convert.ToInt32(sumPeriod.Value); //Срок кредита, переводим в месяцы, если указан в годах
                     if (sumPeriodCombo.SelectedIndex == 0)
                         CreditPeriod *= 12;
                if (sumAnnuitet.Checked == true)
                {
                    PaymentScheduleAnnuitet(SumCredit, InterestRateYear, InterestRateMonth, CreditPeriod);
                }
                else if (sumDiffer.Checked == true) // Дифференцированный платеж
                {
                    PaymentScheduleDiffer(SumCredit, InterestRateMonth, CreditPeriod);
                }
                butSaveAsCSV.Enabled = true;

            }
        }

        private void butSumClear_Click(object sender, EventArgs e)
        {
            {
                //sumCreditSum.Value = sumCreditSum.Minimum;
                sumProcent.Value = sumProcent.Minimum;
                sumPeriod.Value = sumPeriod.Minimum;
                sumPeriodCombo.SelectedIndex = 0;
                sumCreditSum.Value = sumCreditSum.Minimum;
                sumProcent.Value = sumProcent.Minimum;
                sumPeriod.Value = sumPeriod.Minimum;
                sumPeriodCombo.SelectedIndex = 0;
                itogSum.Clear();
                itogOverpayment.Clear();
                itogPayment.Clear();
                dgvGrafik.Rows.Clear();
                butSaveAsCSV.Enabled = false;
            }
        }

        private void butSaveAsCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTableAsCSV = new SaveFileDialog();
            saveTableAsCSV.Filter = "Документ CSV (*.csv) |*.csv";
            saveTableAsCSV.Title = "Сохранить результат расчетов";
            if (saveTableAsCSV.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTableAsCSV.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write("Итоговая стоимость кредита:" + ";" + itogSum.Text + "\n" );
                    sw.Write("Сумма переплаты:" + ";" + itogOverpayment.Text + "\n");
                    sw.Write("Ежемесячный платеж:" + ";" + itogPayment.Text + "\n");
                    sw.Write("Месяц:" + ";" + "Сумма платежа" + ";" + "Платеж по основному долгу" + ";" + "Платеж по процентам" + ";" + "Остаток основного долга" + ";" + "\n");
                    for (int i = 0; i < dgvGrafik.RowCount; i++)
                    {
                        for (int j = 0; j < dgvGrafik.ColumnCount; j++)
                        {
                            sw.Write(Convert.ToDouble(dgvGrafik.Rows[i].Cells[j].Value));
                            if (j < dgvGrafik.ColumnCount - 1)
                                sw.Write(";");
                        }
                        sw.WriteLine();
                    }
                    sw.Close();
                }
                catch
                {
                    MessageBox.Show("Перезаписываемый файл уже используется другой программой.\nЗакройте его и повторите попытку, либо сохраните как новый файл.", "Ошибка сохранения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCoureUsdEur_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            var xml = client.DownloadString("https://www.cbr-xml-daily.ru/daily.xml");
            XDocument xdoc = XDocument.Parse(xml);
            var el = xdoc.Element("ValCurs").Elements("Valute");
            DateTime date1 = new DateTime();
            //Console.WriteLine(date1);
            string dollar = el.Where(x => x.Attribute("ID").Value == "R01235").Select(x => x.Element("Value").Value).FirstOrDefault();
            string eur = el.Where(x => x.Attribute("ID").Value == "R01239").Select(x => x.Element("Value").Value).FirstOrDefault();
            string FuntSterl = el.Where(x => x.Attribute("ID").Value == "R01035").Select(x => x.Element("Value").Value).FirstOrDefault();
            MessageBox.Show($"На сегодня, {DateTime.Now} курс валют по отношению к рублю составляет \n Евро: {eur}, \n Доллар: {dollar}, \n Фунт стерлингов: {FuntSterl}");
        
         }
    }
}
