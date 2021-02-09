using System.Collections.Generic;

namespace CSLisp.Data
{
    public class Vector : List<Val>
    {
        public Vector (IEnumerable<Val> collection) : base(collection) {
        }

        public override string ToString () => "(Vector " + string.Join(" ", this) + ")";
    }
}