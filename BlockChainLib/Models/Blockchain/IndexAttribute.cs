using System;

namespace BlockChainLib.Models.Blockchain
{
    /// <summary>
    /// Указывает, что значение поля в структуре журнала может использоваться для поиска квитанций
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class IndexAttribute : Attribute
    {
    }
}
