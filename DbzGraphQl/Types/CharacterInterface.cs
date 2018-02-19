using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbzGraphQl.Types
{
    public class CharacterInterface : InterfaceGraphType<BaseCharacter>
    {
        public CharacterInterface()
        {
            Name = "Character";

            Field(d => d.Id).Description("The id of the character.");
            Field(d => d.Name,nullable: true).Description("The name of the character.");
            Field(d => d.Power,nullable: true).Description("The fight power of the character.");

            Field<ListGraphType<CharacterInterface>>("enemies");
        }
    }
}
