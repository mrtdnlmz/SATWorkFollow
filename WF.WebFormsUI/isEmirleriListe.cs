using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF.Business.Concrete;
using WFEntities.Concrete;

namespace WF.WebFormsUI
{
    public partial class isEmirleriListe : Form
    {
        public isEmirleriListe()
        {
            InitializeComponent();
        }

        private void isEmirleriListe_Load(object sender, EventArgs e)
        {

            
            dgwisEmri.DataSource = Takip.GetAll();
        }
    }
}
