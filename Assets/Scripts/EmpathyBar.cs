using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpathyBar : MonoBehaviour
{
    public static EmpathyBar instace;
    public int currentEmpathy;
    public GameObject Barrita;
    public RectTransform Bar;

    public void Awake()
    {
        instace = this;
    }
    public void Start()
    {
        currentEmpathy = GameManager.instance.empathy;
        Bar = Barrita.GetComponent<RectTransform>();
    }
    public void Update()
    {
        currentEmpathy = GameManager.instance.empathy;
        if (currentEmpathy == 0)
        {
            Bar.anchorMin = new Vector2((float)0.2429743, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.3205945, (float)0.9001819);
        }

        if (currentEmpathy == 1)
        {
            Bar.anchorMin = new Vector2((float)0.2898696, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.3674898, (float)0.9001819);
        }

        if (currentEmpathy == 2)
        {
            Bar.anchorMin = new Vector2((float)0.3474238, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.4250439, (float)0.9001819);
        }

        if (currentEmpathy == 3)
        {
            Bar.anchorMin = new Vector2((float)0.4028462, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.4804664, (float)0.9001819);
        }

        if (currentEmpathy == 4)
        {
            Bar.anchorMin = new Vector2((float)0.4561371, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.5337572, (float)0.9001819);
        }

        if (currentEmpathy == 5)
        {
            Bar.anchorMin = new Vector2((float)0.5072963, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.5849164, (float)0.9001819);
        }
        if (currentEmpathy == 6)
        {
            Bar.anchorMin = new Vector2((float)0.5694664, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.6470865, (float)0.9001819);
        }

        if (currentEmpathy == 7)
        {
            Bar.anchorMin = new Vector2((float)0.6351947, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.7128148, (float)0.9001819);
        }
        if (currentEmpathy == 8)
        {
            Bar.anchorMin = new Vector2((float)0.6884855, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.7661057, (float)0.9001819);
        }
        if (currentEmpathy == 9)
        {
            Bar.anchorMin = new Vector2((float)0.7353811, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.8130013, (float)0.9001819);
        }
        if (currentEmpathy == 10)
        {
            Bar.anchorMin = new Vector2((float)0.7844085, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.8620287, (float)0.9001819);
        }
        if (currentEmpathy == 11)
        {
            Bar.anchorMin = new Vector2((float)0.8398311, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.9174513, (float)0.9001819);
        }
        if (currentEmpathy == 12)
        {
            Bar.anchorMin = new Vector2((float)0.8874784, (float)0.1276665);
            Bar.anchorMax = new Vector2((float)0.9650985, (float)0.9001819);
        }
    }
}
