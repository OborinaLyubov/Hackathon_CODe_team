namespace BlockChainLib.Models.Blockchain
{
    public interface IMessage
    {
        /// <summary>
        /// Адрес исполняемого контракта
        /// </summary>
        Address ContractAddress { get; }
        /// <summary>
        /// Адрес, который вызвал этот контракт
        /// </summary>
        Address Sender { get; }
    }
}
