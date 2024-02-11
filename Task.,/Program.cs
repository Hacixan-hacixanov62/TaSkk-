//# Tsak.


//int n = 4;

//int result = 1;

//for (int i =n; i > 0; i--)
//{
//    result *= i;
//}
//Console.WriteLine(result);


//int[] arr = { 1, 2, 3, 4, 5, 2, 8, 10 };

//int sum = 0;

//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        sum += arr[i];
//    }
//}
//Console.WriteLine(sum * sum);




//int n = 8;
//int count = 0;

//for (int i = 2; i < n; i *=2)
//{
//    count++;
//    if (i % 2 == 0)
//    {


//    }


//}

//Console.WriteLine(" Quvveti deyil");





//# Homeworks kecsiklerimizin tekrari. Praktikasi.

//int n = 35;
//if (n%3==0 && n%7==0)
//{
//    Console.WriteLine("dvide");
//}
//Console.WriteLine("not divide");


//int n = 12;
//int m = 16;
//int sum = 0;
// if(n%2==0 && m % 2 ==0 )
//{
//    sum = n + m;
//}
//Console.WriteLine(sum);



//int n = 10;
//int m = 25;
//int sum = 0;
//for (int i =n; i<= m; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);



//int[] nums = { 1, 2, 3, 4, 5, 6, 11, 22, 33, 14 };
//int sum = 0;
//for (int i = 0; i < nums.Length; i++)
//{
//    if (i % 2 == 1)
//    {
//        sum += nums[i];
//    }
//}
//Console.WriteLine(sum);


//int[] nums = { 1, 2, 3, 4, 5, 6, 66, 44, 22, 12 };
//int count = 0;
//for (int i = 0; i <= nums.Length; i++ )
//{
//    if (i % 2 == 0)
//    {
//        count ++;
//    }
//}
//Console.WriteLine(count);



//int n = 13;
//int m = 19;
//int count = 0;
//for (int i =n;i<=m; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//int n = 1;
//int m = 100;
//int sum = 0;
//for (int i=n; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine(sum);




//int n = 10;
//int m = 26;
//int count = 0;
//for (int i=n; i <= m; i++)
//{
//    if (i % 2 == 0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



//Verilmis n tam  ededin sade ve  ya murekkeb oldugunu tapin.

//int n = 20;
//int count = 0;

//if(n < 2)
//{
//    Console.WriteLine("ne sade, ne murekkeb");
//}
//else
//{
//    for(int i =0; i<=n; i++)
//    {
//        if (n % i == 0)
//        {
//            count++;
//        }
//    }
//}
//if (count == 2)
//{
//    Console.WriteLine("sade");
//} 
//else
//{
//    Console.WriteLine("murkkeb");
//}


//int a = 5;

//int b = a;

//b = 100;

//Console.WriteLine(a);
//Console.WriteLine(b);



//int[] arr1 = { 1, 2, 3, 4 };

//int[] arr2 = arr1;

//arr2[0] = 200;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);





//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = arr1[0] + 5;

//arr2[0] = 200;

//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);




//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = 200;

//arr2[0] = arr1[0] + arr2[0];


//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);



//int[] arr1 = { 1, 2, 3, 4 };

//arr1[0] = 100;

//int[] arr2 = arr1;

//arr2[0] = 200;

//arr2[0] = arr1[0] + arr2[0];

//arr1[0] = 3;


//Console.WriteLine(arr1[0]);
//Console.WriteLine(arr2[0]);



//string name1 = "test";

//Console.WriteLine(name1.GetType());


//string name1 = "test";
//string name2 = name1;

//name2 = "salam";

//Console.WriteLine(name1);
//Console.WriteLine(name2);


//var name = "test";

//var age = 100;

//bool  isMaried = false;

//List<string> dates = new List<string>();




//var Lastname = "test";

//Lastname = "salam";


//int[] arr = { 1, 2, 3, 4, 5 };
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;

//    }
//    Console.WriteLine(arr[i]);

//}





//int[] arr = { 1, 2, 3, 4, 5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] == 2)
//    {
//        continue;

//    }
//    if (arr[i] == 4)
//    {
//        break;
//    }
//    Console.WriteLine(arr[i]);

//}


//int a = 6;
//a++;

//Console.WriteLine(a);


//int a = 6;

//Console.WriteLine(++a);


//int a = 6;

//Console.WriteLine(a++);


//int a = 6;

//int b = ++a;

//Console.WriteLine(a);
//Console.WriteLine(b);



//int a = 15; //a=15

//int b = --a; // b=14 , a=14

//int c = ++b; // b=15 , c=15

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
