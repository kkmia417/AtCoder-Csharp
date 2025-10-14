int[] P = Console.ReadLine().Split().Select(int.Parse).ToArray();

// 数列のインデックスと英小文字を対応させ出力
for (int i = 0; i < P.Length; i++)
{
    Console.Write((char)('a' + P[i] - 1));
    if (i != P.Length - 1) Console.Write("");
}
