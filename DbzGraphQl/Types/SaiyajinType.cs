using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl.Types
{
    public class SaiyajinType : ObjectGraphType<Saiyajin>
    {
        public SaiyajinType()
        {
            Name = "Saiyajin";

            Field(h => h.Id).Description("The id of the Saiyajin.");
            Field(h => h.Power).Description("The fight power of the Saiyajin.");
            Field(h => h.Name,nullable: false).Description("The name of the Saiyajin.");
            Field(h => h.SaiyajinLevel,nullable: false).Description("Indicate the level of the transformation");
            Field(h => h.Enemies).Description("Indicate the level of the transformation");


            Interface<CharacterInterface>();
        }
    }
}
