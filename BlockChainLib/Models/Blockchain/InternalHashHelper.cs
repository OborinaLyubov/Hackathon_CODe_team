using System.Security.Cryptography;

namespace BlockChainLib.Models.Blockchain
{
    public class InternalHashHelper : IInternalHashHelper
    {
        private SHA256 sha;
        public byte[] sha256(byte[] toHash)
        {
            sha = SHA256.Create();
            byte[] outputBytes = sha.ComputeHash(toHash);
            return outputBytes;
        }
    }
}
