using UnityEngine.UI;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    public Image hpGauge;
    public void DecreseHP()
    {
        hpGauge.fillAmount -= 0.1f;
    }
}
