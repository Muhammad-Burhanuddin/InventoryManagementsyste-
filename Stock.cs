using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventorymanagmentsystem
{
    public partial class Stock : sample2
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            base.edit.Enabled = false;
            base.savebtn.Enabled = false;
            base.Add.Enabled = false;
            base.Deletebtn.Enabled = false;
          
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        Reterival reterival= new Reterival();
        public override void View_Click(object sender, EventArgs e)
        {
            reterival.ShowStock(dataGridView1, proidgv, prondgv, barcodegv, expirygv, bpgv,spgv,categgv);
        }

    }
}
