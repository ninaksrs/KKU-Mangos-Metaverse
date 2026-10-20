using StarterAssets;
using UnityEngine;


public class StartPos : MonoBehaviour
{
    public GameObject DeviceUI;
    public void Shine()
    {
        Player.Instance.GetComponent<ThirdPersonController>().enabled = false;
        Player.Instance.transform.position = new Vector3(-16.22f, 0, 6.75f);
        Player.Instance.GetComponent<ThirdPersonController>().enabled = true;
        DeviceUI.SetActive(true);
    }
    public void Yellow()
    {
        Player.Instance.GetComponent<ThirdPersonController>().enabled = false;
        Player.Instance.transform.position = new Vector3(-376.5f, 30.2f, -3150.4f);
        Player.Instance.GetComponent<ThirdPersonController>().enabled = true;
        DeviceUI.SetActive(true);
    }
}
