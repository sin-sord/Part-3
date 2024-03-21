using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject stall; // Game Object for building
    public GameObject roof; // Game Object for building
    public GameObject food; // Game Object for building

    float interpolation = 0.1f;
    float lerpBuildSpeed;
    public AnimationCurve lerpSpeed;


    Coroutine scaleUp;

    public Transform spawnPart1;  // sets the spawn-point of part 1
    public Transform spawnPart2;  // sets the spawn-point of part 2
    public Transform spawnPart3;  // sets the spawn-point of part 3

    Vector3 newScale = new Vector3(1.5f,1.5f,0);  // sets the scale of the building

    void Start()
    {
        if(scaleUp != null)  // if scaleUp is not null
        {
            StopCoroutine(scaleUp);  // stops the coroutines
        }
        scaleUp = StartCoroutine(Build());  // starts the coroutines
    }

    IEnumerator Build()
    {
        lerpBuildSpeed = 5;
        while (lerpBuildSpeed < 4)
        {
        yield return null;
        }

        interpolation = lerpSpeed.Evaluate(lerpBuildSpeed);

        yield return new WaitForSeconds(1f);
        stall.transform.localScale = Vector3.Lerp(spawnPart1.position, newScale, interpolation);  //  increase the scale of object
        yield return new WaitForSeconds(1f);
        Debug.Log("using lerp");
        roof.transform.localScale = Vector3.Lerp(spawnPart2.position, newScale, interpolation);  //  increase the scale of object
        yield return new WaitForSeconds(1f);

        food.transform.localScale = Vector3.Lerp(spawnPart3.position, newScale, interpolation);  //  increase the scale of object
        Debug.Log("Done");

    }
}
