using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace Выпускной_проект1
{
    public partial class FormGP : Form
    {
        private string _digits = "0123456789";
        private string _characters = "abcdefghijklmnopqrstuvwxyz";
        private string _specialChars = "!#@%$?*&";
        private PasswordGenerator _generator = new PasswordGenerator();
 
        public FormGP()
        {
            InitializeComponent();
        }

        private void btnCreatePass_Click_1(object sender, EventArgs e)
        {
            if (clbPass.CheckedItems.Count == 0) 
            {
                MessageBox.Show("Не выбран ни один вариант для генерации пароля.\r\n Выберите один или несколько вариантов и попробуйте снова");
                return; 
            }

            var builder = new StringBuilder();

            if (clbPass.GetItemCheckState(0) == CheckState.Checked)
                builder.Append(_digits);

            if (clbPass.GetItemCheckState(1) == CheckState.Checked)
                builder.Append(_characters);

            if (clbPass.GetItemCheckState(2) == CheckState.Checked)
                builder.Append(_characters.ToUpper());

            if (clbPass.GetItemCheckState(3) == CheckState.Checked)
                builder.Append(_specialChars);

            var password = _generator.GeneratePassword(builder.ToString(), (int)nudPassL.Value);
            tPass.Text = password;
            Clipboard.SetText(password);
            MessageBox.Show("Пароль успешно скопирован в буффер обмена");
            Close();
            builder = null;
        }
    }
}
