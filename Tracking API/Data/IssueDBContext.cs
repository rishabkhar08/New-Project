

using Microsoft.EntityFrameworkCore;
using Tracking_API.Models;

namespace Tracking_API.Data
{
    public class IssueDBContext: DbContext
    {
        public IssueDBContext(DbContextOptions<IssueDBContext> options) : base(options) 
        {

        }
        public DbSet<Issue> Issues { get; set; }
    }
}
