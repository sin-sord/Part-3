using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIdemo : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    public SpriteRenderer spr;
    public Color start;
    public Color end;
    float interpolation;
    public void SliderValueHasChanged(Single value)
    {
        interpolation = value;
    }

    private void Update()
    {
        spr.color = Color.Lerp(start, end, (interpolation/60));
    }

    public void DropdownSelectionHasChanged(int value)
    {
        Debug.Log(dropdown.options[value].text);
    }
}
