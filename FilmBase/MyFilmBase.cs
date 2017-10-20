using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace FilmBase
{
    public class MyFilmBase
    {

        SQLiteConnection con = new SQLiteConnection();
        SQLiteDataAdapter adapterFilm;
        SQLiteDataAdapter adapterGenre;
        SQLiteDataAdapter adapterDirector;
        SQLiteDataAdapter adapterPhoto;
        SQLiteCommand com = new SQLiteCommand();
        SQLiteConnectionStringBuilder csb = new SQLiteConnectionStringBuilder();
        DataTable FilmTable = new DataTable("Films");
        DataTable GenreTable = new DataTable("Genre");
        DataTable DirectorTable = new DataTable("Director");
        DataTable PhotoTable = new DataTable("Photo");

        public List<Genre> genres = new List<Genre>();
        public List<Director> directors = new List<Director>();
        public List<Film> films = new List<Film>();

        //public List<Film> sortedFilms = new List<Film>();
        


        public MyFilmBase()
        {
            csb.DataSource = $"FilmBase.db3";
            con = new SQLiteConnection(csb.ConnectionString);
                try
                {
                    con.Open();
                    com = new SQLiteCommand(con);
                    adapterGenre = new SQLiteDataAdapter($"SELECT * FROM Genre", con);
                    adapterGenre.Fill(GenreTable);
                    SQLiteCommandBuilder cb = new SQLiteCommandBuilder(adapterGenre);

                    adapterDirector = new SQLiteDataAdapter($"SELECT * FROM Director",con);
                    adapterDirector.Fill(DirectorTable);
                    cb = new SQLiteCommandBuilder(adapterDirector);

                    adapterFilm = new SQLiteDataAdapter($"SELECT * FROM Films",con);
                    adapterFilm.Fill(FilmTable);
                    
                    cb = new SQLiteCommandBuilder(adapterFilm);


                    adapterPhoto = new SQLiteDataAdapter($"SELECT * FROM Photos",con);
                    adapterPhoto.Fill(PhotoTable);
                    cb = new SQLiteCommandBuilder(adapterPhoto);


                    UpdateDirectorData();
                    UpdateGenreData();
                    UpdateFilmData();
                    
                }
                catch (SQLiteException ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
        }

        public void OrderByYear()
        {
            films = films.OrderBy(x => x.FilmYear).ToList();
        }
        public void OrderByName()
        {
            films = films.OrderBy(x => x.FilmName).ToList();
        }
        public void OrderByDirector()
        {
            films = films.OrderBy(x => x.DirectorId).ToList();
        }
        public void OrderByGenre()
        {
            films = films.OrderBy(x => x.GenreId).ToList();
        }
        public void OrderByRate()
        {
            films = films.OrderBy(x => x.Rating).ToList();
        }

        public Photos getPhotoById(long id)
        {
            if (id != 0)
            {
                DataRow[] dr = PhotoTable.Select($"PhotoId = {id}");
                Photos p = new Photos((Int64)dr[0].ItemArray[0], dr[0].ItemArray[1].ToString(), (byte[])dr[0].ItemArray[2]);
                return p;
            }
            else return null;
        }

        public void UpdateFilmData()
        {
            films.Clear();
            foreach (DataRow dr in FilmTable.Rows)
            {
                films.Add(new Film((Int64)dr.ItemArray[0],
                                            dr.ItemArray[1].ToString(),
                                            (Int64)dr.ItemArray[2],
                                            (Int64)dr.ItemArray[3],
                                            (Int64)dr.ItemArray[4],
                                            (Int64)dr.ItemArray[5],
                                            (decimal)dr.ItemArray[7],
                                            dr.ItemArray[6].ToString()));
            }
            films = films.OrderBy(x => x.FilmName).ToList();
        }

        public void UpdateGenreData()
        {
            genres.Clear();
            foreach (DataRow dr in GenreTable.Rows)
            {
                genres.Add(new Genre((Int64)dr.ItemArray[0], dr.ItemArray[1].ToString()));
            }
        }

        public void UpdateDirectorData()
        {
            directors.Clear();
            foreach (DataRow dr in DirectorTable.Rows)
            {
                directors.Add(new Director((Int64)dr.ItemArray[0], dr.ItemArray[1].ToString()));
            }
            directors = directors.OrderBy(x => x.DirectorName).ToList();
        }
        public int InsertDirector(string DirectorName)
        {
            try
            {
                DataRow newRow = DirectorTable.NewRow();
                newRow[1] = DirectorName;
                DirectorTable.Rows.Add(newRow);
                adapterDirector.Update(DirectorTable);
                DirectorTable.Clear();
                adapterDirector.Fill(DirectorTable);
                UpdateDirectorData();
                
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public long InsertPhoto(Photos photo)
        {
            try
            {
                DataRow newRow = PhotoTable.NewRow();
                newRow[1] = photo.PhotoName;
                newRow[2] = photo.PhotoData;
                PhotoTable.Rows.Add(newRow);
                adapterPhoto.Update(PhotoTable);
                PhotoTable.Clear();
                adapterPhoto.Fill(PhotoTable);
                long i = (Int64)PhotoTable.Select($"PhotoId = MAX(PhotoId)")[0].ItemArray[0];
                MessageBox.Show(i.ToString());
                return i;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
            
        }

        public int InsertFilm(Film film)
        {
            try
            {
                DataRow newRow = FilmTable.NewRow();
                newRow[1] = film.FilmName;
                newRow[2] = film.PhotoId;
                newRow[3] = film.FilmYear;
                newRow[4] = film.DirectorId;
                newRow[5] = film.GenreId;
                newRow[6] = film.Description;
                newRow[7] = film.Rating;
                FilmTable.Rows.Add(newRow);
                adapterFilm.Update(FilmTable);
                FilmTable.Clear();
                adapterFilm.Fill(FilmTable);
                UpdateFilmData();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }

        }

        public List<Film> getFilmsByYear(long year)
        {   
            films = films.Where(x => x.FilmYear == year).ToList();
            return films;
        }

        public List<Film> getFilmsByGenre(long genreid)
        {
            films = films.Where(x => x.GenreId == genreid).ToList();
            return films;
        }

        public List<Film> getFilmsByDirector(long directorid)
        {
            films = films.Where(x => x.DirectorId == directorid).ToList();
            return films;
        }


    }
        
    
}
