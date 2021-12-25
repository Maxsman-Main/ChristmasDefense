using System.Collections;
using System.Collections.Generic;
using Characters;
using UnityEngine;

public class PlayerInputHandler
{
    private PlayerCommand _buttonQ;
    private PlayerCommand _buttonW;
    private PlayerCommand _buttonE;
    private PlayerCommand _buttonR;
    private MenuCommand _buttonESC;

    public void SetCommandQ(PlayerCommand command)
    {
        _buttonQ = command;
    }

    public void SetCommandW(PlayerCommand command)
    {
        _buttonW = command;
    }
    
    public void SetCommandE(PlayerCommand command)
    {
        _buttonE = command;
    }
    
    public void SetCommandR(PlayerCommand command)
    {
        _buttonR = command;
    }

    public void SetButtonESC(MenuCommand command)
    {
        _buttonESC = command;
    }

    public PlayerCommand HandlePlayerInput()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.JoystickButton0)) return _buttonQ;
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.JoystickButton1)) return _buttonW;
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.JoystickButton2)) return _buttonE;
        //if (Input.GetKeyDown(KeyCode.R)) return _buttonR;
        return null;
    }

    public MenuCommand HandleMenuInput()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) return _buttonESC;
        return null;
    }
}
