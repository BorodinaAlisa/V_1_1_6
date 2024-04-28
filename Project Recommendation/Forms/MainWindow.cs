using DB_993.Classes;
using DB_993.Resourse;


namespace design
{
    /// <summary>
    /// Класс представляет главное окно приложения, который используется для работы с рекомендациями, выставлением рейтинга, 
    /// добавлением объекта в избранное и  черный список.
    /// </summary>
    public partial class MainWindow : Form
    {
        string? Email { get; set; }
        public int I { get; set; }
        int IdRealryForFavBlMark { get; set; }
        public Dictionary<int, decimal>? DictRecom { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Design();

        }
        public MainWindow(GetRecommendation getRecommendation)
        {
            InitializeComponent();
            Design();
            FullListRecommendation(getRecommendation);
            FillRecommendation();
        }
        public MainWindow(GetRecommendation getRecommendation, string email)
        {
            InitializeComponent();
            Design();
            Email = email;
            FullListRecommendation(getRecommendation);
            FillRecommendation();
        }

        public MainWindow(string email)
        {
            InitializeComponent();
            Design();
            Email = email;
        }

        /// <summary>
        /// Метод заполняет список рекомендаций на основе полученных данных.
        /// </summary>
        /// <param name="getRecommendation"> Объект, содержащий рекомендации.</param>
        public void FullListRecommendation(GetRecommendation getRecommendation)
        {
            var dictRecom = new Dictionary<int, decimal>();
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var existingRealty = context.Realtys.ToList();
                for (int i = 0; i < existingRealty.Count; i++)
                {
                    dictRecom.Add(existingRealty[i].Id, CalculateOverallRating(getRecommendation, existingRealty[i]));
                }
                DictRecom = dictRecom;

            }

        }

        /// <summary>
        /// Метод проверяет, находится ли объект недвижимости в черном списке.
        /// </summary>
        /// <param name="sortList">Список идентификаторов объектов недвижимости.</param>
        /// <returns>True, если объект недвижимости не находится в черном списке, иначе false.</returns>
        public bool CheckBlackList(List<int> sortList)
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var existingBl = context.BlackLists.FirstOrDefault(bl => bl.Id_Realty == sortList[I]);
                return existingBl == null ? true : false;
            }

        }

        /// <summary>
        /// Метод заполняет интерфейс приложения рекомендациями.
        /// </summary>
        public void FillRecommendation()
        {
            if (I >= 0 && I < DictRecom!.Count)
            {

                var sortDict = from pair in DictRecom orderby pair.Value descending select pair;
                var sortList = new List<int>();
                foreach (var pair in sortDict)
                {
                    sortList.Add(pair.Key);
                }
                using (var context = new DB_993.Classes.ApplicationContextBD())
                {
                    if (CheckBlackList(sortList))
                    {
                        var existingRealty = context.Realtys.FirstOrDefault(realty => realty.Id == sortList[I]);
                        RealtyPhoto.Image = Image.FromFile(existingRealty!.PhotoRealty!.ToString());
                        AddressText.Text = existingRealty.Address;
                        PriceText.Text = existingRealty.Price.ToString();
                        FloorText.Text = existingRealty.Floor.ToString();
                        SquareText.Text = existingRealty.Square.ToString();
                        IdRealryForFavBlMark = existingRealty.Id;
                    }
                }
            }
        }

        /// <summary>
        /// Метод вычисляет общий рейтинг объекта недвижимости на основе рекомендаций.
        /// </summary>
        /// <param name="getRecommendation">Объект, содержащий рекомендации.</param>
        /// <param name="existingRealty">Объект недвижимости.</param>
        /// <returns>Общий рейтинг объекта недвижимости.</returns>
        public decimal CalculateOverallRating(GetRecommendation getRecommendation, Realty existingRealty)
        {

            decimal comparisonPrice = getRecommendation.RatingPrice > existingRealty.Price
                ? (existingRealty.Price / getRecommendation.RatingPrice) : (getRecommendation.RatingPrice / existingRealty.Price);
            decimal comparisonFloor = getRecommendation.RatingFloоr > existingRealty.Floor
                ? (existingRealty.Floor / getRecommendation.RatingFloоr) : (getRecommendation.RatingFloоr / existingRealty.Floor);
            decimal comparisonSquare = getRecommendation.RatingSquare > existingRealty.Square
                ? (existingRealty.Square / getRecommendation.RatingPrice) : (getRecommendation.RatingSquare / existingRealty.Square);
            decimal comparisonRooms = getRecommendation.RatingRooms > existingRealty.Rooms
                ? (existingRealty.Rooms / getRecommendation.RatingRooms) : (getRecommendation.RatingRooms / existingRealty.Rooms);
            int comparisonCity = getRecommendation.RatingCity == existingRealty.City ? (1) : (0);
            int comparisonType = getRecommendation.RatingType == existingRealty.Type ? (1) : (0);
            int comparisonForWgat = getRecommendation.RatingForWhat == existingRealty.ForWhat ? (1) : (0);

            decimal overallRating = (comparisonPrice + comparisonFloor + comparisonSquare + comparisonRooms + comparisonCity
                + comparisonType + comparisonForWgat + (existingRealty.Mark / 5)) / 8;
            return overallRating;
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            label1.Parent = Picture3;
            label1.BackColor = Color.Transparent;
            Address.Parent = Picture3;
            Address.BackColor = Color.Transparent;
            Price.Parent = Picture3;
            Price.BackColor = Color.Transparent;
            Square.Parent = Picture3;
            Square.BackColor = Color.Transparent;
            AmountOfFloors.Parent = Picture3;
            AmountOfFloors.BackColor = Color.Transparent;
            ProfileButton.Parent = Picture3;
            ProfileButton.BackColor = Color.Transparent;
            ProfileButton.FlatAppearance.BorderSize = 0;
            ProfileButton.FlatStyle = FlatStyle.Flat;
            FavButton.Parent = Picture3;
            FavButton.BackColor = Color.Transparent;
            FavButton.FlatAppearance.BorderSize = 0;
            FavButton.FlatStyle = FlatStyle.Flat;
            BlackListButton.Parent = Picture3;
            BlackListButton.BackColor = Color.Transparent;
            BlackListButton.FlatAppearance.BorderSize = 0;
            BlackListButton.FlatStyle = FlatStyle.Flat;
            BackButton.Parent = Picture3;
            BackButton.BackColor = Color.Transparent;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            StraightButton.Parent = Picture3;
            StraightButton.BackColor = Color.Transparent;
            StraightButton.FlatAppearance.BorderSize = 0;
            StraightButton.FlatStyle = FlatStyle.Flat;
            EstimateButton.Parent = Picture3;
            EstimateButton.BackColor = Color.Transparent;
            EstimateButton.FlatAppearance.BorderSize = 0;
            EstimateButton.FlatStyle = FlatStyle.Flat;
            AddressText.Parent = Picture3;
            AddressText.BackColor = Color.Transparent;
            PriceText.Parent = Picture3;
            PriceText.BackColor = Color.Transparent;
            SquareText.Parent = Picture3;
            SquareText.BackColor = Color.Transparent;
            FloorText.Parent = Picture3;
            FloorText.BackColor = Color.Transparent;
            AddFavButton.Parent = Picture3;
            AddFavButton.BackColor = Color.Transparent;
            AddFavButton.FlatAppearance.BorderSize = 0;
            AddFavButton.FlatStyle = FlatStyle.Flat;
            AddBlackListButton.Parent = Picture3;
            AddBlackListButton.BackColor = Color.Transparent;
            AddBlackListButton.FlatAppearance.BorderSize = 0;
            AddBlackListButton.FlatStyle = FlatStyle.Flat;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            var profile = new Profile(Email!);
            profile.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addList = new AddList();
            addList.ShowDialog();
        }

        private void FormMyRecommendationButton_Click(object sender, EventArgs e)
        {
            var testFirstWindow = new TestFirstWindow(Email!);
            testFirstWindow.Show();
        }

        private void FavButton_Click(object sender, EventArgs e)
        {
            var favorite = new Favorite();
            favorite.Show();
        }

        private void StraightButton_Click(object sender, EventArgs e)
        {
            if (DictRecom != null)
            {
                if (I++ < DictRecom.Count)
                {
                    I++;
                    FillRecommendation();
                }
            }


        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (DictRecom != null && CheckStringEmpty())
            {
                if (I-- > 0)
                {
                    I--;
                    FillRecommendation();
                }
            }

        }

        private void AddFavButton_Click(object sender, EventArgs e)
        {
            if (DictRecom != null && CheckStringEmpty())
            {
                var favourites = new Favorite(IdRealryForFavBlMark);
            }
        }

        private void AddBlackListButton_Click(object sender, EventArgs e)
        {
            if (DictRecom != null && CheckStringEmpty())
            {
                var favourites = new BlackList(IdRealryForFavBlMark);
            }
        }

        private void BlackListButton_Click(object sender, EventArgs e)
        {
            var blackList = new BlackList();
            blackList.Show();
        }

        private void EstimateButton_Click(object sender, EventArgs e)
        {
            if (DictRecom != null && CheckStringEmpty())
            {
                var mark = new MarkWindow(IdRealryForFavBlMark);
                mark.Show();
            }
        }
        public bool CheckStringEmpty()
        {
            if (RealtyPhoto.Image == null || AddressText.Text == null || PriceText.Text == null
                || FloorText.Text == null || SquareText.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            ToolTip profile = new ToolTip();
            profile.SetToolTip(ProfileButton, MainWindowLocal.MainWindowProfileText);
            ToolTip fav = new ToolTip();
            fav.SetToolTip(FavButton, MainWindowLocal.MainWindowFavoriteText);
            ToolTip black_list = new ToolTip();
            black_list.SetToolTip(BlackListButton, MainWindowLocal.MainWindowBlackListText);
            ToolTip add_bl = new ToolTip();
            add_bl.SetToolTip(AddBlackListButton, MainWindowLocal.AddBlackListText);
            ToolTip add_fav = new ToolTip();
            add_fav.SetToolTip(AddFavButton, MainWindowLocal.AddFavoriteText);
            ToolTip mark = new ToolTip();
            mark.SetToolTip(EstimateButton, MainWindowLocal.MainWindowMarkText);
            ToolTip next = new ToolTip();
            next.SetToolTip(StraightButton, MainWindowLocal.FollowRecommendationText);
            ToolTip back = new ToolTip();
            back.SetToolTip(BackButton, MainWindowLocal.PreviousRecommendationText);
        }
    }
}
