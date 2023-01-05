using BubbleSort;

int[] items = { 11, 93, 45, 98, 13, 55};
string orderOption = "";
while (orderOption!="A" && orderOption!="D")
{
    Console.Write("Please enter A to sort in Ascending order, D for Descending order: ");
    orderOption= Console.ReadLine();
}

BubbleSort(items, orderOption=="A"?SortType.Ascending:SortType.Descending);

foreach(var item in items) { Console.WriteLine(item); }
Console.ReadLine();

void BubbleSort (int[] itemsToSort, SortType sortType)
{

    for (int i = 0; i < itemsToSort.Length-1; i++)
    {
        bool swapped = false;
        for (int j = 0; j < itemsToSort.Length - 1; j++)
        {
            if ((itemsToSort[j] > itemsToSort[j + 1] && sortType == SortType.Ascending) ||
                    (itemsToSort[j] < itemsToSort[j + 1] && sortType == SortType.Descending))
            {
                (itemsToSort[j + 1], itemsToSort[j]) = (itemsToSort[j], itemsToSort[j + 1]);
                swapped = true;
            }
           
        }
        if (!swapped)
            break; // array is already sorted no need to continue to loop
    }
}
