using System;
using System.Windows.Forms;

namespace DocumentStorage.Forms
{
    public partial class Autentification : Form
    {
        public Autentification()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Смена языка.
        /// </summary>
        private void Autentification_InputLanguageChanged(object sender, InputLanguageChangedEventArgs e) => Lan.Text = InputLanguage.CurrentInputLanguage.LayoutName;

        /// <summary>
        /// При загрузке формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Autentification_Load(object sender, EventArgs e) => Lan.Text = InputLanguage.CurrentInputLanguage.LayoutName;

        /// <summary>
        /// Вход.
        /// </summary>
        private void btNext_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = maskedTB.Text;
            if (login == "" | password == "")
            {
                MessageBox.Show("Не указаны данные для входа.", "Хранилище документов", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                new MainForm().Show();
                Hide();
            }
        }
    }
}
