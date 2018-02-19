using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl.Types
{
    public class EarthmanType : ObjectGraphType<Earthman>
    {
        public EarthmanType()
        {
            Name = "Earthman";

            Field(h => h.Id).Description("The id of the earthman.");
            Field(h => h.Power).Description("The fight power of the earthman.");
            Field(h => h.Name,nullable: false).Description("The name of the earthman.");
            Field(h => h.IsWarrior,nullable: false).Description("Indicate if is a warrior.");

            Interface<CharacterInterface>();
        }
    }
}
