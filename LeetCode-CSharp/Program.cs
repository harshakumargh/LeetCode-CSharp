using LeetCode_CSharp.Sorting;

BubbleSort bubbleSort = new BubbleSort();
var result = bubbleSort.Sort(new int[] { 8, 5, 2, 9, 5, 6, 3 });
for( int i = 0; i < result.Length; i++ )
{
    Console.WriteLine(result[i]);
}

Console.ReadLine();