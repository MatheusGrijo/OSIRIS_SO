using System;
namespace OSIRIS
{
    public class Key
    {

        private static string keyBinary;
        public static string getBinary() { return keyBinary; }

        private static string keyHex;
        public static string getHex() { return keyHex; }

        private static string address;
        public static string getAddress() { return address; }

        //Generate private key - Mastering Bitcoin - Andreas Antonopoulos
        public static void generate()
        {
            keyBinary = String.Empty;
            keyHex = String.Empty;
            for (int i = 0; i < 256; i++)
            {
                String result;
                int magicNumber = RNG.NextRandom();                
                if (magicNumber % 2 == 0)
                    result = "0";
                else
                    result = "1";
                keyBinary += result;                
            }

            for (int i = 0; i < 256; i += 4)            
                keyHex += Utils.BinaryToHex(keyBinary.Substring(i, 4));





            //Secp256k1 secp256K1 = new Secp256k1();
            ////byte[] publicKeyAsBytes = secp256K1.GetPublicKey(Utils.ToByteArray(keyHex));            


            //byte[] publicKeyAsBytes = new byte[32];

            //Sha256 sha256 = new Sha256();
            //sha256.AddData(publicKeyAsBytes, 0, (uint)publicKeyAsBytes.Length);
            //byte[] step2 = sha256.GetHash();

            //byte[] step3 = Ripemd160Manager.GetHash(step2);

            //byte[] step4 = Utils.AppendBitcoinNetwork(step3, 0);

            //sha256 = new Sha256();
            //sha256.AddData(step4, 0, (uint)step4.Length);
            //byte[] step5 = sha256.GetHash();

            //sha256 = new Sha256();
            //sha256.AddData(step5, 0, (uint)step5.Length);
            //byte[] step6 = sha256.GetHash();


            //byte[] Address = Utils.ConcatAddress(step4, step6);

            //address = Base58.Base58Encode(Address);

        }

    }
}
