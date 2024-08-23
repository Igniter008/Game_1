using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
