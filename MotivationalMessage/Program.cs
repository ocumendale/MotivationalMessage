string[] arr = { "First, solve the problem. Then, write the code.", "Code is like humor. When you have to explain it, it’s bad.", "Make it work, make it right, make it fast.", "Clean code always looks like it was written by someone who cares.", "Of course, bad code can be cleaned up. But it’s very expensive." };
    Random motivationalM =  new Random();
    int index = motivationalM.Next(arr.Length);
    Console.WriteLine("My Random Motivational Message is: ");
    Console.WriteLine(arr[index]);