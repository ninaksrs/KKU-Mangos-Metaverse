using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public GameObject BusLineUI;
    private void Awake()
    {
        Instance = this;
    }
}
