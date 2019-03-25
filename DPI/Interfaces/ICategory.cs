namespace DPI.Interfaces
{
    internal interface ICategory : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
    }
}