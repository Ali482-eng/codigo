using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class FormCompraTicket : Form
    {
        public FormCompraTicket()
        {
            InitializeComponent();
        }

        private void btnCantTicket_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the subMenuTickets
            if (subMenuTickets.Visible)
            {
                // If the submenu is visible, hide it
                subMenuTickets.Visible = false;
            }
            else
            {
                // If the submenu is hidden, make it visible
                subMenuTickets.Visible = true;
            }
        }
    }
}
