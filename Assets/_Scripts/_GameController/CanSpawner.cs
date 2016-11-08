using UnityEngine;
using System.Collections;

public class CanSpawner : MonoBehaviour
{

    [SerializeField]private GameObject[] cans;
    [SerializeField]private Transform location;

    private GameObject can;
    private float waitTime;

    void Start()
    {
        waitTime = 1.3f;
        Can();
    }

    void Can()
    {
        can = Instantiate(cans [Random.Range(0,cans.Length)],location.position, Quaternion.identity) as GameObject;
        StartCoroutine("Waiting");
    }

    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(waitTime);
        Can();
    }
    
}
