using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //This class will be a general class that moves will implement from. Every move has a type and the amount of times it can be used.
    public string type;
    public int pp;
    public Entity user;
    public Battlefield battleF;

    private void Start()
    {
        battleF = GameObject.Find("Battlefield Manager").GetComponent<Battlefield>();
    }

    //This is the public method that the user will call when selecting a move. When this method has resolved, all of the selected move's
    //effects will have finished for the turn
    public void Selected() { }


}
