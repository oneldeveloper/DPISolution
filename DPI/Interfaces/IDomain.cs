namespace DPI.Interfaces
{
    /*Every DPI is made for a Domain. this could be tied to a fixed set of data in the database
    One domain can include one or many categories,
    One category can include one or many subcategories
     */
    internal interface IDomain : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
    }
}