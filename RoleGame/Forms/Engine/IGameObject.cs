namespace Forms.Engine
{
    internal interface IGameObject
    {
        Vector Position { get; set; }
        Vector Size { get; set; }
        void Draw(Graphics graphics);
    }
}