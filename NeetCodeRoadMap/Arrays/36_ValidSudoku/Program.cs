// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

char[][] sudoko = new char[][] {
 new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'}
,new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'}
,new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'}
,new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'}
,new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'}
,new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'}
,new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'}
,new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'}
,new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
};

char[][] sudoko2 = new char[][] {
 new char[] {'8', '3', '.', '.', '7', '.', '.', '.', '.'}
,new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'}
,new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'}
,new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'}
,new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'}
,new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'}
,new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'}
,new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'}
,new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9' }
};
Console.WriteLine(IsValidSudoku(sudoko2));



bool IsValidSudoku(char[][] board)
{
    bool valid = true;
    var rows = new Dictionary<int, HashSet<char>>();
    var columns = new Dictionary<int, HashSet<char>>();
    var miniSoduko = new Dictionary<KeyValuePair<int, int>, HashSet<char>>();
    for (int r = 0; r < 9;r++)
    {
        for (int c = 0; c < 9; c++)
        {
            if(!rows.ContainsKey(r))
                rows.Add(r, new HashSet<char>());

            if (!columns.ContainsKey(c))
                columns.Add(c, new HashSet<char>());

            if (!miniSoduko.ContainsKey(new KeyValuePair<int, int>(r / 3, c / 3)))
                miniSoduko.Add(new KeyValuePair<int, int>(r / 3, c / 3), new HashSet<char>());

            if (board[r][c] == '.')
                continue;

            if (rows[r].Contains(board[r][c]) || columns[c].Contains(board[r][c]) 
                || miniSoduko[new KeyValuePair<int, int>(r / 3, c / 3)].Contains(board[r][c]))
                return false;

            rows[r].Add(board[r][c]);
            columns[c].Add(board[r][c]);
            miniSoduko[new KeyValuePair<int, int>(r / 3, c / 3)].Add(board[r][c]); 
        }
    }


    return valid;
}