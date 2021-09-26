namespace BlockChainLib.Models.Blockchain
{
    public interface ICreateResult
    {
        /// <summary>
        /// Адрес созданного договора
        /// </summary>
        Address NewContractAddress { get; }
        /// <summary>
        /// Был ли успешно развернут контракт
        /// </summary>
        bool Success { get; }
    }
}
