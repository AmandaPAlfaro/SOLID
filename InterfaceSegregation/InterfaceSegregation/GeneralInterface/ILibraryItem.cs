using System;

namespace InterfaceSegregation
{
    public interface ILibraryItem
    {
        string LibraryId {get; set;}
        string Title { get; set; }
    }
}
