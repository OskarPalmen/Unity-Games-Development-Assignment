using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityTre : MonoBehaviour
{
    public GameObject fireballPrefab;

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Fire();
        }
    }

    void Fire()
    {
        //Shoots fire ball and its fire force
        GameObject fireball = Instantiate(fireballPrefab, transform.position, Quaternion.identity);
        Rigidbody fireballRb = fireball.GetComponent<Rigidbody>();
        fireballRb.AddForce(transform.forward * 1000);
        Destroy(fireball, 5f);
    }

}
