using System;

namespace BlockChainLib.Models.Blockchain
{
    public interface IPersistentState
    {
        Address GetAddress(string key);
        bool IsContract(Address address);
        byte[] GetBytes(byte[] key);
        byte[] GetBytes(string key);
        char GetChar(string key);
        ulong GetUInt64(string key);
        T[] GetArray<T>(string key);
        T GetStruct<T>(string key) where T : struct;
        void SetString(string key, string value);
        void SetArray(string key, Array array);
        void Clear(string key);
        string GetString(string key);
        void SetUInt64(string key, ulong value);
        void SetStruct<T>(string key, T value) where T : struct;
    }
}
