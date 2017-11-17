using System;
using Microsoft.EntityFrameworkCore;

namespace MoneyMatters.Data
{
    public class MoneyMattersContext : DbContext
    {
        public MoneyMattersContext(DbContextOptions<MoneyMattersContext> options) : base(options)
        {
        }
    }
}
