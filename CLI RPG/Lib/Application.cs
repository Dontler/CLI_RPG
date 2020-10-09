using CLI_RPG.Lib.Terrain;

namespace CLI_RPG.Lib
{
    public class Application
    {
        public void Start()
        {
            var map = new Map();
            map.Render();
        }
    }
}