using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverCoin : Coin
{
    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
        ScoreTracker.keepScore += 5;
    }

}

