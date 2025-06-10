using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        phase1();
        Phase2();
        Phase3();
    }

    void phase1()
    {
        string star;
        star = string.Empty;

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    void Phase2()
    {
        string star;
        star = string.Empty;
        int size = 5;

        for (int i = size; i >= 1; i--)
        {
            for (int j = 0; j < size - i; j++)
            {
                star += "¡¡";
            }

            for (int k = 0; k < i; k++)
            {
                star += "¡Ú";
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    void Phase3()
    {
        string star;
        star = string.Empty;
        int size = 5;

        for (int i = 1; i <= size; i++)
        {
            for (int j = 0; j < i; j++)
            {
                star += "¡Ú ";
            }
            star += "\n";
        }

        for (int i = size - 1; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                star += "¡Ú ";
            }
            star += "\n";
        }

        Debug.Log(star);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
