using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class MapGenerator : MonoBehaviour
{

    protected Vector2Int startPosition ;

    [SerializeField]
    private const int nofRooms = 5;
    
    [SerializeField]
    private int iterations = 10;
    [SerializeField]
    public int walkLength = 10;
    [SerializeField]
    public bool startRandomlyEachIteration = true;

    private const int V = 0;
    //private int roomSizex;
    //private int roomSizey;


    [SerializeField]
    private TilemapVisualiser tilemapVisualiser;

   

    private HashSet<Vector2Int> generateRooms(Vector2Int startPosition)
    {

        HashSet<Vector2Int> path = new HashSet<Vector2Int>();
        startPosition = new Vector2Int(Random.Range(-20, 15), Random.Range(-10, 15));

        for (int i=0;i < nofRooms; i++)
        {
            var previousPosition = startPosition;
            var startRoom = previousPosition;

            var roomSizex = Random.Range(1, 7);
            var roomSizey = Random.Range(1, 7);
            makeRoomy(path, ref previousPosition, ref startRoom, roomSizex, roomSizey); //made first room

        }
        return path;

    }

    private static void makeRoomy(HashSet<Vector2Int> path, ref Vector2Int previousPosition, ref Vector2Int startRoom, int roomSizex, int roomSizey)
    {
        for (int i = V; i < roomSizey; i++) //adds squares along x axis going down by one each time for roomSizey
        {
            makeRoomx(path, ref previousPosition, ref startRoom, roomSizex, roomSizey);
        }
    }

    private static void makeRoomx(HashSet<Vector2Int> path, ref Vector2Int previousPosition, ref Vector2Int startRoom, int roomSizex, int roomSizey)
    {
        for (int i = V; i < roomSizex; i++) //adds one right for n of roomSizex
        {
            var newPosition = previousPosition + new Vector2Int(1, 0);
            path.Add(newPosition);
            previousPosition = newPosition;
        }
        previousPosition = startRoom + new Vector2Int(0, -1);
        startRoom = startRoom + new Vector2Int(0, -1);
    }



    public void runProceduralGeneration()
    {
        HashSet<Vector2Int> floorPositions = runRandomWalk();
        tilemapVisualiser.Clear();
        tilemapVisualiser.paintFloorTiles(floorPositions);
    }


    protected HashSet<Vector2Int> runRandomWalk()
    {
        var currentPosition = startPosition;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();

        for (int i = 0; i < iterations; i++)
        {
            var path = generateRooms(currentPosition);
            floorPositions.UnionWith(path);
            if (startRandomlyEachIteration)
                currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));

        }
        return floorPositions;
    }
}
