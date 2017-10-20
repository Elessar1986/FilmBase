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

namespace FilmBase
{
    public partial class Form1 : Form
    {
        public MyFilmBase filmBase = new MyFilmBase();

        public Form1()
        {
            InitializeComponent();
           
            UpdateFilmList();
            UpdateDirectorsList();
            UpdateGenreList();
            
        }

        private void UpdateGenreList()
        {
            comboBox_genre.Items.Clear();
            foreach (Genre g in filmBase.genres)
            {
                comboBox_genre.Items.Add(g);
            }
            comboBox_genre.SelectedIndex = 0;
        }

        private void UpdateDirectorsList()
        {
            comboBox_director.Items.Clear();
            foreach (Director d in filmBase.directors)
            {
                comboBox_director.Items.Add(d);
            }
            comboBox_director.SelectedIndex = 0;
        }

        private void UpdateFilmList()
        {
            FilmsView.Items.Clear();
            foreach (Film f in filmBase.films)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = f.FilmName;
                lvi.Tag = f.FilmId;
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi,filmBase.genres.Where(x => x.GenreId == f.GenreId).Select(x => x.GenreName).ToArray()[0]));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, f.FilmYear.ToString()));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, filmBase.directors.Where(x => x.DirectorId == f.DirectorId).Select(x => x.DirectorName).ToArray()[0]));
                lvi.SubItems.Add(new ListViewItem.ListViewSubItem(lvi, f.Rating.ToString()));
                FilmsView.Items.Add(lvi);
            }
            
        }


        private void FilmsView_MouseClick(object sender, MouseEventArgs e)
        {
            if (FilmsView.SelectedIndices[0] != -1)
            {
               // MessageBox.Show(FilmsView.SelectedItems[0].Tag.ToString());
                Film f = filmBase.films.Where(x => x.FilmId == (long)FilmsView.SelectedItems[0].Tag).ToArray()[0];
                Photos ph = filmBase.getPhotoById(f.PhotoId);
                if (ph != null)
                {
                    using (MemoryStream ms = new MemoryStream(ph.PhotoData.Length))
                    {
                        ms.Write(ph.PhotoData, 0, ph.PhotoData.Length);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                
                label_filmname.Text = f.FilmName;
                textBox1.Text = f.Description;
                label_director.Text = filmBase.directors.Where(x => x.DirectorId == f.DirectorId).Select(x => x.DirectorName).ToArray()[0];
                label_genre.Text = filmBase.genres.Where(x => x.GenreId == f.GenreId).Select(x => x.GenreName).ToArray()[0];
                label_year.Text = f.FilmYear.ToString();
                label_rate.Text = f.Rating.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditFilm addFilm = new AddEditFilm(this);
            addFilm.ShowDialog();
            if(addFilm.DialogResult == DialogResult.OK)
            {
                UpdateFilmList();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SortFilm();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker1_ValueChanged(sender, e);
            }
            if (checkBox2.CheckState == CheckState.Unchecked)
            {
                dateTimePicker1.Enabled = false;
                SortFilm();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.CheckState == CheckState.Checked)
            {
                comboBox_director.Enabled = true;
                SortFilm();
            }
            else
            {
                comboBox_director.Enabled = false;
                SortFilm();
            }
        }



        private void comboBox_director_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SortFilm();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                comboBox_genre.Enabled = true;
                SortFilm();
            }
            else
            {
                comboBox_genre.Enabled = false;
                SortFilm();
            }
        }

        private void comboBox_genre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SortFilm();
        }

        private void SortFilm()
        {
            filmBase.UpdateFilmData();
            if (checkBox1.CheckState == CheckState.Checked) filmBase.getFilmsByGenre((comboBox_genre.SelectedItem as Genre).GenreId);
            if (checkBox2.CheckState == CheckState.Checked) filmBase.getFilmsByYear(dateTimePicker1.Value.Year);
            if (checkBox3.CheckState == CheckState.Checked) filmBase.getFilmsByDirector((comboBox_director.SelectedItem as Director).DirectorId);
            UpdateFilmList();
        }

        private void FilmsView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (e.Column)
            {
                case 0:
                    filmBase.OrderByName();
                    break;
                case 1:
                    filmBase.OrderByGenre();
                    break;
                case 2:
                    filmBase.OrderByYear();
                    break;
                case 3:
                    filmBase.OrderByDirector();
                    break;
                case 4:
                    filmBase.OrderByRate();
                    break;
                default:
                    break;
            }
            UpdateFilmList();

        }

    }
}
