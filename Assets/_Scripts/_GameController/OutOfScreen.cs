using UnityEngine;
using System.Collections;

public class OutOfScreen : MonoBehaviour 
{
	void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Band"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Can"))
        {
            Destroy(other.gameObject);
        }
    }

}
