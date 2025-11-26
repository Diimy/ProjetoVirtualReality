using UnityEngine;
using UnityEngine.UI;

public class HeartUIController : MonoBehaviour
{
    public Image[] hearts;

    public void UpdateHearts(int currentLife, int maxLife)
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < currentLife)
                hearts[i].enabled = true;      // coração cheio
            else
                hearts[i].enabled = false;     // coração apagado
        }
    }
}
