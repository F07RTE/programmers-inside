using System.ComponentModel.DataAnnotations;

namespace ProgrammersInside.Web.Core.UserContext.Models;

public class User
{
    public long Id { get; set;}
    public required string Email {get; set;}
    public required string Password {get; set;}
    public required string Name {get; set;}
    public required string Gender { get; set; }
    public required string PlayAt { get; set; }
    public required string FavoriteGame { get; set; }
    public required DateTime Dob {get; set;}
}
