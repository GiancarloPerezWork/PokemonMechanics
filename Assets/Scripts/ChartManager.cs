using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChartManager : MonoBehaviour
{
    //This class uses a dictionary to translate a Type's name in string form to the corresponding Type object. It then uses this
    //information to determine what damage multiplier it will have at the end.

    public string[] typeNames;
    public Type[] typesObjects;
    private Dictionary<string, Type> typeMap;

    private float damageTotalMultiplier = 1;
    
    //Populate the dictionary with string -> Type
    public void Start()
    {
        typeMap = new Dictionary<string, Type>();
        for(int i = 0; i < typeNames.Length; i++)
        {
            typeMap[typeNames[i]] = typesObjects[i];
        }
    }

    //Pull from the dictionary and use the Type's native Attack command along with the defending Type string to get the individual
    // multiplier. Multiply all the multipliers together and get the final multiplier.
    public float Attack(string[] attackTypes, string[] defendTypes)
    {
        damageTotalMultiplier = 1;
        foreach(string attackType in attackTypes)
        {
            Type attack = typeMap[attackType];
            foreach(string defendType in defendTypes)
            {
                damageTotalMultiplier *= attack.Attack(defendType);
            }
        }
        return damageTotalMultiplier;
    }

}
