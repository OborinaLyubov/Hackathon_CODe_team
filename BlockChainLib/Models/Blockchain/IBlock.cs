namespace BlockChainLib.Models.Blockchain
{
    public interface IBlock
    {
        /// <summary>
        /// Базовый адрес текущего блока
        /// </summary>
        Address Coinbase { get; }

        /// <summary>
        /// Высота текущего блока
        /// </summary>
        ulong Number { get; }
    }
}
