using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models.ORM.Context
{
    public class TradeNetworkContext : DbContext
    {
        public TradeNetworkContext(DbContextOptions<TradeNetworkContext> options) : base(options)
        {

        }
    }
}
