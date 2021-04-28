using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    Quaternion angle;
    [Range(1f, 50f)]
    public float Intensity = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PokeAPIController.leftClicked){
            StartCoroutine(WobbleLeft());
            PokeAPIController.leftClicked = false;
        }
        if (PokeAPIController.rightClicked){
            StartCoroutine(WobbleRight());
            PokeAPIController.rightClicked = false;
        }
    }

    IEnumerator WobbleLeft(){
        left.transform.rotation = Quaternion.Euler(0, 162, 20);
        yield return new WaitForSeconds(.08f);
        left.transform.rotation = Quaternion.Euler(0, 162, -20);
        yield return new WaitForSeconds(.08f);
        left.transform.rotation = Quaternion.Euler(0, 162, 20);
        yield return new WaitForSeconds(.08f);
        left.transform.rotation = Quaternion.Euler(0, 162, -20);
        yield return new WaitForSeconds(.08f);
        left.transform.rotation = Quaternion.Euler(0, 162, 20);
    }

    IEnumerator WobbleRight(){
        right.transform.rotation = Quaternion.Euler(0, 246, 20);
        yield return new WaitForSeconds(.08f);
        right.transform.rotation = Quaternion.Euler(0, 246, -20);
        yield return new WaitForSeconds(.08f);
        right.transform.rotation = Quaternion.Euler(0, 246, 20);
        yield return new WaitForSeconds(.08f);
        right.transform.rotation = Quaternion.Euler(0, 246, -20);
    }
}
