using System;
namespace OAuth2Provider
{
    public interface IEncryption
    {
        byte[] Decrypt(byte[] EncryptedValue);
        byte[] Encrypt(byte[] bytes);
    }
}
