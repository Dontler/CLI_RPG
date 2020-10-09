using System;
using CLI_RPG.Lib.Terrain.Tiles;

namespace CLI_RPG.Lib.Terrain
{
    public class Map
    {
        private Tile[,] _map;
        private const int Height = 10;
        private const int Width = 40;

        public Map()
        {
            _map = new Tile[Height, Width];
            GenerateTiles();
        }

        private void GenerateTiles()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    _map[i, j] = new Road();
                }
            }
        }

        public void Render()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(_map[i,j].Render());
                }
                Console.Write("\n\r");
            }
        }
    }
}