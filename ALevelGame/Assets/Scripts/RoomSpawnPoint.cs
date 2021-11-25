using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{
    RMapGenorator s1;

    private List<Door> doors = new List<Door>();

    public GameObject[] objects;
    private List <GameObject> doorsAdd =  new List<GameObject>();
    private Vector3 transPos;
    private int xCoord;
    private int yCoord;

    void Start()
    {
        int rand = Random.Range(0, objects.Length);
        Instantiate(objects[rand],transform.position, Quaternion.identity);//Spawns random room from list

        foreach (GameObject doorObj in GameObject.FindGameObjectsWithTag("Door"))
        {
            doorsAdd.Add(doorObj);
        }
      

        foreach (GameObject door in doorsAdd)
        {
            transPos = door.transform.position;

            xCoord = (int)transPos.x;
            yCoord = (int)transPos.y;

            doors.Append(new Door(xCoord, yCoord,0));

        }

    }

    IEnumerator start()
    {
        int locationx = (int)transform.position.x;
        int locationy = (int)transform.position.y;

        s1 = GetComponent<RMapGenorator>();
        s1.roomsList.Append(new Room (locationx, locationy,doors));

        yield return new WaitForEndOfFrame();
    }
    

}
