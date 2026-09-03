using UnityEngine;
using TMPro;

public class ClearManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI clearText;

    private float timer = 0f;
    private bool isClear = false;

    void Update()
    {
        if (isClear)
            return;

        timer += Time.deltaTime;

        // 30•bŒo‰ß
        if (timer >= 30f)
        {
            isClear = true;
            clearText.gameObject.SetActive(true);
        }
    }
}