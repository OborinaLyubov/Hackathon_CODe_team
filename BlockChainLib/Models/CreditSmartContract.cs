using Stratis.SmartContracts;

namespace BlockChainLib.Models
{
    public class CreditSmartContract : SmartContract
    {
        public CreditSmartContract(ISmartContractState state, Address sender, Address recipient, string data) : base(state)
        {
            sender = SenderAddress;
            recipient = RecipientAddress;
            data = Data;
        }

        public enum StateType: uint
        {
            Bank = 0,
            Client = 1,
            InsuranceCompany = 2
        }

        public Address SenderAddress
        {
            get => PersistentState.GetAddress(nameof(SenderAddress));
            private set => PersistentState.SetAddress(nameof(SenderAddress), value);
        }

        public Address RecipientAddress
        {
            get => PersistentState.GetAddress(nameof(RecipientAddress));
            private set => PersistentState.SetAddress(nameof(RecipientAddress), value);
        }

        public string Data
        {
            get => PersistentState.GetString(nameof(Data));
            private set => PersistentState.SetString(nameof(Data), value);
        }
    }

    public struct BankAndClient
    {
        [Index]
        public Address Bank;
        [Index]
        public Address Client;
        public string Data;
    }

    public struct ClientAndInsuranceCompany
    {
        [Index]
        public Address Client;
        [Index]
        public Address InsuranceCompany;
        public string Data;
    }

    public struct BankAndInsuranceCompany
    {
        [Index]
        public Address Bank;
        [Index]
        public Address InsuranceCompany;
        public string Data;
    }
}
