using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type : MonoBehaviour
{
    //A general class for building the 18 pokemon types. Every type will have the information it needs when attacking a different type
    //making it simple to determine how strongly it hits.
    public string[] immune;
    public string[] resist;
    public string[] super;

    public string type;
    public float Attack(string type)
    {
        if(immune.Length > 0)
        {
            foreach (string t in immune)
            {
                if (t.Equals(type))
                {
                    return 0;
                }
            }
        }
        if(resist.Length > 0)
        {
            foreach (string t in resist)
            {
                if (t.Equals(type))
                {
                    return 0.5f;
                }
            }
        }
        if(super.Length > 0)
        {
            foreach (string t in super)
            {
                if (t.Equals(type))
                {
                    return 2.0f;
                }
            }
        }
        
        return 1;
    }


}
