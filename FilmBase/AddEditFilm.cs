using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FilmBase
{
    public partial class AddEditFilm : Form
    {
        Form1 form;

        string filename;
        bool isPhoto = false;
        Photos photo;
        Film film;

        public bool IsPhoto { get { return isPhoto; } }
        public Photos getPhoto { get { return photo; } }
        public Film NewFilm { get { return film; } }

        public AddEditFilm(Form1 f)
        {
            InitializeComponent();
            form = f;
            openFileDialog1.Filter = "Image files(*.jpg)|*.jpg";
            UpdateDirList();
            UpdateGenreList();
        }

        public AddEditFilm(Form1 f,Film filmEdit)
        {
            InitializeComponent();
            form = f;
            openFileDialog1.Filter = "Image files(*.jpg)|*.jpg";
            UpdateDirList();
            UpdateGenreList();
        }

        private void UpdateDirList()
        {
            comboBox2_dir.Items.Clear();
            foreach (Director d in form.filmBase.directors)
            {
                comboBox2_dir.Items.Add(d);
            }
            comboBox2_dir.SelectedIndex = 0;
        }

        private void UpdateGenreList()
        {
            comboBox_genre.Items.Clear();
            foreach (Genre d in form.filmBase.genres)
            {
                comboBox_genre.Items.Add(d);
            }
            comboBox_genre.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            filename = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filename);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ChekInfo()) {
                DialogResult = DialogResult.OK;
                film = new Film();
                if (!string.IsNullOrEmpty(filename)) {
                    pictureBox1.Image.Dispose();
                    film.PhotoId = SavePhotoToBase();
                }
                film.Description = textBox_description.Text;
                film.DirectorId = (comboBox2_dir.SelectedItem as Director).DirectorId;
                film.FilmName = textBox_filmname.Text;
                film.FilmYear = dateTimePicker1.Value.Year;
                film.GenreId = (comboBox_genre.SelectedItem as Genre).GenreId;
                film.Rating = numericUpDown1.Value;
                form.filmBase.InsertFilm(film);
            }
            else
            {
                MessageBox.Show("Введите название фильма!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long SavePhotoToBase()
        {
            photo = new Photos(filename);
            return form.filmBase.InsertPhoto(photo);
        }

        private bool ChekInfo()
        {
            string t = textBox_filmname.Text;
            if (string.IsNullOrEmpty(t)) return false;
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dn = textBox_new_dir.Text;
            if (!string.IsNullOrEmpty(dn))
            {
                form.filmBase.InsertDirector(dn);
                UpdateDirList();
                comboBox2_dir.SelectedIndex = comboBox2_dir.FindString(dn);
            }
        }
    }
}
