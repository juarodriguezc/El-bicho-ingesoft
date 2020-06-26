using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chatbottest1
{
    public partial class Form_add_event : Form
    {
        public Form_add_event()
        {
            InitializeComponent();
        }

        

        private void Form_add_event_Load(object sender, EventArgs e)
        {
            pick_fecha_evento.MinDate = DateTime.Now;
        }

        private void pick_fecha_nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pick_fecha_evento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void llenarUsuarios()
        {
            

        }
    }
}
