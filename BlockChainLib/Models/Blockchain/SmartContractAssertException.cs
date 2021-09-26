using System;

namespace BlockChainLib.Models.Blockchain
{
    public class SmartContractAssertException : Exception
    {
        public SmartContractAssertException(string message) : base(message) { }
    }
}
