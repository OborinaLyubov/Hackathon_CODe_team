using BlockChainLib.Models.Blockchain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlockChainLib.Models.Standarts
{
    public class StandartToken : SmartContract, IStandartToken
    {
        public StandartToken(ISmartContractState state, ulong totalSupply, string name, string symbol) : base(state)
        {
            this.TotalSupply = totalSupply;
            this.Name = name;
            this.Symbol = symbol;
        }

        public ulong TotalSupply 
        { 
            get => PersistentState.GetUInt64(nameof(this.TotalSupply)); 
            private set => PersistentState.SetUInt64(nameof(this.TotalSupply), value); 
        }
        public string Name 
        { 
            get => PersistentState.GetString(nameof(this.Name)); 
            private set => PersistentState.SetString(nameof(this.Name), value); 
        }
        public string Symbol 
        {
            get => PersistentState.GetString(nameof(this.Symbol));
            private set => PersistentState.SetString(nameof(this.Symbol), value); 
        }
        public Contract GetContract(Address address)
        {
            return PersistentState.GetStruct<Contract>(address.ToString());
        }

        private void SetContract(Address address, Contract contract)
        {
            PersistentState.SetStruct<Contract>(address.ToString(), contract);
        }

        public bool TransferTo(Address to, Contract? contract)
        {
            if (contract.HasValue)
            {
                Log(new TransferLog { From = Message.Sender, To = to, Contract = contract.Value });
                return true;
            }
            Contract senderContract = GetContract(Message.Sender);
            SetContract(Message.Sender, senderContract);
            Log(new TransferLog { From = Message.Sender, To = to, Contract = contract.Value });
            return true;  
        }

        public bool TransferFrom(Address from, Address to, Contract? contract)
        {
            if (contract.HasValue)
            {
                Log(new TransferLog { From = from, To = to, Contract = contract.Value });

                return true;
            }

            Contract senderAllowance = Allowance(from, Message.Sender);
            Contract fromContract = GetContract(from);
            SetApproval(from, Message.Sender, senderAllowance);
            SetContract(from, fromContract);

            Log(new TransferLog { From = from, To = to, Contract = contract.Value });

            return true;
        }

        public bool Approve(Address spender, Contract currentContract, Contract contract)
        {
            if (Allowance(Message.Sender, spender) == currentContract)
            {
                return false;
            }

            SetApproval(Message.Sender, spender, contract);

            Log(new ApprovalLog { Owner = Message.Sender, Spender = spender, Contract = contract,  OldContract =  currentContract});

            return true;
        }

        private void SetApproval(Address owner, Address spender, Contract contract)
        {
            PersistentState.SetStruct<Contract>($"Allowance:{owner}:{spender}", contract);
        }

        public Contract Allowance(Address owner, Address spender)
        {
            return PersistentState.GetStruct<Contract>($"Allowance:{owner.ToString()}:{spender.ToString()}");
        }

        public static bool operator ==(Contract c1, Contract c2);

        public struct TransferLog
        {
            [Index]
            public Address From;

            [Index]
            public Address To;

            public Contract Contract;
        }
        public struct ApprovalLog
        {
            [Index]
            public Address Owner;

            [Index]
            public Address Spender;

            public Contract OldContract;

            public Contract Contract;
        }
    } 
}
