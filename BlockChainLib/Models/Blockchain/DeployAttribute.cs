using System;

namespace BlockChainLib.Models.Blockchain
{
    /// <summary>
    /// Если в сборке несколько контрактов, указывает, что этот Тип является тем, который развертывается как часть транзакции создания контракта
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class DeployAttribute : Attribute
    {

    }
}
