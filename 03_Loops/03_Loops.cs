using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class 03_Loops
    {
        [TestMethod]
        public void TestMethod1()
        {
        int studentCount = 15;

        //1 starting Point fires off only once
        //2 Condition that while true, keeps the loop returning
        //what happens after each loop
        //4 Body of the loop what happens each iteration

        //for  //1...           //2      //3
        for (int= 0; int < studentCount; i++++) //+ 1;  -> i++...i = i
        {
            //4
            Console.WriteLine(i);
        }
        
    }

public void ForEachLoop()
{
    String name = "Eleven Fifty Academy";
    
    //1 Collection that's beging work on
    //2 Name of the current iteration being used
    //3 Current Type in the collection
    //4 in keyword, used to seperate the individual and the collection
    //5 Body of the loop
    

        //foreach  //3 //2   //4 //1  
        foreach (char letter in name)
        {
            Console.WriteLine(letter); //5
        }
}

    [TestMethod]
    public void WhileLoop()
    {
        int total -1;

        //1 Loop runs while the condition is true
        //2 The body of the loop

        //while  //1
        while (total != 30)
        { Console.WriteLinetotal;
            total++; ///total =+1
        }
    }
}
