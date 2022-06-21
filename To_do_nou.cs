using System.Windows.Forms;

namespace To_do_list
{
    public partial class To_do_nou : Form
    {
        public bool trimite_date = false;
       
        public To_do_nou()
        {
            InitializeComponent();
            dateTimePicker_termen.Value = System.DateTime.Now;
            
        }

        private void button_save_Click(object sender, System.EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(text_toDo.Text))
            {
                trimite_date = true;
            }
            else
            {
                MessageBox.Show("Nu puteti avea un to do gol.", "Exceptie");
            }
            
            this.Close();
        }

        private void button_cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
