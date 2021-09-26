using BlockChainLib.Models.Blockchain;

namespace BlockChainLib.Models.Standarts
{
    /// <summary>
    /// Стандартный токен смарт-контаркта
    /// </summary>
    public interface IStandartToken
    {
        /// <summary>
        /// Общее количество существующих токенов
        /// </summary>
        ulong TotalSupply { get; }

        /// <summary>
        /// Договор по указанному адресу
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        Contract Contract(Address address);

        /// <summary>
        /// Переводит ли принадлежащие отправителю токены на адрес назначения
        /// </summary>
        /// <param name="to"></param>
        /// <param name="contract"></param>
        /// <returns></returns>
        bool TransferTo(Address to, Contract contract);

        /// <summary>
        /// Переносит ли токены, принадлежащие одному адресу, на другой адрес
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="contract"></param>
        /// <returns></returns>
        bool TransferFrom(Address from, Address to, Contract contract);

        /// <summary>
        /// Может ли отправитель отправлять определенный контракт по токену
        /// </summary>
        /// <param name="spender"></param>
        /// <param name="currentContract"></param>
        /// <param name="contract"></param>
        /// <returns></returns>
        bool Approve(Address spender, Contract currentContract, Contract contract);

        /// <summary>
        /// Возвращает количество принадлежащих владельцу токенов, которые отправитель может потратить
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="spender"></param>
        /// <returns></returns>
        ulong Allowance(Address owner, Address spender);
    }
}
