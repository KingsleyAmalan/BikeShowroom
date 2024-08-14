using System;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;
[ApiController]
[Route("api/[controller]")]
public class Users(DBContext Context):ControllerBase
{
    [HttpGet]
    public async Task< ActionResult<IEnumerable<AppUser>>> Getusers()
    {
        var user=await Context._appUsers.ToListAsync();
        return  user;
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult <AppUser>> Getusers(int id){
        var user=await Context._appUsers.FindAsync(id);
        if(user==null){ return NotFound();}
        return user;
    }
}
