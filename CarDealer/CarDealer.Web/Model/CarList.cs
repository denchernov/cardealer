namespace CarDealer.Web.Model
{
    using System.Collections.Generic;

    using Glass.Mapper.Sc.Configuration.Attributes;

    public class CarList : ScItem
    {
        [SitecoreChildren]
        public virtual IEnumerable<Car> Children { get; set; }
    }
}