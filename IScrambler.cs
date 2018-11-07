using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretApi
{
    public interface IScrambler
    {
        string Scramble(string messageToBeScrambled);
    }
}
