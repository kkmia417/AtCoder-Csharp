string[] inputs = Console.ReadLine().Split(' ');

int h = int.Parse(inputs[0]);
int w = int.Parse(inputs[1]);
int n = int.Parse(inputs[2]);

// AとBの入力をそれぞれ読み込む（縦版）
int[] a = new int[n];
int[] b = new int[n];
for (int i = 0; i < n; i++)
{
    string[] ab = Console.ReadLine().Split(' ');
    a[i] = int.Parse(ab[0]);
    b[i] = int.Parse(ab[1]);
}

// 行と列の存在フラグを初期化
bool[] rowExists = new bool[h + 1];
bool[] colExists = new bool[w + 1];
for (int i = 0; i < n; i++)
{
    rowExists[a[i]] = true;
    colExists[b[i]] = true;
}

// 行と列の存在フラグを使って、最終的な位置を計算
int[] finalRow = new int[n];
int[] finalCol = new int[n];
int rowCount = 0, colCount = 0;
for (int i = 1; i <= h; i++)
{
    if (rowExists[i])
    {
        rowCount++;
        finalRow[rowCount - 1] = i;
    }
}
for (int j = 1; j <= w; j++)
{
    if (colExists[j])
    {
        colCount++;
        finalCol[colCount - 1] = j;
    }
}
// 最終的な位置を出力
for (int i = 0; i < n; i++)
{
    int finalA = Array.IndexOf(finalRow, a[i]) + 1; // 1-indexed
    int finalB = Array.IndexOf(finalCol, b[i]) + 1; // 1-indexed
    Console.WriteLine($"{finalA} {finalB}");
}

