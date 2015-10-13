using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form, View
    {
        Model model;
        Controller controller;

        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }
        public void Notify(Model m)
        {
            lblScore.Text = ((TwoZeroFourEightModel)m).score.ToString();
        }
        
        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
