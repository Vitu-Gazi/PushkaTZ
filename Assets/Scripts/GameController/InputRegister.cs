using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputRegister : Singleton<InputRegister>, IPointerDownHandler, IPointerUpHandler
{
    private bool input;

    public Action PlayerHold;

    private void Update()
    {
        if (input)
        {
            PlayerHold.Invoke();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        input = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        input = false;
    }
}
