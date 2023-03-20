using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Advanced
{
    public partial class frmTBGiaoVien : Form
    {
        public frmTBGiaoVien()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblThongBao_Click.Text = s;
        }
        private void frmTBGiaoVien_Load(object sender, EventArgs e)
        {

        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            
            
            this.ClientSize = new System.Drawing.Size(786, 543);
            this.Name = "frmTBGiaoVien";
            this.ResumeLayout(false);

        }
    }
}