using ChurchSystem.API;
using System;




public interface ITitheService
{
    public Task<List<Tithe>> GetAllTithes();

}

public class TitheService : ITitheService
{

    public Task<List<Tithe>> GetAllTithes()
    {

        return null;
    }
}