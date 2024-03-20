using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject dagger1;  //the game object prefab
    public GameObject dagger2;

    public Transform spawnPoint1;  // the spawn points of the daggers
    public Transform spawnPoint2;

    public Transform dashPoint;
/*    public float timer;
    public float dashTime = 2;
    bool isDashing;*/

    protected override void Attack()
    {
        destination = transform.position;
/*      base.Attack();
        Instantiate(dagger1, spawnPoint1.position, spawnPoint1.rotation);
        Instantiate(dagger2, spawnPoint2.position, spawnPoint2.rotation);*/

        /*transform.position = dashPoint.position;  // when the theif attacks they dash
        destination = transform.position;  // destination is the dash point*/
   //   speed = 7;
  //    destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        StartCoroutine(Dash());


/*      isDashing = true;
        timer = dashTime;*/
    }

    IEnumerator Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;

        while (speed > 3)
        {
            yield return null;
        }

      /*timer -= Time.deltaTime;
        if(timer < 0)
        {
            isDashing=false;*/
        base.Attack();
        yield return new WaitForSeconds(0.1f);
        Instantiate(dagger1, spawnPoint1.position, spawnPoint1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(dagger2, spawnPoint2.position, spawnPoint2.rotation);
      //}
    }


/*    protected override void Update()
    {
        base.Update();
        if (isDashing)
        {
            Dash();
        }
    }*/



    private void OnBecameInvisible()
    {
        Destroy(dagger1);  // when the daggers go off-screen destory the object
        Destroy(dagger2);
    }

    public override ChestType CanOpen()
    {
        return ChestType.Thief;  // only the thief can open the thief chest
    }
}
