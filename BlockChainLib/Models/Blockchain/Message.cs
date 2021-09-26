namespace BlockChainLib.Models.Blockchain
{
    public sealed class Message : IMessage
    {
        public Address ContractAddress { get; }
        public Address Sender { get; }
        public Message(Address contractAddress, Address sender)
        {
            this.ContractAddress = contractAddress;
            this.Sender = sender;
        }
    }
}
