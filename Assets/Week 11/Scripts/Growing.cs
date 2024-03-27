using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Growing : MonoBehaviour
{
    public GameObject square;
    public GameObject triangle;
    public GameObject circle;
    public TextMeshProUGUI squareTMP;
    public TextMeshProUGUI triangleTMP;
    public TextMeshProUGUI circleTMP;
    public TextMeshProUGUI crTMP;
    public int running;
    Coroutine coroutine;

    void Start()
    {
        StartCoroutine(GrowingShapes());
    }

    void Update()
    {
        crTMP.text = "Coroutine: " + running.ToString();  // tells us how many coroutines are running
    }

    IEnumerator GrowingShapes()
    {
        running += 1;  // says that a coroutine is running
        StartCoroutine(Square());
        yield return new WaitForSeconds(1f);  // waits 1 second before starting the triangles code
        coroutine = StartCoroutine(Triangle());
        yield return new WaitForSeconds(1f);
        Circle();
        yield return coroutine;  // a way of saying start the coroutine, do things, then finish
        running -= 1;  // says that a coroutine is not running
    }

    IEnumerator Square()
    {
        running += 1;  // says that a coroutine is running
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            square.transform.localScale = scale;
            squareTMP.text = "Square: " + scale;
            yield return null;
        }
        running -= 1;  // says that a coroutine is not running
    }
    IEnumerator Triangle()
    {
        running += 1;  // says that a coroutine is running
        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            triangle.transform.localScale = scale;
            triangleTMP.text = "Triangle: " + scale;
            yield return null;
        }
        running -= 1;  // says that a coroutine is not running
    }
    void Circle()
    {

        float size = 0;
        while (size < 5)
        {
            size += Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            circle.transform.localScale = scale;
            circleTMP.text = "Cirlce: " + scale;
        }
        while (size > 0)
        {
            size -= Time.deltaTime;
            Vector3 scale = new Vector3(size, size, size);
            circle.transform.localScale = scale;
            circleTMP.text = "Cirlce: " + scale;
        }
    }
}
