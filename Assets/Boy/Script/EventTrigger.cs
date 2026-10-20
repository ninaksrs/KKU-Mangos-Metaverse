using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class EventTrigger : MonoBehaviour
{
    public bool inrange, active;
    public GameObject obj, player;
    private void Start()
    {
        player = Player.Instance.gameObject;
        obj = Player.Instance.BusLineUI;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            obj.SetActive(true);
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

