using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_management.Helpers
{
    public class Validation
    {
        public static bool Validate(List<string> inputs)
        {
            var valid = false;
            foreach (var input in inputs)
            {

                if (string.IsNullOrWhiteSpace(input.Trim()))
                {
                    valid = false;
                    break;
                }
                else
                {
                    valid = true;
                }
            }

            return valid;
        }
    }
}
