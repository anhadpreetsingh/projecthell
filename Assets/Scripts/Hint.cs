using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hint : MonoBehaviour
{
    [SerializeField] GameObject text;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            //GetComponentInChildren<TextMeshPro>().enabled = false;
            text.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            text.SetActive(true);
        }

    }
}
