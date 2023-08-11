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
            FormVideos formVideos = new FormVideos();
            formVideos.TopLevel = false;
            guna2Panel1.Controls.Add(formVideos);
            formVideos.Show();
        }
    }
}
