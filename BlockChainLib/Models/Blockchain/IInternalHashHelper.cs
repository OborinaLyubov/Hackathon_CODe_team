namespace BlockChainLib.Models.Blockchain
{
    public interface IInternalHashHelper
    {
        byte[] sha256(byte[] toHash);
    }
}
