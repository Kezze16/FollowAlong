using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(transform.right * speed * Time.deltaTime * Input.GetAxis("Horizontal"));

        }

        if (Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(transform.forward * speed * Time.deltaTime * Input.GetAxis("Vertical"));

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(!gameObject.activeInHierarchy);

        }
    }

    private void Toggle ()
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
        
    }



}
