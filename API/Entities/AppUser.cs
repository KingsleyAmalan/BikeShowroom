using System;
using System.ComponentModel.DataAnnotations;

namespace API.Entities;

public class AppUser
{
    [Key]
    public int ID { get; set; }
    public required string  UserName { get; set; }
}
