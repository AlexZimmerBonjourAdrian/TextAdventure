using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TextAdventure/ActionResponses/ChangeRoom")]
public class CChangeRoomResponse : CActionResponse
{
    public CRoom roomToChangeTo;

    public override bool DoActionResponse(CGameController controller)
    {
        if (controller.roomNavigation.currentRoom.roomName == requiredString)
        {
            controller.roomNavigation.currentRoom = roomToChangeTo;
            controller.DisplayRoomText();
            return true;
        }

        return false;
    }
}
