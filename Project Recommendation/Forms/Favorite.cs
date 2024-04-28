using DB_993.Classes;
using DB_993.Resourse;

namespace design
{
    /// <summary>
    /// Класс используется для добавления объектов в избранное, отображения информации об объектах и удаления объекта из избранного.
    /// </summary>
    public partial class Favorite : Form
    {
        public int IdRealryForFav { get; set; }
        public List<Realty>? ListRealty { get; set; }
        public Favorite()
        {

            InitializeComponent();
            LoadData();
            Design();
        }
        public Favorite(int idRealty)
        {
            IdRealryForFav = idRealty;
            FillTableFavourites();
            InitializeComponent();
            Design();

        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            BlackListButton.Parent = Picture6;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
        }

        private void FillTableFavourites()
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var existingUser = context.Favourites.FirstOrDefault(fav => fav.Id_Realty == IdRealryForFav);
                if (existingUser != null)
                {
                    MessageBox.Show(FavoriteLocal.FavoriteText);
                    return;
                }
                var newFav = new Favourites
                {
                    Id_Realty = IdRealryForFav
                };
                context.Favourites.Add(newFav);
                context.SaveChanges();
            }
        }
        private void LoadData()
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var imageList = new ImageList();
                imageList.ImageSize = new Size(100, 100);
                var tableFav = context.Favourites.ToList();
                var listRealty = new List<Realty>();
                for (int i = 0; i < tableFav.Count; i++)
                {
                    var itemRealty = context.Realtys.FirstOrDefault(realty => realty.Id == tableFav[i].Id_Realty);
                    listRealty.Add(itemRealty!);
                }
                ListRealty = listRealty;
                for (int i = 0; i < listRealty.Count; i++)
                {
                    imageList.Images.Add(new Bitmap(listRealty[i].PhotoRealty!));
                }
                listView1.SmallImageList = imageList;

                for (int i = 0; i < listRealty.Count; i++)
                {
                    var listViewItem = new ListViewItem(new string[] { string.Empty, listRealty[i].Price.ToString()!,
                        listRealty[i].Address!, listRealty[i].NameRealty!});
                    listViewItem.ImageIndex = i;
                    listView1.Items.Add(listViewItem);
                }
            }
        }

        private void BlackListButton_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var fav = context.Favourites.ToList();
                for (int i = 0; i < fav!.Count; i++)
                {
                    if (fav != null)
                    {
                        context.Favourites.Remove(fav[i]);
                        context.SaveChanges();
                    }
                }

            }
        }

        private void Favorite_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(BlackListButton, FavoriteLocal.ClearFavoriteText);
        }
    }
}
