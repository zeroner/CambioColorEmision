using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorEmision : MonoBehaviour
{
    public Material matOriginal;
    public Material matCambio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CambiarColor());
    }

    IEnumerator CambiarColor()
    {
        yield return new WaitForSeconds(5f);

        this.GetComponent<Renderer>().material = matCambio;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
