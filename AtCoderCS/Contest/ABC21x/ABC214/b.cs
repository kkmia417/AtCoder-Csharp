string[] inputs = Console.ReadLine().Split(' ');

int s = int.Parse(inputs[0]);
int t = int.Parse(inputs[1]);

long count = 0;

// a と b の組み合わせをループで探す (2重ループ)
for (int a = 0; a <= s; a++)
{
    for (int b = 0; b <= s - a; b++)
    {
        // a と b が決まった時点で、条件を満たす c の個数を計算する
        
        // 条件1: a + b + c <= S  から導かれる c の上限
        int c_max_from_sum = s - a - b;

        // 条件2: a * b * c <= T から導かれる c の上限
        // a*bが0の場合、積は常に0で条件を満たすので、cの上限は実質無限大と考える
        if (a * b == 0)
        {
            // cの上限は和の条件のみ。cは0からc_max_from_sumまで取れる。
            // その個数は (c_max_from_sum - 0 + 1) 個
            count += c_max_from_sum + 1;
        }
        else
        {
            // a*bが0でない場合
            int c_max_from_prod = t / (a * b);
            
            // cは和の上限と積の上限の両方を満たす必要がある
            int c_max = Math.Min(c_max_from_sum, c_max_from_prod);

            // cは0からc_maxまで取れる。その個数は (c_max - 0 + 1) 個
            count += c_max + 1;
        }
    }
}
Console.WriteLine(count);