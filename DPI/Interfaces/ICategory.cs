namespace DPI.Interfaces
{
    /* Specify the category that every DPI is made for.
    The concrete model could be tied to a fixed set of categories
    in the database */
    internal interface ICategory : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
    }
}