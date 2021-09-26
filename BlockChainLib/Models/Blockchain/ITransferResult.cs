namespace BlockChainLib.Models.Blockchain
{
    /// <summary>
    /// Результат выполнения договора перевода или звонка
    /// </summary>
    public interface ITransferResult
    {
        /// <summary>
        /// Возвращаемое значение вызываемого метода
        /// </summary>
        object ReturnValue { get; }

        /// <summary>
        /// Результат исполнения
        /// </summary>
        bool Success { get; }
    }
}
