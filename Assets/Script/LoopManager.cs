using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //TwoFor();
        UserSum();
        UserSum(15);
        UserSum(10, 15);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void TwoFor()
    {
        for(int i = 2; i <= 9; i++)
        {
            for(int k = 1; k <= 9; k++)
            {
                Debug.Log(i + " * " + k + " = " + (i * k));
            }
        }
    }

    void UserSum()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++) 
            sum += i;
        Debug.Log(sum);
    }

    void UserSum(int num)
    {
        int sum = 0;
        for (int i = 1; i <= num; i++)
            sum += i;
        Debug.Log(sum);
    }

    void UserSum(int num1, int num2)
    {
        int sum = 0;
        for (int i = num1; i <= num2; i++)
            sum += i;
        Debug.Log(sum);
    }

}
