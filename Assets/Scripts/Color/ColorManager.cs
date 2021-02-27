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
        coltroller.ColorChange.Red.started += _ => { if (OnChangeColor != null) OnChangeColor(COLOR.RED); };
        coltroller.ColorChange.Green.started += _ => { if (OnChangeColor != null) OnChangeColor(COLOR.GREEN); };
        coltroller.ColorChange.Blue.started += _ => { if (OnChangeColor != null) OnChangeColor(COLOR.BLUE); };
        coltroller.ColorChange.Yellow.started += _ => { if (OnChangeColor != null) OnChangeColor(COLOR.YELLOW); };
        coltroller.ColorChange.Purple.started += _ => { if (OnChangeColor != null) OnChangeColor(COLOR.PURPLE); };
        coltroller.ColorChange.Cyan.started += _ => { if (OnChangeColor != null) OnChangeColor(COLOR.CYAN); };
    }
}
