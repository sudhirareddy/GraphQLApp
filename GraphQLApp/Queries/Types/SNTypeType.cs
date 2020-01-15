using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.Types;
using GraphQLApp.Entities;

namespace GraphQLApp.Queries.Types
{
    public class SNTypeType : ObjectGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";

        }
    }
}