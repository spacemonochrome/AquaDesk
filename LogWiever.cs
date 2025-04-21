using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AUV_UI
{
    public partial class LogWiever : Form
    {
        public LogWiever(string gelen)
        {
            InitializeComponent();
            textBox1.Text = gelen;
        }
    }
}
