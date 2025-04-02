string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');
string[] newWords = new string[words.Length];
char[] temp;

foreach (string word in words)
{
    temp = word.ToCharArray();
    Array.Reverse(temp);
    newWords[Array.IndexOf(words, word)] = new string(temp);
}

string result = string.Join(" ", newWords);
Console.WriteLine(result);