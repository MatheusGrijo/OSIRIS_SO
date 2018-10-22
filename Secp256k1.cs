using UChainDB.BingChain.Engine.Cryptography.EC;

namespace OSIRIS
{
    public class Secp256k1
    {
        public ECCurve SelectedCurve { get; } = ECCurve.Secp256k1;

        public Secp256k1()
        {
        }

        public byte[] GetPublicKey(byte[] privateKey)
        {
            var publicKey = this.SelectedCurve.G * privateKey;
            return publicKey.EncodePoint(true);
        }


    }
}