using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuyenCaesar_Click(object sender, EventArgs e)
        {
            if (txtCaesar.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaesar.Focus();
                return;
            }
            txtMaCaesar.Text = Caesar.Mahoa(txtCaesar.Text, int.Parse(cbxKeyCaesar.Text));
        }

        private void BtnDichCaesar_Click(object sender, EventArgs e)
        {
            if (txtMaCaesar.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập văn bản mã hóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaCaesar.Focus();
                return;
            }
            txtCaesar.Text = Caesar.GiaiMa(txtMaCaesar.Text, int.Parse(cbxKeyCaesar.Text));
        }
    }
}
