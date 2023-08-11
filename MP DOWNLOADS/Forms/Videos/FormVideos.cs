using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP_DOWNLOADS.Forms.Videos
{
    public partial class FormVideos : Form
    {
        public FormVideos()
        {
            InitializeComponent();
            FormVideoDownload video = new FormVideoDownload();
            video.TopLevel = false;
            guna2Panel1.Controls.Add(video);
            video.Show();

            FormVideoDownload video2 = new FormVideoDownload();
            video2.TopLevel = false;
            video2.Top = 200;
            guna2Panel1.Controls.Add(video2);
            video2.Show();
        }
    }
}
