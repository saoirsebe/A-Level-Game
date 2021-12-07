using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class RMapGenorator : MonoBehaviour
{

    public GameObject[] nodes;
    public List<Room> roomsList = new List<Room>();
    public Room Room;


    public void AddToRoomsList(Room room)
    {
        roomsList.Append(room);
    }

    public List<Vector2Int> shortestPathCoridors(Vector2Int startPosition, Vector2Int endPosition)
    {
        List<Vector2Int> corridors = new List<Vector2Int>();//List of corridors


        return corridors;

    }


    private void LateUpdate()
    {
        foreach(var x in roomsList)
        {
            Debug.Log(x.ToString());
        }
    }

}

public class Room
{
    int x;
    int y;
    List<Door> doors;

    public Room(int x, int y, List<Door> doors)
    {
    }
}

public class Door
{
    int x;
    int y;
    int direction;

    public Door(int x, int y, int direction)
    {
    }
}
