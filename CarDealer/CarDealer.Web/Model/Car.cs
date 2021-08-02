namespace CarDealer.Web.Model
{
    using System;

    using Glass.Mapper.Sc.Fields;

    public class Car : ScItem
    {
        public virtual string Model { get; set; }
        public virtual Image Image { get; set; }
        public virtual string Description { get; set; }
    }
}