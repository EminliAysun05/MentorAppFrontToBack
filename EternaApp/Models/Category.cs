using EternaApp.Entities.Common;
using System.Reflection.Metadata.Ecma335;

namespace EternaApp.Models;

public class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Portfolio> Portfolios { get; set; }
}
