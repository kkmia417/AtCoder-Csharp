// int N = int.Parse(Console.ReadLine());

// long[] S = new long[N];
// long[] T = new long[N];

// string[] sInput = Console.ReadLine().Split(' ');
// for (int i = 0; i < N; i++)
// {
//     S[i] = long.Parse(sInput[i]);
// }

// string[] tInput = Console.ReadLine().Split(' ');
// for (int i = 0; i < N; i++)
// {
//     T[i] = long.Parse(tInput[i]);
// }

// bool[] received = new bool[N];

// while (received.Contains(false))
// {
//     for (int i = 0; i < N; i++)
//     {
//         if (!received[i])
//         {
//             // TiとSiの情報を使って宝石を渡す時間を計算する。同じの場合もあり
//             long jewelTime = Math.Min(T[i], T[i - 1] + S[i - 1]);

//             // jewelTimeを使って宝石を渡す処理をここに書く
//             received[i] = true;
//         }
//     }
// }

// // 各iの宝石を受け取る最小時間を出力
// for (int i = 0; i < N; i++)
// {
//     Console.WriteLine(received[i]);
// }


int N = int.Parse(Console.ReadLine());

long[] S = new long[N];
long[] T = new long[N];

// S の入力を読み込む
string[] sInput = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    S[i] = long.Parse(sInput[i]);
}

// T の入力を読み込む
string[] tInput = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    T[i] = long.Parse(tInput[i]);
}

// 各部屋の宝石を受け取る最小時間を計算
long[] minTime = new long[N];
for (int i = 0; i < N; i++)
{
    minTime[i] = T[i];
}

// 時計回りに宝石を渡す
for (int i = 0; i < 2 * N; i++) // 2周することで全ての部屋を更新
{
    int current = i % N;
    int next = (current + 1) % N;
    minTime[next] = Math.Min(minTime[next], minTime[current] + S[current]);
}

// 結果を出力
for (int i = 0; i < N; i++)
{
    Console.WriteLine(minTime[i]);
}