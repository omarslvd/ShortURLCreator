using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShortURLCreator
{
    public partial class MainForm : Form
    {
        #region Private Fields

        private ProviderBase provider;

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            mnuProviders.Renderer = new VS2008MenuRenderer();
            lblResult.Text = "";
            txtLongURL.Image = imlIcons.Images["TinyURL"];
            provider = GetProvider("TinyURL");
            if (Clipboard.ContainsText())
                txtLongURL.Text = Clipboard.GetText();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        #endregion

        #region Controls Events

        private void btnMake_Click(object sender, System.EventArgs e)
        {
            string result = "No result";

            if (provider != null)
                result = provider.GetShortURL(txtLongURL.Text);

            lblResult.Text = result;
            Clipboard.SetText(result);
        }

        private void mnuProviders_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tinyURLToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["TinyURL"];
                    provider = GetProvider("TinyURL");
                    break;
                case "tinyArrowsToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["TinyArro.ws"];
                    provider = GetProvider("TinyArro.ws");
                    break;
                case "bitlyToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["Bit.ly"];
                    provider = GetProvider("Bit.ly");
                    break;
                case "kissabeToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["kissa.be"];
                    provider = GetProvider("kissa.be");
                    break;
                case "isgdToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["is.gd"];
                    provider = GetProvider("is.gd");
                    break;
                case "trimToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["tr.im"];
                    provider = GetProvider("tr.im");
                    break;
                case "cortasToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["Cort.as"];
                    provider = GetProvider("Cort.as");
                    break;
                case "unuToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["u.nu"];
                    provider = GetProvider("u.nu");
                    break;
                case "karmacracyToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["Karmacracy"];
                    provider = GetProvider("Karmacracy");
                    break;
            }
        }

        private void txtLongURL_ImageClick(object sender, EventArgs e)
        {
            //mnuProviders.Show(this, new Point(txtLongURL.Location.X, txtLongURL.Location.Y + txtLongURL.Height));
            txtLongURL.Focus();
            toolBar1.Visible = true;
        }

        private void picSettings_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
        }

        #endregion

        #region Private Methods

        private ProviderBase GetProvider(string providerName)
        {
            switch (providerName)
            {
                case "TinyURL":
                    return new TinyURLProvider();
                case "TinyArro.ws":
                    return new TinyArrowsProvider();
                case "Bit.ly":
                    return new BitlyProvider();
                case "kissa.be":
                    return new KissabeProvider();
                case "is.gd":
                    return new IsgdProvider();
                case "tr.im":
                    return new TrimProvider();
                case "Cort.as":
                    return new CortasProvider();
                case "u.nu":
                    return new UnuProvider();
                case "Karmacracy":
                    return new KarmacracyProvider();
            }
            return null;
        }

        #endregion

        private void txtLongURL_Click(object sender, EventArgs e)
        {
            toolBar1.Visible = true;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            btnMake.Focus();
        }

        private void txtLongURL_Leave(object sender, EventArgs e)
        {
            toolBar1.Visible = false;
        }

        private void toolBar1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "tinyURLToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["TinyURL"];
                    provider = GetProvider("TinyURL");
                    break;
                case "tinyArrowsToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["TinyArro.ws"];
                    provider = GetProvider("TinyArro.ws");
                    break;
                case "bitlyToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["Bit.ly"];
                    provider = GetProvider("Bit.ly");
                    break;
                case "kissabeToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["kissa.be"];
                    provider = GetProvider("kissa.be");
                    break;
                case "isgdToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["is.gd"];
                    provider = GetProvider("is.gd");
                    break;
                case "trimToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["tr.im"];
                    provider = GetProvider("tr.im");
                    break;
                case "cortasToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["Cort.as"];
                    provider = GetProvider("Cort.as");
                    break;
                case "unuToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["u.nu"];
                    provider = GetProvider("u.nu");
                    break;
                case "karmacracyToolStripMenuItem":
                    txtLongURL.Image = imlIcons.Images["Karmacracy"];
                    provider = GetProvider("Karmacracy");
                    break;
            }
            toolBar1.Visible = false;
        }
    }
}
