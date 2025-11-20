using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnlockBffHousesDoor.Events;

namespace UnlockBffHousesDoor.Events
{
  internal abstract class EventsManipulator : IEventsManipulator
  {
    protected IModHelper Helper;
    protected EventsManipulator(IModHelper helper)
    {
      RegisterHelper(helper);
    }

    public void RegisterHelper(IModHelper helper)
    {
      Helper = helper;
    }
  }
}
