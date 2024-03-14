using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChestType {Villager, Merchant, Archer, Thief }  // declares types
public class Chest : MonoBehaviour
{
    public Animator animator;
    public ChestType whoCanOpen;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Villager>(out Villager villager))  //review Week5 of TryGetComponent
        {
            if (villager.CanOpen() == whoCanOpen ||  whoCanOpen == ChestType.Villager) // CanOpen is equal to whoCanOpen
            {
               animator.SetBool("IsOpened", true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        animator.SetBool("IsOpened", false);
    }
}
