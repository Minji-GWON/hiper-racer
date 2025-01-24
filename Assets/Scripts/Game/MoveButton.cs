using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButton : MonoBehaviour
{
    
    public delegate void MoveButtonDelegate();
    public event MoveButtonDelegate OnMoveButtonDown;
    
    private bool _isDown;

    private void Update()
    {
        if (_isDown)
        {
            OnMoveButtonDown?.Invoke(); //버튼은 입력을 받는 것만 구현 해 주는 것이 재사용성에 좋다
        }
    }

    public void ButtonDown()
    {
        _isDown = true;
    }

    public void ButtonUp()
    {
        _isDown = false;
    }
}
