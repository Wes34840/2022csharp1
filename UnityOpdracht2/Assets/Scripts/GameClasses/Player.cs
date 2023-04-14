using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Player
{

    public GameObject obj;
    public Player(GameObject obj)
    {
        this.obj = obj;

    }
    // Start is called before the first frame update
    void Start()
    {

    }
    bool CanMoveTo(Vector3 newPos, Tile[][] path)
    {
        for (int i = 0; i < path.Length; i++)
        {
            for (int i2 = 0; i2 < path[i].Length; i2++)
            {
                Tile obj = path[i][i2];
                if (obj.isSolid == true && obj.gameObject.transform.position == newPos)
                {
                    Debug.Log("is solid");
                    return false;
                }

                //1) Pak hier eerst de huidige Tile die in [i][i2] zit
                //2) check met een if of het de Tile een tower is
                //3) vergelijk de newPos met de transform.position van de Tile


                //4 als dat zo is return false!
            }
        }
        return true;
    }
    public void Move(Vector3 newPos, Tile[][] path, Quaternion rotation)
    {
        Debug.Log("======move");
        if (CanMoveTo(newPos, path))
        {
            Debug.Log("======CanMoveTo");
            obj.transform.position = newPos;
            obj.gameObject.transform.rotation = rotation;
        }
    }
    public void DoMove(Tile[][] path)
    {
        Vector3 newPos = obj.transform.position;
        Quaternion currentRot = obj.gameObject.transform.rotation;

        if (Input.GetKeyDown(KeyCode.W))
        {
            newPos.z += 2;
            currentRot = Quaternion.Euler(0, 0, 0);
            Move(newPos, path, currentRot);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            newPos.z -= 2;
            currentRot = Quaternion.Euler(0, 180, 0);
            Move(newPos, path, currentRot);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            newPos.x -= 2;
            currentRot = Quaternion.Euler(0, 270, 0);
            Move(newPos, path, currentRot);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            newPos.x += 2;
            currentRot = Quaternion.Euler(0, 90, 0);
            Move(newPos, path, currentRot);
        }
        //kijk hier welke of de speler up,down,left of right ingedrukt heeft

        //Tip: alle tiles zijn 2x bij 2z

        //als dat zo is dan verander je newPos (wat nu de huidige player position is)
        //bv:
        // als right down dan move naar rechts (tel +2 bij de x van newpos op)
        //roep de Move function aan, geef path door en geef newPos door

        //extra: roteer ook het GameObject van Player in de juiste richting
    }
}
