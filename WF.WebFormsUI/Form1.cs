using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF.Business.Abstract;
using WF.Business.Concrete;
using WF.DataAccess.Concrete.EntityFramework;

namespace WF.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _personelServis = new PersonelManager(new EfPersonelDal());
        }

        private IPersonelServis _personelServis;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgwPersonel.DataSource = _personelServis.GetAll();

        


        }
    }
}
