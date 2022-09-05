using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI timerText;
    // Start is called before the first frame update
    private void Start()
    {
        hpText.text = "<color=green><b>+</b></color>"+(int)GameManager.instance.hp;
        timerText.text = GameManager.instance.timer.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameManager.instance.ResetValues();
            SceneManager.LoadScene(0);
        }
    }
}
