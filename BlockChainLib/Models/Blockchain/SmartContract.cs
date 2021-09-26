using System.Globalization;

namespace BlockChainLib.Models.Blockchain
{
    /// <summary>
    /// Базовый объект, от которого должны наследоваться все смарт-контракты
    /// </summary>
    public abstract class SmartContract
    {
        private readonly ISmartContractState state;
        public SmartContract(ISmartContractState state)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            this.state = state;
        }

        public Address Address => this.state.Message.ContractAddress;
        public IBlock Block => this.state.Block;
        public IMessage Message => this.state.Message;
        public Contract Contract => this.state.Contract;
        public IPersistentState PersistentState => this.state.PersistentState;
        public ISerializer Serializer => this.state.Serializer;

        protected ITransferResult Transfer(Address addressTo, Contract contract)
        {
            return this.state.InternalTransactionExecutor.Transfer(this.state, addressTo, contract);
        }

        protected ITransferResult Call(Address addressTo, Contract contract, string methodName, object[] parameters = null)
        {
            return this.state.InternalTransactionExecutor.Call(this.state, addressTo, contract, methodName, parameters);
        }

        protected ICreateResult Create<T>(Contract contract = null, object[] parameters = null) where T : SmartContract
        {
            return this.state.InternalTransactionExecutor.Create<T>(this.state, contract, parameters);
        }

        protected byte[] sha256(byte[] toHash)
        {
            return this.state.InternalHashHelper.sha256(toHash);
        }

        protected void Access(bool condition, string message = "Assert failed.")
        {
            if (!condition)
                throw new SmartContractAssertException(message);
        }

        protected void Log<T>(T toLog) where T : struct
        {
            this.state.ContractLogger.Log(this.state, toLog);
        }
    }
}
