using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSVTest : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        List<Dictionary<string, object>> data = CSVReader.Read("CSVTest");

        for (var i = 0; i < data.Count; i++)
        {
            Debug.Log("index " + data[i]["Code"] + " " + data[i]["Name"] + " " + data[i]["Type"] + " " + data[i]["Grade"] + " " + data[i]["Set"] + " " + data[i]["Damage"]);
            //print("index " + data[i]["Code"] + " " + data[i]["Name"] + " " + data[i]["Type"] + " " + data[i]["Grade"] + " " + data[i]["Set"] + " " + data[i]["Damage"]);
        }
    }
}