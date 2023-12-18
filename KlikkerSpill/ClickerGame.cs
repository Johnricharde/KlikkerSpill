using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KlikkerSpill
{
    public class ClickerGame : ICommand
    {
        public ClickerGame _game;
        public int Points { get; private set; } = 0;
        int _PointsPerClick = 1;
        int _PointsPerClickIncrease = 1;

        public void Click()
        {
            Points += _pointsPerClick;
        }

        public void Upgrade()
        {
            if (Points < 10) return;
            Points -= 10;
            _pointsPerClick += _pointsPerClickIncrease;
        }

        public void SuperUpgrade()
        {
            if (Points < 100) return;
            Points -= 100;
            _pointsPerClickIncrease++;
        }
        public void Run()
        {
            _game = new ClickerGame();
        }
    }
}
