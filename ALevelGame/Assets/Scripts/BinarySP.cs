using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BinarySP
{

    public static List<BoundsInt> BinarySpacePartitioning(BoundsInt spaceToSplit, int minWidth, int minHeight)
    {
        Queue<BoundsInt> roomsQueue = new Queue<BoundsInt>();
        List<BoundsInt> roomsList = new List<BoundsInt>();
        roomsQueue.Enqueue(spaceToSplit);

        while (roomsQueue.Count > 0)
        {
            var room = roomsQueue.Dequeue();
            if (room.size.y >= minHeight && room.size.x >= minWidth)
            {
                if (Random.value < 0.5f) //More random by randomly deciding to try to split horizontally or vertically first
                {
                    if (room.size.y >= minHeight * 2)
                    {
                        splitHorizontally(minWidth, minHeight, roomsQueue, room);
                    }
                    else if (room.size.x >= minWidth * 2)
                    {
                        splitVertically(minWidth, minHeight, roomsQueue, room);
                    }
                    else
                    {
                        roomsList.Add(room);
                    }

                }
                else
                {

                    
                    if (room.size.x >= minWidth * 2)
                    {
                        splitVertically(minWidth, minHeight, roomsQueue, room);
                    }
                    else if (room.size.y >= minHeight * 2)
                    {
                        splitHorizontally(minWidth, minHeight, roomsQueue, room);
                    }
                    else
                    {
                        roomsList.Add(room);
                    }
                }
            }
        }
        return roomsList;
    }

    private static void splitHorizontally(int minWidth, int minHeight, Queue<BoundsInt> roomsQueue, BoundsInt room)
    {
        throw new System.NotImplementedException();
    }


    private static void splitVertically(int minWidth, int minHeight, Queue<BoundsInt> roomsQueue, BoundsInt room)
    {
        throw new System.NotImplementedException();
    }

}