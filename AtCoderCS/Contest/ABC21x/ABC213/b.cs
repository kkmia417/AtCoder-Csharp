// 1. 人数 N を読み込む (ここは同じ)
int N = int.Parse(Console.ReadLine());

// 2. スコアが書かれた行を一度に読み込み、スペースで分割して文字列の配列にする
// 例: "1 123 12345 ..." → {"1", "123", "12345", ...}
string[] scoreStrings = Console.ReadLine().Split(' ');

// 3. スコアと元の選手番号をペアで保存するリスト
var players = new List<(int Score, int Number)>();

// 4. 分割した文字列をループで処理する
for (int i = 0; i < N; i++)
{
    // 配列の各要素を整数に変換する
    int score = int.Parse(scoreStrings[i]);
    // 選手番号 (i + 1) とペアでリストに追加
    players.Add((score, i + 1));
}

// 5. スコアの昇順で選手を並べ替える (ここは同じ)
var sortedPlayers = players.OrderBy(p => p.Score).ToList();

// 6. 最後から2番目の選手の番号を出力する (ここは同じ)
Console.WriteLine(sortedPlayers[N - 2].Number);