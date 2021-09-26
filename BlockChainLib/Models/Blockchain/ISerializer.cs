using System;

namespace BlockChainLib.Models.Blockchain
{
    public interface ISerializer
    {
        byte[] Serialize(char c);
        byte[] Serialize(Address address);
        byte[] Serialize(bool b);
        byte[] Serialize(int i);
        byte[] Serialize(uint u);
        byte[] Serialize(string s);
        byte[] Serialize(Array a);
        byte[] Serialize<T>(T s) where T : struct;
        bool ToBool(byte[] val);
        Address ToAddress(string val);
        Address ToAddress(byte[] val);
        int ToInt32(byte[] val);
        uint ToUInt32(byte[] val);
        string ToString(byte[] val);
        char ToChar(byte[] val);
        T[] ToArray<T>(byte[] val);
        T ToStruct<T>(byte[] val) where T : struct;
    }
}
