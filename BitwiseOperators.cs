using System;
class BitwiseOperators {
static void Main(string[] args) {
int a = 5; // 0101 in binary
int b = 3; // 0011 in binary
Console.WriteLine("a & b: " + (a & b)); // 1 (0001 in binary)
Console.WriteLine("a | b: " + (a | b)); // 7 (0111 in binary)
Console.WriteLine("a ^ b: " + (a ^ b)); // 6 (0110 in binary)
Console.WriteLine("~a: " + (~a));
// -6 (inverts all bits)
Console.WriteLine("a << 1: " + (a << 1)); // 10 (1010 in binary)
Console.WriteLine("a >> 1: " + (a >> 1)); // 2 (0010 in binary)
}
}
