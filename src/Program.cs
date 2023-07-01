/*
  Symply
  This code for final work
*/

/*
 Append string item to target array
 return array with appended item 
*/
string[] AddItem(string[] target, string item) {
    string[] result = new string[target.Length + 1];
    target.CopyTo(result, 0);
    result[target.Length] = item;
    return result;
}

/*
 Apply filter by string length
 items:        items for filtered
 filterAspect: value of length for filter
 return filtered array
*/
string[] ItemFilter(string[] items, int filterAspect) {
    if (items == null || items.Length == 0)
        return new string[0];
    
    if (filterAspect < 0)
        filterAspect = 0;

    string[] output = new string[0];
    foreach (var item in items) {
        if (item != null && item.Length <= filterAspect)
            output = AddItem(output, item);
    }

    return output;
}

/*
 Formatted print of string array
*/
void PrintArray(string[] array) {
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len; i++) {
        if (i < len - 1)
            Console.Write("\"{0}\", ", array[i]);
        else
            Console.Write("\"{0}\"", array[i]);
    }
    Console.WriteLine("]");
}

/*
 Constants for testing algorithm
*/
string[] INPUT_TEST_ONE = new string[] {"Hello", "2", "world", ":-)"};
string[] INPUT_TEST_TWO = new string[] {"1234", "1567", "-2", "computer science"};
string[] INPUT_TEST_THREE = new string[] {"Russia", "Denmark", "Kazan"};


// Run algorithm for filtering item
string[] output = ItemFilter(INPUT_TEST_ONE, 3);
PrintArray(output);

