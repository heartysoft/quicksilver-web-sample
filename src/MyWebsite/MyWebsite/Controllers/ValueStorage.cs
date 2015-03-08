using System.Collections.Generic;

namespace MyWebsite.Controllers
{
    public class ValueStorage
    {
        public virtual IEnumerable<string> GetValues()
        {
            return new[] {"value1", "value2"};
        }
    }
}