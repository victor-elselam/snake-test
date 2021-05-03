﻿using System.Linq;
using Context;
using Tutorial;

namespace _Tests
{
    public class TestContext : IContext
    {
        public TestContext(NavigationController navigationController, GameController gameController, PopupUtility popupUtility, GameSetup gameSetup)
        {
            ContextProvider.Subscribe(this);
            
            GameSetup = gameSetup;
            
            NavigationController = navigationController;
            GameController = gameController;
            Popup = popupUtility;
            AvailableKeys = new AvailableKeys(gameSetup.AvailableKeys.ToList());
            Characters = new Characters(GameSetup.Characters.ToList());
        }

        public GameController GameController  { get; }
        public PopupUtility Popup  { get; }
        public AvailableKeys AvailableKeys  { get; }
        public NavigationController NavigationController { get; }
        public GameSetup GameSetup { get; }
        public Characters Characters { get; }
        public Environment Environment => Environment.Test;
    }
}