using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{
    
    

   // private List<Door> doors = new List<Door>();

    public GameObject[] objects;
    private Vector3 transPos;
    private int xCoord;
    private int yCoord;
    private string searchTag;

    

    public GameObject s1;
    private RMapGenorator s11;

    void Start()
    {
        //s1 = FindObjectOfType(typeof(RMapGenorator)) as RMapGenorator;

        int locationx = (int)transform.position.x;
        int locationy = (int)transform.position.y;

        int rand = Random.Range(0, objects.Length);
        GameObject obj = Instantiate(objects[rand],transform.position, Quaternion.identity);//Spawns random room from list

        if (s1 != null) //and (transform.childCount > 0)
        {
            searchTag = "Door";
            List<Door> doors = new List<Door>();
            FindObjectswithTag(searchTag,obj,doors);

            //s1 = new RMapGenorator();
            s11=s1.GetComponent<RMapGenorator>();
            Room room = new Room(locationx, locationy, doors);
            
            s11.AddToRoomsList(room);
        }
    }

    private List<Door> FindObjectswithTag(string _tag,GameObject obj, List<Door> doors)
    {
        doors.Clear();
        Transform parent = obj.transform;
        GetChildObject(parent, _tag,doors);
        return doors;
    }

    private List<Door> GetChildObject(Transform parent, string _tag, List<Door> doors)
    {
        for(int i = 0; i < parent.childCount; i++) //for each child of current room, if game tag == "Door" then add x and y coordinates to the list doors
        {
            Transform child = parent.GetChild(i);
            string tagg = child.tag;
            if (tagg ==_tag)
            {
                transPos = child.position;

                xCoord = (int)transPos.x;
                yCoord = (int)transPos.y;

                doors.Append(new Door(xCoord, yCoord, 0));
            }
        }
        return doors;
    }

}
