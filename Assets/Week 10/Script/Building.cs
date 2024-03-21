using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Building : MonoBehaviour
{
    public GameObject Stall;
    public GameObject Roof;
    public GameObject Food;

    float interpolation = 0.1f;
    float lerpBuild;
    public AnimationCurve lerpSpeed;


    Coroutine scaleUp;

    public Transform startBuild1;
    public Transform startBuild2;
    public Transform startBuild3;

    Vector3 newScale = new Vector3(1.5f,1.5f,0);

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
        lerpBuild = 3;
        while (lerpBuild < 3)
        {
        yield return null;
        }

        interpolation = lerpSpeed.Evaluate(lerpBuild);

        yield return new WaitForSeconds(1f);
        Stall.transform.localScale = Vector3.Lerp(startBuild1.position, newScale, interpolation);  //  increase the scale of object
        yield return new WaitForSeconds(1f);

        Roof.transform.localScale = Vector3.Lerp(startBuild2.position, newScale, interpolation);  //  increase the scale of object
        yield return new WaitForSeconds(1f);

        Food.transform.localScale = Vector3.Lerp(startBuild3.position, newScale, interpolation);  //  increase the scale of object
        Debug.Log("using lerp");

    }
}
