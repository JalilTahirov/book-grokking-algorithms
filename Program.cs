using grokking;


int BinarySearch(List<int> list, int item)
{
   int low = 0;
   int high = list.Count() - 1;

   while (low <= high)
   {
       var mid = (low + high)/2;
       int guess = list[mid];
       Console.WriteLine( $" {guess} {mid}");
       if(guess == item)
        return mid;

       if(guess > item)
        high = mid-1;
       else
        low = mid+1; 
   }
   return -1;
}

//var result  = BinarySearch(new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14}, 1  );
//Console.WriteLine(result);
var sort = new Sorting();
var result = sort.SelectionSort(new List<int>{4,2,1,7,3,9,0,8});

Console.WriteLine(string.Join(", ", result));