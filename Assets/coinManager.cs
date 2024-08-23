using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinManager : MonoBehaviour
{
    public Gamemanager gameMg;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player") {
            gameMg.coinAdd();
            Destroy(gameObject);
        }
    }
}
