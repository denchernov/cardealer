namespace CarDealer.Web.Model
{
    using System;

    using Glass.Mapper.Sc.Fields;

    public class ScItem
    {
        public virtual Guid Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Url { get; set; }
    }
}