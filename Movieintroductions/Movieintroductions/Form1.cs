using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movieintroductions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MovieScreenDataContext dc = new MovieScreenDataContext();
        Resimleme Resimleme = new Resimleme();
        public int SelectFilm { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MovieLis();
        }
        public void MovieLis()
        {
            TileGroup filmgroups = new TileGroup() { Text = "Movie" };
            foreach(var deg in dc.Films)
            {
                TileItem item = new TileItem();
                item.Elements.Add(new TileItemElement()
                {
                    Image = Resimleme.ResimGetirme(deg.Film_Pic.ToArray()),
                    ImageScaleMode=DevExpress.XtraEditors.TileItemImageScaleMode.Stretch             
                });
                item.AppearanceItem.Normal.BackColor = Color.FromArgb(10, 12, 16);
                item.AppearanceItem.Normal.BorderColor = Color.FromArgb(10, 12, 16);
                item.Padding = new Padding(0, 0, 0, 0);
                item.Name = Convert.ToString(deg.Film_Id);
                filmgroups.Items.Add(item);
                tileControl1.Groups.Add(filmgroups);
            }              
        }

        private void tileControl1_ItemClick(object sender, TileItemEventArgs e)
        {
            tileControl2.Groups.Clear();

            if(tileControl1.SelectedItem.Name != null)
            {
                SelectFilm = Convert.ToInt32(tileControl1.SelectedItem.Name.ToString());
                var query = dc.Films.FirstOrDefault(x => x.Film_Id == SelectFilm);
                LblExp.Text = query.Explan;
                LblMoviName.Text = query.Film_Name;
                LblVisionDate.Text = Convert.ToString(query.Vision_Date);
                Lblminute.Text = Convert.ToString(query.Time) + " min";
                pictureBox1.Image = Resimleme.ResimGetirme(query.Film_Pic.ToArray());
                int val = Convert.ToInt32(query.Imdb);
                bunifuRating1.Value = val / 2;
                ///

                var query2 = from a in dc.FilmScreen
                             where a.Movie_Id == SelectFilm
                             select a;
                TileGroup screen = new TileGroup() { Text = "Screenshots"};
                
                foreach(var deg in query2)
                {
                    TileItem item = new TileItem();
                    item.Elements.Add(new TileItemElement()
                    {
                        Image = Resimleme.ResimGetirme(deg.Picture.ToArray()),
                        ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch
                    });
                    item.ItemSize = TileItemSize.Wide;
                    item.AppearanceItem.Normal.BackColor = Color.FromArgb(10, 12, 16);
                    item.AppearanceItem.Normal.BorderColor = Color.FromArgb(10, 12, 16);
                    item.Padding = new Padding(0, 0, 0, 0);
                    screen.Items.Add(item);
                    tileControl2.Groups.Add(screen);
                }

            }
        }
    }
}
