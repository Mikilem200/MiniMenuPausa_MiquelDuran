using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class SettingMenuMan : MonoBehaviour
{

    public TMP_Dropdown ResDrop;
    Resolution[] AllReso;
    bool IsFull;
    int SelectedRes;
    List<Resolution> SelResList = new List<Resolution>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AllReso = Screen.resolutions;

        List<string> resoStringList = new List<string>();
        string newRes;
        foreach (Resolution res in AllReso)
        {
            newRes = res.width.ToString() + " x " + res.height.ToString();
            if (!resoStringList.Contains(newRes))
            {
                resoStringList.Add(newRes);
                SelResList.Add(res);
            }
            

        }

        ResDrop.AddOptions(resoStringList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
