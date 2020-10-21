using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowManager : MonoBehaviour
{
    public GameObject UNEditWindow;
    public GameObject GEditWindow;
    public GameObject IWindow;
    public GameObject IWindowMain;
    
    public void UNSet()
    {
        UNEditWindow.SetActive(true);
    }
    public void GSet()
    {
        GEditWindow.SetActive(true);
    }
    public void IOpen()
    {
        IWindow.SetActive(true);
    }
    public void IMOpen()
    {
        IWindowMain.SetActive(true);
    }

    public void CloseUNSet()
    {
        UNEditWindow.SetActive(false);
    }
    public void CloseGSet()
    {
        GEditWindow.SetActive(false);
    }
    public void CloseI()
    {
        IWindow.SetActive(false);
    }
    public void CloseIM()
    {
        IWindowMain.SetActive(false);
    }
   
}
