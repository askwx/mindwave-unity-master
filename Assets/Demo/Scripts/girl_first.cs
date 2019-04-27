using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girl_first : MonoBehaviour
{
    private int sensorData;

    // Use this for initialization
    void Start()
    {
        MindwaveManager.Instance.Controller.OnUpdateMindwaveData += OnUpdateMindwaveData;
    }

    public void OnUpdateMindwaveData(MindwaveDataModel _Data)
    {
        sensorData = _Data.eSense.attention;
        Debug.Log("nouha meditation : " + _Data.eSense.meditation);
        Debug.Log("nouha attention : " + _Data.eSense.attention);

    }
}
   