using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeGame
{
    public static class GameSettings
    {
        public static int screenShake { get; set; } = 100;
        public static double WallDensity { get; set; } = .1;
        public static bool WallFatality { get; set; } = true;
    }
}
