using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld: MonoBehaviour
{

    void Start()
    {
        FindDivisors(22, 42);
    }

    public void FindDivisors(int a, int b) // function for finding divisors.
    {
        ArrayList fullList = new ArrayList();
        ArrayList divByTwo = new ArrayList();
        ArrayList divByThree = new ArrayList();
        ArrayList divByFour = new ArrayList();
        ArrayList divByFive = new ArrayList();

        string fullListStr = " ";
        string divByTwoStr = " ";
        string divByTreeStr = " ";
        string divByFourStr = " ";
        string divByFiveStr = " ";


        for (int i = a; i <= b; i++)

        {
            fullList.Add(i);
            fullListStr += " " + i + ",";

            int remainder = i % 2;
            if (remainder == 0)
            {
                divByTwoStr += " " + i + ",";
            }

            remainder = i % 3;
            if (remainder == 0)
            {
                divByTreeStr += " " + i + ",";
            }

            remainder = i % 4;
            if (remainder == 0)
            {
                divByFourStr += " " + i + ",";
            }

            remainder = i % 5;
            if (remainder == 0)
            {
                divByFiveStr += " " + i + ",";
            }
        }



        print("Full List: " + fullListStr);
        print("Divided by two: " + divByTwoStr);
        print("Divided by three: " + divByTreeStr);
        print("Divided by four: " + divByFourStr);
        print("Divided by five: " + divByFiveStr);

    }
}