namespace CLI_RPG.Lib.Terrain.Tiles
{
    public enum TileType
    {
        Player,
        Mountain,
        Road, 
        Enemy
    }

    public abstract class Tile
    {
        private TileType _type;
        
        public TileType Type => _type;

        public abstract string Render();
    }
}