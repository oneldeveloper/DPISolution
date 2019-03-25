namespace DPI.Interfaces
{
    internal interface IDomain : IEntity
    {
        string Name { get; set; }
        string Description { get; set; }
        bool Active { get; set; }
    }
}