namespace Patterns.Prototype.Interface
{
    internal interface IShape
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public string? Color { get; set; }
        public ShapeProt Clone();
        //public ShapeProt DeepCopy(ShapeProt source);

    }
}

