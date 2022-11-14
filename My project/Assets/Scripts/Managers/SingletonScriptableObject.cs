using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectSingleton<T> : ScriptableObject where T : ScriptableObject
{
    private static T _instance = null;

    public static T Instance
    {
        get
        {

            if (_instance == null)
            {
                // find all references of the singleton
                T[] results = Resources.FindObjectsOfTypeAll<T>();
                // no singleton is present
                if (results.Length == 0)
                {
                    Debug.LogError("ScriptableSingletonObject -> Instance -> results length is 0 for type " + typeof(T).ToString() + ".");
                    return null;
                }
                // to many singletons were created (there should not be more than one SINGLETON)
                if (results.Length > 1)
                {
                    Debug.LogError("SingletonScriptableObject -> Instance -> results length is greater than 1 for type " + typeof(T).ToString() + ".");
                    return null;
                }

                _instance = results[0];
                // avoid the singleton does not accidently gobbled up by garbage collection
                //_instance.hideFlags = HideFlags.DontUnloadUnusedAsset;
            }
            return _instance;
        }
    }
}
