namespace SnakeFormsApp
{
    public class Map
    {
        private int diameter;
        public int X { get; private set; }
        public int Y { get; private set; }
        public Map()
        {
            diameter = 40;
            X = diameter;
            Y = diameter;
        }
        public void SetX(int indexRow)
        {
            X *= indexRow;
        }
        public void SetY(int indexColumn)
        {
            Y *= indexColumn;
        }
    }
}
