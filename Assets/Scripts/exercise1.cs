using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public string letter;

    private void Start()
    {
        isVowel(letter);
    }

    private bool isVowel(string l)
    {
        if (l == "a" || l == "e" || l == "i" || l == "o" || l == "u")
        {
            Debug.Log("This is a vowel");
            return true;

        }
        else
        {
            Debug.Log("This is not a vowel");
            return false;
        }
    }
}
