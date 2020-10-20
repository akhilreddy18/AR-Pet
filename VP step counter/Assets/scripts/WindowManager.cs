using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject UNEditWindow;
    public GameObject GEditWindow;
    
    public void UNSet()
    {
        UNEditWindow.SetActive(true);
    }
    public void GSet()
    {
        GEditWindow.SetActive(true);
    }
    public void CloseUNSet()
    {
        UNEditWindow.SetActive(false);
    }
    public void CloseGSet()
    {
        GEditWindow.SetActive(false);
    }
   
}
