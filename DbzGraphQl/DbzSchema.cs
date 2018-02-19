using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl
{
    public class DbzSchema : Schema
    {
        public DbzSchema(Func<Type,GraphType> resolveType)
            : base(resolveType)
        {
            Query = (DbzQuery) resolveType(typeof(DbzQuery));
        }
    }
}
