string [] arraySum = new string [5] { "123", "1567", "-2", "computer science", "Hey"};

string [] arrayResult = new string[arraySum.Length];


    string[] arrayFill(string[] arraySum, string[] arrayResult) {

    int temp = 0;

    for (int i = 0; i <arraySum.Length; i++)
    {
        if(arraySum[i].Length <=3) {

            arrayResult[temp] = arraySum[i];
            temp++;
        }        
    }
    return arrayResult;
}

void arrayPrint (string [] array) {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

arrayResult = arrayFill(arraySum, arrayResult);

arrayPrint(arrayResult);