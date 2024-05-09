using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        private void setViewRow(int row)
        {

        }

    }
}
