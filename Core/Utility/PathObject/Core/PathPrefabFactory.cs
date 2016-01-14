﻿using UnityEngine;
using System.Collections;
//Lockstep.Agents doesn't currently exist
//using Lockstep.Agents;
public static class PathObjectFactory {
    public static UnityEngine.Object Load (PathObject pathObject) {
        return Load(pathObject.Path);
	}

    public static UnityEngine.Object Load (string prefabName) {
        UnityEngine.Object obj = Resources.Load (prefabName);
		return obj;
	}

}