﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CActionResponse : ScriptableObject
{
    public string requiredString;

    public abstract bool DoActionResponse(CGameController controller);

}