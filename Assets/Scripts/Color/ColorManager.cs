using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum COLOR
{
    RED,
    GREEN,
    BLUE,
    YELLOW,
    PURPLE,
    CYAN,
    CLEAR
}

public class ColorManager : Singleton<ColorManager>
{
    private ColorControl coltroller;
    private COLOR currentColor;

    #region Events
    public delegate void ChangeColor(COLOR color);
    public static event ChangeColor OnChangeColor;
    #endregion

    protected override void Awake()
    {
        base.Awake();
        coltroller = new ColorControl();
    }

    private void OnEnable()
    {
        coltroller.Enable();
    }

    private void OnDisable()
    {
        coltroller.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        coltroller.ColorChange.Red.started += _ => { if (OnChangeColor != null) OnChangeColor(SetColor(COLOR.RED)); };
        coltroller.ColorChange.Green.started += _ => { if (OnChangeColor != null) OnChangeColor(SetColor(COLOR.GREEN)); };
        coltroller.ColorChange.Blue.started += _ => { if (OnChangeColor != null) OnChangeColor(SetColor(COLOR.BLUE)); };
        coltroller.ColorChange.Yellow.started += _ => { if (OnChangeColor != null) OnChangeColor(SetColor(COLOR.YELLOW)); };
        coltroller.ColorChange.Purple.started += _ => { if (OnChangeColor != null) OnChangeColor(SetColor(COLOR.PURPLE)); };
        coltroller.ColorChange.Cyan.started += _ => { if (OnChangeColor != null) OnChangeColor(SetColor(COLOR.CYAN)); };

        coltroller.ColorChange.Wheel.performed += _ =>
        {
            if (OnChangeColor != null)
            {
                int x = (int)Mathf.Clamp(coltroller.ColorChange.Wheel.ReadValue<float>(), -1, 1);
                IncColor(x);
                OnChangeColor(currentColor);
            }
        };
    }

    private COLOR SetColor(COLOR color)
    {
        currentColor = color;
        return currentColor;
    }
    private COLOR IncColor(int i)
    {
        currentColor += i;
        if ((int)currentColor > 5)
            currentColor = COLOR.RED;
        else if ((int)currentColor < 0)
            currentColor = COLOR.CYAN;

        return currentColor;
    }
}
