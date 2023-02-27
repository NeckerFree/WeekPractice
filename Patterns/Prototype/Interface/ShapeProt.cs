using System;

namespace Patterns.Prototype.Interface
{
    public class ShapeProt: IShape
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public string? Color { get; set; }
        public ShapeProt Clone()
        {
            ShapeProt clone =(ShapeProt)this.MemberwiseClone();
            return clone;
            
        }
        public ShapeProt(int id)
        {
            this.Id = id;
        }
        //public ShapeProt DeepCopy(ShapeProt source)
        //{
        //    ShapeProt clone = (ShapeProt)this.MemberwiseClone();
        //    clone.Color = source.Color;
        //    clone.Id = source.Id;
        //    clone.Name = source.Name;
        //    return clone;
        //}
       
    }
}
