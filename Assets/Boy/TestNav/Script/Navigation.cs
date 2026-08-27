using StarterAssets;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{
    public Transform[] Targets;
    public Button[] Buttons;
    public Transform Target;
    public float DistancefromTarget;
    public TextMeshProUGUI DistText;

    public GameObject obj;
    public bool active;
    private void Awake()
    {
    }

    void Start()
    {
        SetButtons();
        //DistText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        openTPUI();

    }

    public void openTPUI()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            print("AAAA");
            openMap();
        }
    }
    public void openMap()
    {
        if (active)
        {
            obj.SetActive(false);
            active = false;
            Cursor.lockState = CursorLockMode.Locked;
            GetComponentInParent<ThirdPersonController>().enabled = true;
        }
        else
        {
            obj.SetActive(true);
            active = true;
            Cursor.lockState = CursorLockMode.None;
            GetComponentInParent<ThirdPersonController>().enabled = false;
        }
    }
    public void SetButtons()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            int I = i;
            Buttons[I].onClick.AddListener(() => StartCoroutine(tp(I)));
        }
        //DistText.gameObject.SetActive(true);
    }
    public IEnumerator tp(int i)
    {
        transform.parent.GetComponent<ThirdPersonController>().enabled = false;
        transform.parent.position = Targets[i].position;

        yield return new WaitForSeconds(0.1f);

        Invoke("setPcontrol", 0.1f);
    }
    public void setPcontrol()
    {
        transform.parent.GetComponent<ThirdPersonController>().enabled = true;
    }
}
