using Demo.Data;
using Demo.Data.DataSeeding;
using Demo.Data.Models;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Session04
            #region DataSeeding 
            using CompanyDbContext dbContext = new CompanyDbContext();
            DbContextSeeding.Seed(dbContext);
            #endregion
            #endregion
        }
    }
}
