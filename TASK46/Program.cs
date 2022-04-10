// Задача 2: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
// Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са, 
// ав, ва, ви, ив, св, вс
int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int n = Promt("Введите количество букв в комбинации n => ");
string alphabet = "аисв";

string[] Words(string a, int num)
{
    if (num == 0)
    {
        return new string[]{""};
    }
    string[] w = Words(a, num - 1);
    string[] result = new string[w.Length * 4];
    int k = 0;
    for (int i = 0; i < w.Length; i++)
    {
        for (int j = 0; j < a.Length; j++)
        {
            result[k] = w[i] + a[j];
            k++;
        }
    }
    return result;
}
string[] res = Words(alphabet, n);
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i] + " ");
}


