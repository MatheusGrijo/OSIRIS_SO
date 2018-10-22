using System;
using System.Collections.Generic;
using System.Text;

namespace OSIRIS
{
    public class RNG
    {

        //George Marsaglia established the lattice structure of linear congruential generators in the paper "Random numbers fall mainly in the planes",[2] later termed the Marsaglia effect or Marsaglia's theorem.[3] This phenomenon means that n-tuples with coordinates obtained from consecutive use of the generator will lie on a small number of equally spaced hyperplanes in n-dimensional space.[4] He also developed the diehard tests, a series of tests to determine whether or not a sequence of numbers have the statistical properties that could be expected from a random sequence. In 1995 he published a CD-ROM of random numbers, which included the diehard tests.[5]
        //He also developed some of the most commonly used methods for generating random numbers and using them to produce random samples from various distributions.Some of the most widely used being the multiply-with-carry, subtract-with-borrow, xorshift, KISS and Mother methods for random numbers, and the ziggurat algorithm for generating normally or other unimodally distributed random variables.

        // Seeds
        static uint m_w = (uint)(new Random()).Next(int.MaxValue);    /* must not be zero */
        static uint m_z = (uint)(new Random()).Next(int.MaxValue);    /* must not be zero */

        public static int NextRandom()
        {
            m_z = 36969 * (m_z & 65535) + (m_z >> 16);
            m_w = 18000 * (m_w & 65535) + (m_w >> 16);
            return (int)((m_z << 16) + m_w);
        }
    }
}
