namespace BlockChainLib.Models.Blockchain
{
    public interface IContractLogger
    {
        /// <summary>
        /// Регистрирует событие, которое произошло во время выполнения этого контракта
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="state"></param>
        /// <param name="toLog"></param>
        void Log<T>(ISmartContractState state, T toLog) where T : struct;
    }
}
