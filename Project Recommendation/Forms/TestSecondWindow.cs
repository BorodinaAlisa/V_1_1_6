using DB_993.Classes;
using DB_993.Resourse;

namespace design
{
    /// <summary>
    /// Класс используется для выбора и просмотра данных рекомендаций.
    /// </summary>
    public partial class TestSecondWindow : Form
    {
        string? Email {  get; set; }
        string? PurposeCombo { get; set; }
        string? RealtyCombo { get; set; }
        string? TownCombo { get; set; }
        List<Realty>? ExistingRealty { get; set; }
        public TestSecondWindow()
        {
            InitializeComponent();
            Design();
        }
        public TestSecondWindow(string email)
        {
            InitializeComponent();
            Design();
            Email = email;
        }
        public TestSecondWindow(string townCombo, string realtyCombo, string purposeCombo, string email)
        {
            InitializeComponent();
            Design();
            Email = email;
            TownCombo = townCombo;
            RealtyCombo = realtyCombo;
            PurposeCombo = purposeCombo;
            FillPicture();
        }

        public TestSecondWindow(string townCombo, string realtyCombo, string purposeCombo)
        {
            InitializeComponent();
            Design();
            TownCombo = townCombo;
            RealtyCombo = realtyCombo;
            PurposeCombo = purposeCombo;
            FillPicture();
        }

        /// <summary>
        /// Метод настраивает внешний вид элементов управления на форме.
        /// </summary>
        public void Design()
        {
            Text1.Parent = Picture8;
            Text1.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Заполняет изображения на форме на основе выбранных параметров.
        /// </summary>
        public void FillPicture()
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
            {
                var existingRealty = context.Realtys.Where(realty => realty.City == TownCombo && realty.Type == RealtyCombo && realty.ForWhat == PurposeCombo).ToList();
                ExistingRealty = existingRealty;
                if (existingRealty.Count != 0)
                {
                    if (existingRealty.Count <= 1)
                    {
                        return;
                    }
                    Photo1.Image = Image.FromFile(existingRealty[0].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 2)
                    {
                        return;
                    }
                    Photo2.Image = Image.FromFile(existingRealty[1].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 3)
                    {
                        return;
                    }
                    Photo3.Image = Image.FromFile(existingRealty[2].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 4)
                    {
                        return;
                    }
                    Photo4.Image = Image.FromFile(existingRealty[3].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 5)
                    {
                        return;
                    }
                    Photo5.Image = Image.FromFile(existingRealty[4].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 6)
                    {
                        return;
                    }
                    Photo6.Image = Image.FromFile(existingRealty[5].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 7)
                    {
                        return;
                    }
                    Photo7.Image = Image.FromFile(existingRealty[6].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 8)
                    {
                        return;
                    }
                    Photo8.Image = Image.FromFile(existingRealty[7].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 9)
                    {
                        return;
                    }
                    Photo9.Image = Image.FromFile(existingRealty[8].PhotoRealty!.ToString());
                    if (existingRealty.Count <= 10)
                    {
                        return;
                    }
                    Photo10.Image = Image.FromFile(existingRealty[9].PhotoRealty!.ToString());

                }

            }
        }

        private void Photo1_Click(object sender, EventArgs e)
        {
            if (Photo1.Image != null)
            {
                Card card = new Card(ExistingRealty![0]);
                card.Show();
            }

        }

        private void Photo2_Click(object sender, EventArgs e)
        {
            if (Photo2.Image != null)
            {
                Card card = new Card(ExistingRealty![1]);
                card.Show();
            }

        }

        private void Photo3_Click(object sender, EventArgs e)
        {
            if (Photo3.Image != null)
            {
                Card card = new Card(ExistingRealty![2]);
                card.Show();
            }

        }

        private void Photo4_Click(object sender, EventArgs e)
        {
            if (Photo4.Image != null)
            {
                Card card = new Card(ExistingRealty![3]);
                card.Show();
            }

        }

        private void Photo5_Click(object sender, EventArgs e)
        {
            if (Photo5.Image != null)
            {
                Card card = new Card(ExistingRealty![4]);
                card.Show();
            }

        }

        private void Photo6_Click(object sender, EventArgs e)
        {
            if (Photo6.Image != null)
            {
                Card card = new Card(ExistingRealty![5]);
                card.Show();
            }

        }

        private void Photo7_Click(object sender, EventArgs e)
        {
            if (Photo7.Image != null)
            {
                Card card = new Card(ExistingRealty![6]);
                card.Show();
            }

        }

        private void Photo8_Click(object sender, EventArgs e)
        {
            if (Photo8.Image != null)
            {
                Card card = new Card(ExistingRealty![7]);
                card.Show();
            }

        }

        private void Photo9_Click(object sender, EventArgs e)
        {
            if (Photo9.Image != null)
            {
                Card card = new Card(ExistingRealty![8]);
                card.Show();
            }

        }

        private void Photo10_Click(object sender, EventArgs e)
        {
            if (Photo10.Image != null)
            {
                Card card = new Card(ExistingRealty![9]);
                card.Show();
            }

        }

        private void Photo1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo1.BorderStyle == BorderStyle.None && Photo1.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo1.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo1.BorderStyle == BorderStyle.Fixed3D && Photo1.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo1.BorderStyle = BorderStyle.None;
                    return;
                }
            }

        }

        private void Photo2_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo2.BorderStyle == BorderStyle.None && Photo2.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo2.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo2.BorderStyle == BorderStyle.Fixed3D && Photo2.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo2.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo3_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo3.BorderStyle == BorderStyle.None && Photo3.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo3.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo3.BorderStyle == BorderStyle.Fixed3D && Photo3.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo3.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo4_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo4.BorderStyle == BorderStyle.None && Photo4.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo4.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo4.BorderStyle == BorderStyle.Fixed3D && Photo4.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo4.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo5_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo5.BorderStyle == BorderStyle.None && Photo5.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo5.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo5.BorderStyle == BorderStyle.Fixed3D && Photo5.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo5.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo6_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo6.BorderStyle == BorderStyle.None && Photo6.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo6.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo6.BorderStyle == BorderStyle.Fixed3D && Photo6.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo6.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo7_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo7.BorderStyle == BorderStyle.None && Photo7.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo7.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo7.BorderStyle == BorderStyle.Fixed3D && Photo7.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo7.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo8_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo8.BorderStyle == BorderStyle.None && Photo8.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo8.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo8.BorderStyle == BorderStyle.Fixed3D && Photo8.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo8.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo9_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo9.BorderStyle == BorderStyle.None && Photo9.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo9.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo9.BorderStyle == BorderStyle.Fixed3D && Photo9.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo9.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Photo10_MouseClick(object sender, MouseEventArgs e)
        {
            if (Photo10.BorderStyle == BorderStyle.None && Photo10.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo10.BorderStyle = BorderStyle.Fixed3D;
                    return;
                }
            }
            if (Photo10.BorderStyle == BorderStyle.Fixed3D && Photo10.Image != null)
            {
                if (e.Button == MouseButtons.Right)
                {
                    Photo10.BorderStyle = BorderStyle.None;
                    return;
                }
            }
        }

        private void Btn_GetRecom_Click(object sender, EventArgs e)
        {

            int selectedCount = 0;
            if (Photo1.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo2.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo3.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo4.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo5.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo6.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo7.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo8.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo9.BorderStyle == BorderStyle.Fixed3D) selectedCount++;
            if (Photo10.BorderStyle == BorderStyle.Fixed3D) selectedCount++;

            if (selectedCount < 3)
            {
                MessageBox.Show(TestSecondWindowLocal.TestSecondWindowText);
                return;
            }

            if (Photo1.BorderStyle == BorderStyle.Fixed3D || Photo2.BorderStyle == BorderStyle.Fixed3D || Photo3.BorderStyle == BorderStyle.Fixed3D
                || Photo4.BorderStyle == BorderStyle.Fixed3D || Photo5.BorderStyle == BorderStyle.Fixed3D || Photo6.BorderStyle == BorderStyle.Fixed3D
                || Photo7.BorderStyle == BorderStyle.Fixed3D || Photo8.BorderStyle == BorderStyle.Fixed3D || Photo9.BorderStyle == BorderStyle.Fixed3D
                || Photo10.BorderStyle == BorderStyle.Fixed3D)
            {
                var listH = new List<Realty>();
                if (Photo1.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![0]);
                }
                if (Photo2.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![1]);
                }
                if (Photo3.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![2]);
                }
                if (Photo4.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![3]);
                }
                if (Photo5.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![4]);
                }
                if (Photo6.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![5]);
                }
                if (Photo7.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![6]);
                }
                if (Photo8.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![7]);
                }
                if (Photo9.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![8]);
                }
                if (Photo10.BorderStyle == BorderStyle.Fixed3D)
                {
                    listH.Add(ExistingRealty![9]);
                }
                GetRecommendation getRecommendation = new GetRecommendation(listH);
                MainWindow mainWindow = new MainWindow(getRecommendation, Email!);
                mainWindow.Show();
            }

        }
    }
}
