namespace DPI.Interfaces
{
    /* Specify the subcategory that every DPI is made for.
    The concrete model could be tied to a fixed set of subcategories
    in the database */
    internal interface ISubcategory : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
    }
}