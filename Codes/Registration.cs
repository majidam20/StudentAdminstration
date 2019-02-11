using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 

namespace StudentAdministration.UIL
{
    public partial class RegistrationForm : Form
    {
        
        public RegistrationForm()
        {
            InitializeComponent();
        }
  

        private void btnAdd_Click(object sender, EventArgs e)
        {
            albumclass ac = new albumclass();
            DataTable dt = new DataTable();
            ac.Add(txtid.Text,)
        
        }

        
}
