using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Выпускной_проект1
{
    public partial class UserForm : Form
    {
        // Путь к файлу где сохраняются данные о пользователях
        private string _usersFileName = Environment.CurrentDirectory + "\\users.json";

        // Хранилище пользователей
        private UsersStorage _users = new UsersStorage();

        public UserForm()
        {
            InitializeComponent();
            _users = DeserializeUsers();
        }

        private UsersStorage DeserializeUsers()
        {
            try
            {
                if (!File.Exists(_usersFileName))
                    return new UsersStorage();

                var jsonString = File.ReadAllText(_usersFileName);
                return Serializer<UsersStorage>.DeSerializeFromString(jsonString);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка загрузки пользователей.\r\n" + ex.Message);
                return null;
            }
        }

        private void SerializeUsers()
        {
            var jsonString = Serializer<UsersStorage>.SerializeToString(_users);
            File.WriteAllText(_usersFileName, jsonString);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_users.CheckPassword(loginTextBox.Text, passwordTextBox.Text))
                {
                    Close();
                }
                else
                    MessageBox.Show("Неверный пароль!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка входа в систему: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            try
            {
                _users.AddUser(loginTextBox.Text, passwordTextBox.Text);
                passwordTextBox.Text = string.Empty;
                MessageBox.Show("Вы зарегистрированы!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления пользователя: " + ex.Message);
            }
            
        }

        private void btnCreatePass_Click(object sender, EventArgs e)
        {
            FormGP frm = new FormGP();
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeUsers();
        }
    }
}






