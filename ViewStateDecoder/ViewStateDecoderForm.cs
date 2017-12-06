using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ViewStateDecoder
{
    public partial class Frm_ViewStateDecoder : Form
    {
        public Frm_ViewStateDecoder()
        {
            InitializeComponent();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            // parse the viewState
            StringWriter writer = new StringWriter();
            ViewStateParser p = new ViewStateParser(writer);

            p.ParseViewStateGraph(txtViewState.Text);
            txtDecodedBox.Text = writer.ToString();
        }
    }
}
