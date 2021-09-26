namespace BlockChainLib.Models.Blockchain
{
    public struct Block : IBlock
    {
        public Address Coinbase { get; }
        public ulong Number { get; }

        public Block(ulong number, Address coinbase)
        {
            this.Number = number;
            this.Coinbase = coinbase;
        }
    }
}
