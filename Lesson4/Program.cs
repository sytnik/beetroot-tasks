//int result = 1;
//result = Method1(10, "1");
//Console.WriteLine($"Result {result}");

int? int1 = 5;
List<int> list = new List<int>();
int result = 0;
Console.WriteLine($"Result {new TestClass().Method12(ref int1, 7)}");
Console.WriteLine($"Result {new TestClass().Method12(ref int1, 7)}");
IncrementList(ref result, list, 1, 2, 3, 4, 5, 6);
Console.WriteLine($"Result: {string.Join(",", list)}");
ReqMethod(5);
var str = new TestClass().Method12(ref int1, 2);

Console.WriteLine(str);

int ReqMethod(int param)
{
    if (param < 100) return ReqMethod(++param);
    return param;
}

int Method1(int var1 = 5, string var2 = "10")
{
    return var1 * int.Parse(var2);
}

void IncrementList(ref int sum, List<int> result, params int[] list2)
{
    //result = new List<int>();
    for (int i = 0; i < list2.Length; i++)
    {
        result.Add(list2[i] += 1);
    }

    foreach (var elem in list2)
    {
        result.Add(elem + 1);
    }

    sum = list.Sum();
}

public class TestClass
{
    public int? Method12(ref int? var1, int var2 = 10) =>
        --var1 * var2;

    public string Method12(ref int? var1, int var2 = 10, int required = 6) =>
        $"{--var1 * var2}";
}