namespace BlockChainLib.Models.Blockchain
{
    /// <summary>
    /// Обрабатывает выполнение транзакций, которые происходят внутри смарт-контракта
    /// </summary>
    public interface IInternalTransactionExecutor
    {
        /// <summary>
        /// Переводит средства на другой счет
        /// </summary>
        /// <param name="state"></param>
        /// <param name="addressTo"></param>
        /// <param name="contract"></param>
        /// <returns></returns>
        ITransferResult Transfer(ISmartContractState state, Address addressTo, Contract contract);
        
        /// <summary>
        /// Вызывает метод другого контракта
        /// </summary>
        /// <param name="state"></param>
        /// <param name="addressTo"></param>
        /// <param name="contract"></param>
        /// <param name="methodName"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        ITransferResult Call(ISmartContractState state, Address addressTo, Contract contract, string methodName, object[] parameters);
        
        /// <summary>
        /// Создает новый контракт
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="state"></param>
        /// <param name="contract"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        ICreateResult Create<T>(ISmartContractState state, Contract contract, object[] parameters);

    }
}
