namespace BoringTetris
{
    internal class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
            view.RegisterController(this);
        }

        public void Click(int row, int col)
        {
            model.Set(row, col);
            updateView();
        }

        public void Clear()
        {
            model.Clear();
            updateView();
        }

        private void updateView()
        {
            for (int row = 0; row < model.NumRows(); row++)
            {
                for (int col = 0; col < model.NumCols(); col++)
                {
                    bool blockStatus = model.Get(row, col);
                    if (blockStatus)
                    {
                        view.Set(row, col);
                    }
                    else
                    {
                        view.Clear(row, col);
                    }
                }
            }
        }
    }
}
