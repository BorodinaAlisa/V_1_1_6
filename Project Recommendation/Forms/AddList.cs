namespace design
{
    /// <summary>
    /// Класс используется для добавления новых элементов.
    /// </summary>
    public partial class AddList : Form
    {
        public AddList()
        {
            InitializeComponent();
            Design();
        }

        private void CreateCollectionButton_Click(object sender, EventArgs e)
        {
            CreateNewList createNewList = new CreateNewList();
            createNewList.ShowDialog();
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            Text1.Parent = Picture4;
            Text1.BackColor = Color.Transparent;
            AddFavButton.Parent = Picture4;
            AddFavButton.BackColor = Color.Transparent;
            ChooseButton.Parent = Picture4;
            ChooseButton.BackColor = Color.Transparent;
        }
    }
}
