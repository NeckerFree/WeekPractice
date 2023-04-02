using System;
using System.Numerics;

namespace AlgorithmsApp
{
    public class DiffieHellman
    {
        public static BigInteger PrivateKey(BigInteger primeP)
        {
            Random random = new Random();
            int rnd = random.Next(1, (int)primeP);
            BigInteger bigInteger =new BigInteger(rnd);
            return bigInteger;
        }

        public static BigInteger PublicKey(BigInteger primeP, BigInteger primeG, BigInteger privateKey)
        {
            BigInteger publicInt =BigInteger.ModPow(primeG, privateKey, primeP);
            return  publicInt;
        }

        public static BigInteger Secret(BigInteger primeP, BigInteger publicKey, BigInteger privateKey)
        {
           BigInteger secretInt = BigInteger.ModPow(publicKey, privateKey, primeP);
          return secretInt;
        }
    }
}
