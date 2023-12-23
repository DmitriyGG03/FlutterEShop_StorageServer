using System.ComponentModel.DataAnnotations;

namespace FlutterEShop_StorageServer.Models;

public class User
{
    [Key]
    public Guid UserId { get; set; }

    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string AccountType { get; set; }
}