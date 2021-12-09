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
    public List<ObjectLocation> wallsList = new List<ObjectLocation>();


    public void AddToRoomsList(Room room)
    {
        roomsList.Add(room);

        Debug.Log("p");
   
    }

    public List<Vector2Int> shortestPathCoridors(Vector2Int startPosition, Vector2Int endPosition)
    {
        List<Vector2Int> corridors = new List<Vector2Int>();//List of corridors


        return corridors;

    }


    private void LateUpdate()
    {
        foreach(var Roomx in roomsList)
        {
            List<ObjectLocation> doorsListCheck = Roomx.doors;

            foreach(var Doorx in doorsListCheck)
            {
                int xval = Doorx.x;
                Debug.Log($"Door x:{xval}");
            }
        }
    }

    internal void AddToWallsList(List<ObjectLocation> walls)
    {
        foreach (wallTile in walls)
        {
            wallsList.Add(wallTile);
        }
        
    }
}

public class Room
{
    int x;
    int y;
    public List<ObjectLocation> doors;

    public Room(int x, int y, List<ObjectLocation> doors)
    {
    }
}

public class ObjectLocation
{
    public int x;
    int y;
    int direction;

    public ObjectLocation(int x, int y, int direction)
    {
    }
}
