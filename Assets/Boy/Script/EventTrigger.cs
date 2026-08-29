using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventTrigger : MonoBehaviour
{
    public bool inrange, active;
    public GameObject obj, player;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (active)
            {
                player.gameObject.SetActive(true);
                obj.SetActive(false);
                active = false; print("ZXC");
                Cursor.lockState = CursorLockMode.Locked;
            }
            else if(!active && inrange)
            {
                player.gameObject.SetActive(false);
                obj.SetActive(true);
                active = true;print("ASD");
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            inrange = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        inrange = false;
        if (other.gameObject == player)
        {
            obj.SetActive(false);
            active = false;
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<ThirdPersonController>().enabled = true;
        }
    }
}

