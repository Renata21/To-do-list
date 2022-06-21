using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace To_do_list
{
    public partial class Lista : Form
    {
        DataTable lista;

        public Lista()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lista = new DataTable();
            lista.Columns.Add("Status", typeof(bool));
            lista.Columns.Add("To do", typeof(string));
            lista.Columns.Add("Detalii", typeof(string));
            lista.Columns.Add("Termen", typeof(DateTime));

            dataGridView1.DataSource = lista;
            dataGridView1.Columns["Detalii"].Visible = false;

            //lista.Rows.Add(false, "Primul meu to do", "Aici avem detaliile despre sarcina", DateTime.Today);
            lista = citire_fisier(lista);
        }

        private DataTable citire_fisier(DataTable lista)
        {
            string file = @"D:\Google Drive\School\Anul 3\Programarea Vizuala\Individual\To do list\Sarcini.txt";
            
            if (File.Exists(file))
            {
                bool status = false;
                string to_do = "", detalii = "";
                DateTime termen = DateTime.Today;
                
                string[] lines = File.ReadAllLines(file);

                for (int j = 1, s = 0; j <= 4 && s < lines.Length; j++, s++)
                {
                    if (j == 1)
                        status = bool.Parse(lines[s]);

                    else if (j == 2)
                        to_do = lines[s];

                    else if (j == 3)
                        detalii = lines[s];

                    else if (j == 4)
                    {
                        termen = DateTime.ParseExact(lines[s], @"M/d/yyyy h:mm:ss tt", System.Globalization.CultureInfo.InvariantCulture);
                        j = 0;
                        lista.Rows.Add(status, to_do, detalii, termen);
                    }
                }
            }

            return lista;
        }

        private void scriere_fisier(DataTable lista)
        {
            string file = @"D:\Google Drive\School\Anul 3\Programarea Vizuala\Individual\To do list\Sarcini.txt";
            File.Delete(file);
            // To append text to a file
            for (int i = 0; i < lista.Rows.Count; i++)
            {

                string status = lista.Rows[i]["Status"].ToString();
                string to_do = lista.Rows[i]["To do"].ToString();
                string detalii = lista.Rows[i]["Detalii"].ToString();
                string termen = lista.Rows[i]["Termen"].ToString();
                File.AppendAllText(file, status + '\n' + to_do + '\n' + detalii + '\n' + termen + '\n');
            }
        }

        private void button_new_Click(object sender, EventArgs e)
        {
            Form f = new To_do_nou();
            f.ShowDialog();
            bool adauga = ((To_do_nou) f).trimite_date;
            if (adauga)
            {
                string a_text_toDo = ((To_do_nou) f).text_toDo.Text;
                string a_text_detalii = ((To_do_nou) f).text_detalii2.Text;
                DateTime a_dateTimePicker_termen = ((To_do_nou) f).dateTimePicker_termen.Value;
                MessageBox.Show("To do: " + a_text_toDo + "\nDetalii: " + a_text_detalii + "\nTermen: " + a_dateTimePicker_termen, "To do adaugat: ");
                lista.Rows.Add(false, a_text_toDo, a_text_detalii, a_dateTimePicker_termen);
            }
            else
                MessageBox.Show("Ati anulat crearea unui to do nou.");
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                MessageBox.Show("To do: " + lista.Rows[index]["To do"].ToString() + "\nDetalii: " + lista.Rows[index]["Detalii"].ToString() + "\nTermen: " + lista.Rows[index]["Termen"].ToString(), "To do selectat");
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DialogResult verificare = MessageBox.Show("Sunteti siguri ca doriti sa stergeti? ", "Verificare", MessageBoxButtons.YesNo);
            if (verificare == DialogResult.Yes)
            {
                lista.Rows[index].Delete();
            }
            else if (verificare == DialogResult.No)
            {
                MessageBox.Show("Ati anulat stergerea.", "Anulare");
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                Form f = new To_do_nou
                {
                    Text = "Editare to do"
                };

                ((To_do_nou) f).text_toDo.Text = lista.Rows[index]["To do"].ToString();
                ((To_do_nou) f).text_detalii2.Text = lista.Rows[index]["Detalii"].ToString();
                ((To_do_nou) f).dateTimePicker_termen.Value = Convert.ToDateTime(lista.Rows[index]["Termen"].ToString());

                f.ShowDialog();

                bool modifica = ((To_do_nou) f).trimite_date;
                if (modifica)
                {
                    string a_text_toDo = ((To_do_nou) f).text_toDo.Text;
                    string a_text_detalii = ((To_do_nou) f).text_detalii2.Text;
                    DateTime a_dateTimePicker_termen = ((To_do_nou) f).dateTimePicker_termen.Value;

                    lista.Rows[index]["To do"] = a_text_toDo;
                    lista.Rows[index]["Detalii"] = a_text_detalii;
                    lista.Rows[index]["Termen"] = a_dateTimePicker_termen;

                    MessageBox.Show("To do: " + a_text_toDo + "\nDetalii: " + a_text_detalii + "\nTermen: " + a_dateTimePicker_termen, "To do modificat: ");
                }
                else
                    MessageBox.Show("Ati anulat editarea.", "Anulare");
            }

        }

        private void modificare_afisare(object sender, EventArgs e)
        {
            if (comboBox_afizeazaToDoTerminat.SelectedIndex == 1)
            {
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    if (lista.Rows[i]["Status"].Equals(true))
                    {
                        dataGridView1.CurrentCell = null;
                        dataGridView1.Rows[i].Visible = false;
                    }
                }
            }
            else if (comboBox_afizeazaToDoTerminat.SelectedIndex == 0)
            {
                for (int i = 0; i < lista.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Visible == false)
                        dataGridView1.Rows[i].Visible = true;

                }
            }
        }

        private void inchidere_form(object sender, FormClosingEventArgs e)
        {
            DialogResult verificare = MessageBox.Show("Sigur doriti sa iesiti?", "Verificare", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (verificare == DialogResult.Cancel)
            {
                MessageBox.Show("Ati anulat inchiderea.");
                e.Cancel = true;
            }
            else
            {
                scriere_fisier(lista);
                MessageBox.Show("Sa aveti o zi productiva!");
            }
        }
    }
}
