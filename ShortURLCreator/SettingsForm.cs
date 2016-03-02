using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShortURLCreator
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtBitlyLogin.Text = Settings.GetBitlyLogin();
            txtBitlyAPIKey.Text = Settings.GetBitlyAPIKey();
            txtKarmacracyUser.Text = Settings.GetKarmacracyUser();
            txtKarmacracyKeypass.Text = Settings.GetKarmacracyKeypass();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Settings.SetBitlyLogin(txtBitlyLogin.Text);
            Settings.SetBitlyAPIKey(txtBitlyAPIKey.Text);
            Settings.SetKarmacracyUser(txtKarmacracyUser.Text);
            Settings.SetKarmacracyKeypass(txtKarmacracyKeypass.Text);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
