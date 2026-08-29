using UnityEngine;

public class SelectDevice : MonoBehaviour
{
    public GameObject PhoneUI,CharSelect;
    public void PC()
    {

        PhoneUI.SetActive(false);
        print("AAHUJGukj");
        CharSelect.SetActive(true);
        Destroy(gameObject);
    }
    public void Phone()
    {
        PhoneUI.SetActive(false);
        CharSelect.SetActive(true);
        Destroy(gameObject);
    }
}
