using System.Collections;
using System.Collections.Generic;

public class CategoryViewModel
{
    public int Id { get; set; }

    public string NameBg { get; set; }

    public string NameEn { get; set; }

    public int Order { get; set; }
}

public class CategoryComparer : IEqualityComparer<CategoryViewModel>
{
    public bool Equals(CategoryViewModel x, CategoryViewModel y) => x.Id == y.Id;

    public int GetHashCode(CategoryViewModel obj) => obj.Id;
}