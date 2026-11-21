using StarterAssets;
using UnityEngine;

public class SelectLanguage : MonoBehaviour
{
    public GameObject Eng,TH,EngMap,THMap;
    public Navigation P;
    public void English()
    {
        Player.Instance.GetComponent<ThirdPersonController>().enabled = false;
        Player.Instance.GetComponent<ThirdPersonController>().enabled = true;
        P.SetButtons(P.ENG_button);
        Eng.SetActive(true);
        EngMap.SetActive(true);
        gameObject.SetActive(false);
    }
    public void Thai()
    {
        Player.Instance.GetComponent<ThirdPersonController>().enabled = false;
        Player.Instance.GetComponent<ThirdPersonController>().enabled = true;
        P.SetButtons(P.Buttons);
        TH.SetActive(true);
        THMap.SetActive(true);
        gameObject.SetActive(false);
    }
}
