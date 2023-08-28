using MP_DOWNLOADS.Forms.Videos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_DOWNLOADS
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            flowLayoutPanel1.VerticalScroll.Visible = true;
            flowLayoutPanel1.VerticalScroll.Enabled = true;
            flowLayoutPanel1.VerticalScroll.Value = 0;
            FormVideoDownload formVideos = new FormVideoDownload();
            formVideos.TopLevel = false;
            flowLayoutPanel1.Controls.Add(formVideos);
            FormVideoDownload formVideos2 = new FormVideoDownload();
            formVideos2.TopLevel = false;
            flowLayoutPanel1.Controls.Add(formVideos2);
            FormVideoDownload formVideos3 = new FormVideoDownload();
            formVideos3.TopLevel = false;
            flowLayoutPanel1.Controls.Add(formVideos3);
            FormVideoDownload formVideos4 = new FormVideoDownload();
            formVideos4.TopLevel = false;
            flowLayoutPanel1.Controls.Add(formVideos4);
            FormVideoDownload formVideos5 = new FormVideoDownload();
            formVideos5.TopLevel = false;
            flowLayoutPanel1.Controls.Add(formVideos5);
            FormVideoDownload formVideos6 = new FormVideoDownload();
            formVideos6.TopLevel = false;
            flowLayoutPanel1.Controls.Add(formVideos6);

            
            formVideos.Show();
            formVideos2.Show();
            formVideos3.Show();
            formVideos4.Show();
            formVideos5.Show();
            formVideos6.Show();
        }

        private void guna2VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = guna2VScrollBar1.Value;
        }
    }
}
