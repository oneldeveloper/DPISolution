namespace DPI.Interfaces
{
    internal interface ISubcategory : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
    }
}