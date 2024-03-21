using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI selectedType;
    public List<Villager> characterSelect;

    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
    }

/*    private void Start()
    {
        selectedType = GetComponent<TextMeshProUGUI>();
    }*/

    private void Update()
    {
        if (SelectedVillager != null)
        {
            selectedType.text = "Picked: " + SelectedVillager.CanOpen().ToString();
        }
        else
        {
            selectedType.text = "none";
        }
    }

    public void DropDownCharacterHasChanged(int selection)
    {
        SetSelectedVillager(characterSelect[selection]);
    }

}
