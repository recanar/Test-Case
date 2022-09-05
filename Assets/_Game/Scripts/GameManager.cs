using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float timer;
    public float hp;

    private void Awake()
    {
        if (instance!=null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void AddHp(float value)
    {
        hp =  Mathf.Clamp(hp+value,0,100);
        GameUI.instance.HpTextUpdate((int)hp);
    }
    public void TimerIncrease()
    {
        timer++;
        GameUI.instance.TimerTextUpdate((int)timer);
    }

    public void ResetValues()
    {
        hp = 75;
        timer = 0;
    }

    public void ReduceHpByWall(float value)
    {
        hp -= value;
        GameUI.instance.HpTextUpdate((int)hp);
    }
    public void ReduceHpByFire()
    {
        GameUI.instance.HpTextUpdate((int)hp);
    }
    
}
