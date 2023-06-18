using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
    public partial class Dashboard : Form
    {
        // private by default
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();
            
            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages;
        }

        private void addMessage_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageText.Text))
            {
                MessageBox.Show("Please enter a message.",
                    "Blank Message Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageText.Text);
                messageText.Text = string.Empty;
            }
            
            messageText.Focus();
        }
    }
}
