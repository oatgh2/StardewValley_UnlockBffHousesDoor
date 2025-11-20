using StardewModdingAPI;

namespace UnlockBffHousesDoor.Events
{
  internal interface IEventsManipulator
  {
    public void RegisterHelper(IModHelper helper);
  }
}