using DbzGraphQl.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl
{
    public class DbzQuery : ObjectGraphType<object>
    {
        public DbzQuery(DbzData data)
        {
            Name = "Query";

            Field<EarthmanType>(
                "Earthman",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id" }
                ),
                resolve: context => data.GetEarthmanByIdAsync(context.GetArgument<string>("id"))
            );

            Field<SaiyajinType>(
                "Saiyajin",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "id" }
                ),
                resolve: context => data.GetSaiyajinByIdAsync(context.GetArgument<string>("id"))
            );
        }
    }
}
