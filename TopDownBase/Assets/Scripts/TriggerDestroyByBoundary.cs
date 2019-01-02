using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroyByBoundary : MonoBehaviour {

    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
