using Stratis.SmartContracts;

namespace BlockChainLib.Models
{
    public class Starter : SmartContract
    {
        public Starter(ISmartContractState state) : base(state) { }

        public void BankAndClient(Address bank, Address client, string data)
        {
            var bankResult = Create<CreditSmartContract>(0, new object[] { bank, client, data });

            Assert(bankResult.Success);

            var clientResult = Create<CreditSmartContract>(0, new object[] { client, bank, data });

            Assert(clientResult.Success);

            Log(
                new BankAndClient
                {
                    Bank = bankResult.NewContractAddress,
                    Client = clientResult.NewContractAddress,
                    Data = data
                }
            );
        }

        public void GetClientAndInsuranceCompany(Address client, Address insuranceCompany, string data)
        {
            var clientResult = Create<CreditSmartContract>(0, new object[] { client, insuranceCompany, data });

            Assert(clientResult.Success);

            var insuranceCompanyResult = Create<CreditSmartContract>(0, new object[] { insuranceCompany, client, data });

            Assert(insuranceCompanyResult.Success);

            Log(
                new ClientAndInsuranceCompany
                {
                    Client = clientResult.NewContractAddress,
                    InsuranceCompany = insuranceCompanyResult.NewContractAddress,
                    Data = data
                }
            );
        }

        public void GetBankAndInsuranceCompany(Address bank, Address insuranceCompany, string data)
        {
            var bankResult = Create<CreditSmartContract>(0, new object[] { bank, insuranceCompany, data });

            Assert(bankResult.Success);

            var insuranceCompanyResult = Create<CreditSmartContract>(0, new object[] { insuranceCompany, bank, data });

            Assert(insuranceCompanyResult.Success);

            Log(
                new BankAndInsuranceCompany
                {
                    Bank = bankResult.NewContractAddress,
                    InsuranceCompany = insuranceCompanyResult.NewContractAddress,
                    Data = data
                }
            );
        }
    }
}
