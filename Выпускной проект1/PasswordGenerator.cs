using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Выпускной_проект1
{
    public class PasswordGenerator
    {
        private Random _rnd = new Random();

        /// <summary>
        /// Gets the random password.
        /// </summary>
        /// <param name="stringCharacters">String to generate password from.</param>
        /// <param name="length">Length of the password.</param>
        /// <returns></returns>
        public string GeneratePassword(string stringCharacters, int length)
        {
            return GeneratePassword(stringCharacters.ToList(), length); 
        }

        /// <summary>
        /// Gets the random password.
        /// </summary>
        /// <param name="chars">Characters to generate password from.</param>
        /// <param name="length">Length of the password.</param>
        /// <returns></returns>
        public string GeneratePassword(IEnumerable<char> chars, int length)
        {
            var builder = new StringBuilder();
            for(int i = 0; i < length; i++)
            {
                var rndIndex = _rnd.Next(chars.Count());
                builder.Append(chars.ElementAt(rndIndex));
            }

            return builder.ToString();
        }
    }
}
