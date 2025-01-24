using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SrartPanelController : MonoBehaviour
{
    public delegate void SrartPanelDelegate();
    public event SrartPanelDelegate OnSrartButtonClick;
    public void OnClickStartButton()
    {
        OnSrartButtonClick?.Invoke();
    }
}
