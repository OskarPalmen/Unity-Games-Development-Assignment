using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityOne : MonoBehaviour
{
    public GameObject bananaPeelPrefab;

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Instantiate a new banana peel object at the player's current position
            GameObject bananaPeel = Instantiate(bananaPeelPrefab, transform.position, Quaternion.identity);

            // Add a force to the banana peel to make it move away from the player
            Rigidbody rb = bananaPeel.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * 10, ForceMode.Impulse);
            Destroy(bananaPeel, 5f);
        }
    }
}
