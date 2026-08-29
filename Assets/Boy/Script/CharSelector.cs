using UnityEngine;

public class CharSelector : MonoBehaviour
{
    public GameObject[] Player;
    public Avatar[] Avatars;
    public Animator animator;
    public GameObject P;

    private void Start()
    {
        print(gameObject.name);
        P.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
    public void SelectChar(int I)
    {
        for (int i = 0; i < Player.Length; i++)
        {
            if (i != I)
            {
                Destroy(Player[i]);
            }
            else if (i == I)
            {
                animator.avatar = Avatars[i];
                Player[I].gameObject.SetActive(true);
            }
        }
        P.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Destroy(gameObject.transform.parent.gameObject);
    }
}
