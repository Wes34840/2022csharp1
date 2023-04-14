using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//class make oefening
public class Tile
{
    //maak variabelen:
    //?? hou hier je GameObject bij
    //?? hou hier bij of je beweging blokkeerd (een tower /muur bent) gebruik een bool
    public GameObject gameObject;
    public bool isSolid;
    public Tile(GameObject gameObject, bool isSolid)//pas deze constructor aan zodat GameObject & de bool meekomen
    {
        this.gameObject = gameObject;
    ;   this.isSolid = isSolid;
    }
}
