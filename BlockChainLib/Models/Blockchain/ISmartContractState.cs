namespace BlockChainLib.Models.Blockchain
{
    public interface ISmartContractState
    {
        IBlock Block { get; }
        IMessage Message { get; }
        IPersistentState PersistentState { get; }
        IContractLogger ContractLogger { get; }
        IInternalHashHelper InternalHashHelper { get; }
        IInternalTransactionExecutor InternalTransactionExecutor { get; }
        ISerializer Serializer { get; }
        Contract Contract { get; }
    }
}
