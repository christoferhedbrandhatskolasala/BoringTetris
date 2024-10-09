namespace BoringTetris
{
    public partial class View : Form
    {
        public const int NUM_ROWS = 7;
        public const int NUM_COLS = 5;

        // controller till vilken användarens input rapporteras
        private Controller controller;

        public View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metod som tillåter controller-variabeln att tilldelas
        /// </summary>
        internal void RegisterController(Controller controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Fyll ett block med innehåll
        /// </summary>
        public void Set(int row, int col)
        {
            set(row, col, Properties.Resources.tetris_block_green);
        }

        /// <summary>
        /// Töm ett block från innehåll
        /// </summary>
        public void Clear(int row, int col)
        {
            set(row, col, Properties.Resources.tetris_block_dark);
        }

        /// <summary>
        /// Hämta PictureBox som motsvarar row och col
        /// </summary>
        private PictureBox get(int row, int col)
        {
            // första raden
            if (row == 0 && col == 0) { return pic0_0; }
            if (row == 0 && col == 1) { return pic0_1; }
            if (row == 0 && col == 2) { return pic0_2; }
            if (row == 0 && col == 3) { return pic0_3; }
            if (row == 0 && col == 4) { return pic0_4; }
            // andra raden
            if (row == 1 && col == 0) { return pic1_0; }
            if (row == 1 && col == 1) { return pic1_1; }
            if (row == 1 && col == 2) { return pic1_2; }
            if (row == 1 && col == 3) { return pic1_3; }
            if (row == 1 && col == 4) { return pic1_4; }
            // tredje raden
            if (row == 2 && col == 0) { return pic2_0; }
            if (row == 2 && col == 1) { return pic2_1; }
            if (row == 2 && col == 2) { return pic2_2; }
            if (row == 2 && col == 3) { return pic2_3; }
            if (row == 2 && col == 4) { return pic2_4; }
            // fjärde raden
            if (row == 3 && col == 0) { return pic3_0; }
            if (row == 3 && col == 1) { return pic3_1; }
            if (row == 3 && col == 2) { return pic3_2; }
            if (row == 3 && col == 3) { return pic3_3; }
            if (row == 3 && col == 4) { return pic3_4; }
            // femte raden
            if (row == 4 && col == 0) { return pic4_0; }
            if (row == 4 && col == 1) { return pic4_1; }
            if (row == 4 && col == 2) { return pic4_2; }
            if (row == 4 && col == 3) { return pic4_3; }
            if (row == 4 && col == 4) { return pic4_4; }
            // sjätte raden
            if (row == 5 && col == 0) { return pic5_0; }
            if (row == 5 && col == 1) { return pic5_1; }
            if (row == 5 && col == 2) { return pic5_2; }
            if (row == 5 && col == 3) { return pic5_3; }
            if (row == 5 && col == 4) { return pic5_4; }
            // sjunde raden
            if (row == 6 && col == 0) { return pic6_0; }
            if (row == 6 && col == 1) { return pic6_1; }
            if (row == 6 && col == 2) { return pic6_2; }
            if (row == 6 && col == 3) { return pic6_3; }
            if (row == 6 && col == 4) { return pic6_4; }

            // kasta ett fel om rad och kolumn inte finns
            throw new ArgumentException($"Illegal argument row {row} col {col}");
        }

        /// <summary>
        /// Sätt bilden på PictureBox som motsvarar row och col
        /// </summary>
        private void set(int row, int col, Bitmap bitmap)
        {
            PictureBox pictureBox = get(row, col);
            pictureBox.Image = bitmap;
        }

        // första raden
        private void pic0_0_Click(object sender, EventArgs e) { click(0, 0); }
        private void pic0_1_Click(object sender, EventArgs e) { click(0, 1); }
        private void pic0_2_Click(object sender, EventArgs e) { click(0, 2); }
        private void pic0_3_Click(object sender, EventArgs e) { click(0, 3); }
        private void pic0_4_Click(object sender, EventArgs e) { click(0, 4); }
        // andra raden
        private void pic1_0_Click(object sender, EventArgs e) { click(1, 0); }
        private void pic1_1_Click(object sender, EventArgs e) { click(1, 1); }
        private void pic1_2_Click(object sender, EventArgs e) { click(1, 2); }
        private void pic1_3_Click(object sender, EventArgs e) { click(1, 3); }
        private void pic1_4_Click(object sender, EventArgs e) { click(1, 4); }
        // tredje raden
        private void pic2_0_Click(object sender, EventArgs e) { click(2, 0); }
        private void pic2_1_Click(object sender, EventArgs e) { click(2, 1); }
        private void pic2_2_Click(object sender, EventArgs e) { click(2, 2); }
        private void pic2_3_Click(object sender, EventArgs e) { click(2, 3); }
        private void pic2_4_Click(object sender, EventArgs e) { click(2, 4); }
        // fjärde raden
        private void pic3_0_Click(object sender, EventArgs e) { click(3, 0); }
        private void pic3_1_Click(object sender, EventArgs e) { click(3, 1); }
        private void pic3_2_Click(object sender, EventArgs e) { click(3, 2); }
        private void pic3_3_Click(object sender, EventArgs e) { click(3, 3); }
        private void pic3_4_Click(object sender, EventArgs e) { click(3, 4); }
        // femte raden
        private void pic4_0_Click(object sender, EventArgs e) { click(4, 0); }
        private void pic4_1_Click(object sender, EventArgs e) { click(4, 1); }
        private void pic4_2_Click(object sender, EventArgs e) { click(4, 2); }
        private void pic4_3_Click(object sender, EventArgs e) { click(4, 3); }
        private void pic4_4_Click(object sender, EventArgs e) { click(4, 4); }
        // sjätte raden
        private void pic5_0_Click(object sender, EventArgs e) { click(5, 0); }
        private void pic5_1_Click(object sender, EventArgs e) { click(5, 1); }
        private void pic5_2_Click(object sender, EventArgs e) { click(5, 2); }
        private void pic5_3_Click(object sender, EventArgs e) { click(5, 3); }
        private void pic5_4_Click(object sender, EventArgs e) { click(5, 4); }
        // sjunde raden
        private void pic6_0_Click(object sender, EventArgs e) { click(6, 0); }
        private void pic6_1_Click(object sender, EventArgs e) { click(6, 1); }
        private void pic6_2_Click(object sender, EventArgs e) { click(6, 2); }
        private void pic6_3_Click(object sender, EventArgs e) { click(6, 3); }
        private void pic6_4_Click(object sender, EventArgs e) { click(6, 4); }

        /// <summary>
        /// Meddela controllern att ett block blivit klickat.
        /// </summary>
        private void click(int row, int col)
        {
            controller.Click(row, col);
        }

        /// <summary>
        /// Meddela controllern att clear-knappen blivit tryckt.
        /// </summary>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            controller.Clear();
        }
    }
}