using System;
using System.Collections.Generic;
using System.Text;

namespace BlockChainLib.Models.HashHelper
{
    public interface IHashHelper
    {
        byte[] sha256(byte[] toHash);
    }
}
