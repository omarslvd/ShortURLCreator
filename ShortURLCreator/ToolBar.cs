using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShortURLCreator
{
    public partial class ToolBar : UserControl
    {
        public event ToolStripItemClickedEventHandler ItemClicked;

        public ToolBar()
        {
            InitializeComponent();
            toolStrip1.Renderer = new VS2008ToolStripRenderer();
        }

        protected virtual void OnItemClicked(ToolStripItemClickedEventArgs e)
        {
            if (ItemClicked != null)
                ItemClicked(this, e);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            OnItemClicked(e);
        }
    }
}
