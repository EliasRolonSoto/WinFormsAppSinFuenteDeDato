using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAppSinFuenteDeDato
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }


        private void PopulateDataGridView()
        {

            string[] row0 = { "22/11/1968", "29", "Revolution 9",
        "Beatles", "The Beatles [White Album]" };
            string[] row1 = { "1960", "6", "Fools Rush In",
        "Frank Sinatra", "Nice 'N' Easy" };
            string[] row2 = { "11/11/1971", "1", "One of These Days",
        "Pink Floyd", "Meddle" };
            string[] row3 = { "1988", "7", "Where Is My Mind?",
        "Pixies", "Surfer Rosa" };
            string[] row4 = { "5/1981", "9", "Can't Find My Mind",
        "Cramps", "Psychedelic Jungle" };
            string[] row5 = { "10/6/2003", "13",
        "Scatterbrain. (As Dead As Leaves.)",
        "Radiohead", "Hail to the Thief" };
            string[] row6 = { "30/6/1992", "3", "Dress", "P J Harvey", "Dry" };

            songsDataGridView.Rows.Add(row0);
            songsDataGridView.Rows.Add(row1);
            songsDataGridView.Rows.Add(row2);
            songsDataGridView.Rows.Add(row3);
            songsDataGridView.Rows.Add(row4);
            songsDataGridView.Rows.Add(row5);
            songsDataGridView.Rows.Add(row6);

            songsDataGridView.Columns[0].DisplayIndex = 0;
            songsDataGridView.Columns[1].DisplayIndex = 1;
            songsDataGridView.Columns[2].DisplayIndex = 2;
            songsDataGridView.Columns[3].DisplayIndex = 3;
            songsDataGridView.Columns[4].DisplayIndex = 4;
        }
        //comentario de onda
        private void addNewRowButton_Click(object sender, EventArgs e)
        {
            this.songsDataGridView.Rows.Add();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.songsDataGridView.SelectedRows.Count > 0 &&
                this.songsDataGridView.SelectedRows[0].Index !=
                this.songsDataGridView.Rows.Count - 1)
            {
                this.songsDataGridView.Rows.RemoveAt(
                    this.songsDataGridView.SelectedRows[0].Index);
            }
        }

        private void songsDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e != null)
            {
                if (this.songsDataGridView.Columns[e.ColumnIndex].Name == "Column1")
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString())
                                .ToLongDateString();
                            e.FormattingApplied = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
                        }
                    }
                }
            }
        }
    }
}