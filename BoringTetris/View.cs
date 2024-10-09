using System.Security.Policy;

namespace BoringTetris
{
    public partial class View : Form
    {
        public const int NUM_ROWS = 7;
        public const int NUM_COLS = 5;

        // controller till vilken anv�ndarens input rapporteras
        private Controller controller;

        public View()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metod som till�ter controller-variabeln att tilldelas
        /// </summary>
        internal void RegisterController(Controller controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Fyll ett block med inneh�ll
        /// </summary>
        public void Set(int row, int col)
        {
            set(row, col, Properties.Resources.tetris_block_green);
        }

        /// <summary>
        /// T�m ett block fr�n inneh�ll
        /// </summary>
        public void Clear(int row, int col)
        {
            set(row, col, Properties.Resources.tetris_block_dark);
        }

        public void SetScore(int score)
        {
            labelScore.Text = score.ToString();
        }

        /// <summary>
        /// S�tt bilden p� PictureBox som motsvarar row och col
        /// </summary>
        private void set(int row, int col, Bitmap bitmap)
        {
            // f�rsta raden
            if (row == 0 && col == 0) { pic0_0.Image = bitmap; }
            if (row == 0 && col == 1) { pic0_1.Image = bitmap; }
            if (row == 0 && col == 2) { pic0_2.Image = bitmap; }
            if (row == 0 && col == 3) { pic0_3.Image = bitmap; }
            if (row == 0 && col == 4) { pic0_4.Image = bitmap; }
            // andra raden
            if (row == 1 && col == 0) { pic1_0.Image = bitmap; }
            if (row == 1 && col == 1) { pic1_1.Image = bitmap; }
            if (row == 1 && col == 2) { pic1_2.Image = bitmap; }
            if (row == 1 && col == 3) { pic1_3.Image = bitmap; }
            if (row == 1 && col == 4) { pic1_4.Image = bitmap; }
            // tredje raden
            if (row == 2 && col == 0) { pic2_0.Image = bitmap; }
            if (row == 2 && col == 1) { pic2_1.Image = bitmap; }
            if (row == 2 && col == 2) { pic2_2.Image = bitmap; }
            if (row == 2 && col == 3) { pic2_3.Image = bitmap; }
            if (row == 2 && col == 4) { pic2_4.Image = bitmap; }
            // fj�rde raden
            if (row == 3 && col == 0) { pic3_0.Image = bitmap; }
            if (row == 3 && col == 1) { pic3_1.Image = bitmap; }
            if (row == 3 && col == 2) { pic3_2.Image = bitmap; }
            if (row == 3 && col == 3) { pic3_3.Image = bitmap; }
            if (row == 3 && col == 4) { pic3_4.Image = bitmap; }
            // femte raden
            if (row == 4 && col == 0) { pic4_0.Image = bitmap; }
            if (row == 4 && col == 1) { pic4_1.Image = bitmap; }
            if (row == 4 && col == 2) { pic4_2.Image = bitmap; }
            if (row == 4 && col == 3) { pic4_3.Image = bitmap; }
            if (row == 4 && col == 4) { pic4_4.Image = bitmap; }
            // sj�tte raden
            if (row == 5 && col == 0) { pic5_0.Image = bitmap; }
            if (row == 5 && col == 1) { pic5_1.Image = bitmap; }
            if (row == 5 && col == 2) { pic5_2.Image = bitmap; }
            if (row == 5 && col == 3) { pic5_3.Image = bitmap; }
            if (row == 5 && col == 4) { pic5_4.Image = bitmap; }
            // sjunde raden
            if (row == 6 && col == 0) { pic6_0.Image = bitmap; }
            if (row == 6 && col == 1) { pic6_1.Image = bitmap; }
            if (row == 6 && col == 2) { pic6_2.Image = bitmap; }
            if (row == 6 && col == 3) { pic6_3.Image = bitmap; }
            if (row == 6 && col == 4) { pic6_4.Image = bitmap; }
        }

        // f�rsta raden
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
        // fj�rde raden
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
        // sj�tte raden
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