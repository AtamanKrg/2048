using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class RulesForm : Form
    {
        private string path = "rules.txt";
        public RulesForm()
        {
            InitializeComponent();
        }
    }
}
