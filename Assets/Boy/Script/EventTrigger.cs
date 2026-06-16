using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventTrigger : MonoBehaviour
{
    public bool inrange, active;
    public GameObject obj, player;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&inrange)
        {
            print("AAAA");
            if (active)
            {
                obj.SetActive(false);
                active = false;
                Cursor.lockState = CursorLockMode.Locked;
                player.GetComponent<PlayerInput>().enabled = false;
            }
            else
            {
                obj.SetActive(true);
                active = true;
                Cursor.lockState = CursorLockMode.None;
                player.GetComponent<PlayerInput>().enabled = true;
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
            player.GetComponent<PlayerInput>().enabled = true;
        }
    }
}

