#pragma once

namespace ML
{
    int gcd(int a, int b)
    {
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a;
    }

    long double fact(int N)
    {
        if(N < 0)
            return 0;
        if (N == 0)
            return 1;
        else
            return N * fact(N - 1);
    }

    int lcm(int a, int b)
    {
        return a / gcd(a, b) * b;
    }
}
