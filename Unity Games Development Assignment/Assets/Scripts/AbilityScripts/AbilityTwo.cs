using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityTwo : MonoBehaviour
{
    public float gravityDuration = 2f;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnAction(InputAction.CallbackContext context)
    {
        Debug.Log("test");
        StartCoroutine(GravityOff());
    }

    IEnumerator GravityOff()
    {
        //turns gravity off for set seconds
        rb.useGravity = false;
        yield return new WaitForSeconds(gravityDuration);
        rb.useGravity = true;
    }

}
