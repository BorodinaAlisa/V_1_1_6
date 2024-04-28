using DB_993.Classes;
using DB_993.Resourse;

namespace design
{
    public partial class BlackList : Form
    {
        /// <summary>
        /// Класс используется для добавления объектов в черный список, отображения информации об объектах и удаления объекта из черного списка.
        /// </summary>
        public int IdRealryForFav { get; set; }
        public BlackList()
        {
            InitializeComponent();
            LoadData();
            Design();
        }
        public BlackList(int idRealty)
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
                var existingUser = context.BlackLists.FirstOrDefault(bl => bl.Id_Realty == IdRealryForFav);
                if (existingUser != null)
                {
                    MessageBox.Show(BlackListLocal.BlackListText);
                    return;
                }
                var newBL = new BlackListTable
                {
                    Id_Realty = IdRealryForFav
                };
                context.BlackLists.Add(newBL);
                context.SaveChanges();
            }
        }
        private void LoadData()
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var imageList = new ImageList();
                imageList.ImageSize = new Size(100, 100);
                var tableBL = context.BlackLists.ToList();
                var listRealty = new List<Realty>();
                for (int i = 0; i < tableBL.Count; i++)
                {
                    var itemRealty = context.Realtys.FirstOrDefault(realty => realty.Id == tableBL[i].Id_Realty);
                    listRealty.Add(itemRealty!);
                }
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
                var bl = context.BlackLists.ToList();
                for (int i = 0; i < bl!.Count; i++)
                {
                    if (bl != null)
                    {
                        context.BlackLists.Remove(bl[i]);
                        context.SaveChanges();
                    }
                }
            }
        }

        private void BlackList_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(BlackListButton, BlackListLocal.BlackListClearText);
        }
    }
}
