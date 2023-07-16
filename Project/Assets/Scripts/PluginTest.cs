using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WildMini;

public class PluginTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(WildMiniPlugin.CoreTest());
        Debug.Log(WildMiniPlugin.CoreTest());
        Debug.Log(WildMiniPlugin.CoreTest());

        Debug.Log("-------------------");

        Debug.Log(WildMiniPlugin.CoreTestPublic());
        Debug.Log(WildMiniPlugin.CoreTestPublic());
        Debug.Log(WildMiniPlugin.CoreTestPublic());
    }
}
