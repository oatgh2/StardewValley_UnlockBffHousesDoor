using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlockBffHousesDoor.Events
{
  internal class UserEvents
  {
    public IModHelper Helper { get; private set; }

    public UserEvents(IModHelper helper) 
    {
      RegisterEvents();
    }

    private void RegisterEvents()
    {
      Helper.Events.Input.ButtonPressed += OnButtonPressed;
    }

    private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
    {
      if (!Context.IsWorldReady)
        return;

      if (e.Button != SButton.MouseLeft && e.Button != SButton.ControllerA && !e.Button.IsActionButton())
        return;

      Farmer player = Game1.player;
      
    }
  }
}
