function gcd(var a, var b)
{
    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}

function lcm(var a, var b)
{
  return a / gcd(a, b) * b;
}