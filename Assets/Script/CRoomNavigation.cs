﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRoomNavigation : MonoBehaviour
{

    public CRoom currentRoom;


    Dictionary<string, CRoom> exitDictionary = new Dictionary<string, CRoom>();
    CGameController controller;

    void Awake()
    {
        controller = GetComponent<CGameController>();
    }

    public void UnpackExitsInRoom()
    {
        for (int i = 0; i < currentRoom.exits.Length; i++)
        {
            exitDictionary.Add(currentRoom.exits[i].keyString, currentRoom.exits[i].valueRoom);
            controller.interactionDescriptionsInRoom.Add(currentRoom.exits[i].exitDescription);
        }
    }

    public void AttemptToChangeRooms(string directionNoun)
    {
        if (exitDictionary.ContainsKey(directionNoun))
        {
            currentRoom = exitDictionary[directionNoun];
            controller.LogStringWithReturn("You head off to the " + directionNoun);
            controller.DisplayRoomText();
        }
        else
        {
            controller.LogStringWithReturn("There is no path to the " + directionNoun);
        }

    }

    public void ClearExits()
    {
        exitDictionary.Clear();
    }
}
