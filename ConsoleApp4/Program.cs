//int[] numbers = new int[5];
//int[] numbers3 = new int[6] { 4, 5, 6, 7, 8,0};
//int[] numbers4 = new int[] { } ;

//int[] numbers = { 1, 2, 3, 4 };
//Console.WriteLine(numbers[numbers.Length-1]);
//Console.WriteLine(numbers[4]);


//string[] words = new string[3];
//string[] words2 = { null, null };

//Console.WriteLine(word[word.Length-1]);





//string word = "Salam";

//for(int i=word.Length-1;i>=0;i--)
//{

//    Console.Write(word[i]);

//}


//int[] arr = { 1, 4, 2, 6, 9, 9 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum/arr.Length);


//int[,] numbers = 
//    { 
//    { 1, 2, 3, 4, 5 },
//    { 8,6,5,2,7} 
//};
//Console.WriteLine(numbers[1,2]);



//int age = 16;
//if(age>18)
//{
//    Console.WriteLine("ise al");
//}
//else
//{
//    Console.WriteLine("ise alma");
//}

//int n =4;

//if(n>2)
//{
//    int count = 0;
//    bool check=false;
//    for(int i=2;i*i<=n;i++)
//    {
//        count++;
//        if(n%i==0)
//        {
//            check=true;
//            break;
//        }
//        Console.WriteLine(i);
//    }
//    if(check)
//    {
//        Console.WriteLine("eded murekkebdir");

//    }
//    else{
//        Console.WriteLine("sadedir");
//    }
//    Console.WriteLine("Dongu sayi  " +count);


//}
//else if(n==2)
//{
//    Console.WriteLine("sadedir");
//}
//else
//{
//    Console.WriteLine("ne sader nede murekkeb");
//}

int[] arr = { 1, 77, 71, 93, 5 };

int max = arr[0];
for (int i = 1; i < arr.Length; i++)
{
    if(arr[i]>max)
    {
        max = arr[i];
    }
}
Console.WriteLine(max);




