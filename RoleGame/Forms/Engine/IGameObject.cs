namespace Forms.Engine
{
    public interface IGameObject
    {
        Vector Position { get; set; }
        Vector Size { get; set; }
        void Draw(Graphics graphics);
        void Move(Vector direction);
    }
}