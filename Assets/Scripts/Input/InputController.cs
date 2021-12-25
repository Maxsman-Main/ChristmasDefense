using System;
using System.Collections;
using System.Collections.Generic;
using Characters;
using UnityEngine;
using View;

public class InputController : MonoBehaviour
{
    [SerializeField] private Weapon _actor;
    [SerializeField] private MainMenuField _field;
    
    private PlayerInputHandler _inputHandler;

    private void Start()
    {
        _inputHandler = new PlayerInputHandler();
        _inputHandler.SetCommandQ(new AttackWhiteSnow());
        _inputHandler.SetCommandW(new AttackRedSnow());
        _inputHandler.SetCommandE(new AttackBlueSnow());
        _inputHandler.SetCommandR(new AttackGreySnow());
        _inputHandler.SetButtonESC(new ClickInMenuField());
    }

    private void Update()
    {
        PlayerCommand commandPlayer = _inputHandler.HandlePlayerInput();
        MenuCommand commandMenu = _inputHandler.HandleMenuInput();
        if (commandPlayer != null)
        {
            commandPlayer.Execute(_actor);
        }

        if (commandMenu != null)
        {
            commandMenu.Execute(_field);
        }
    }
}
