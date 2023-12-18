using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlikkerSpill
{
    public class Upgrade : ICommand
    {
        public ClickerGame _game;
        public char Character { get;  } = 'k';

        public Upgrade(ClickerGame game)
        {
            _game = game;
        }
        public void Run()
        {
            _game.UpgradeClick();
        }
    }
}
