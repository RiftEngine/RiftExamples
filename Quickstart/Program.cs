using Rift.RiftEngine.Core;

namespace Rift.RiftEngine.Examples
{
  internal class Program
  {
    static void Main(string[] args) 
    {
      Config config = GameConfigManager.ReadGameConfiguration("config.json");
      
      Engine.gameReference = new Quickstart(config);
      
      Engine.Init();
      
      Engine.Start();
      
      Engine.Stop();
    }
  }
  
  public class Quickstart : Game
  {
    public Quickstart(Config config) : base(config) { }
    
    public override void Init()
    {
      AddInteraction(new Interaction("GameStart", Events.GameStart, new FilePath("interactions/GameStart.txt")));
      AddInteraction(new Interaction("GameStop". Events.GameStop, new FilePath("interactions/GameStop.txt")));
    }
  }
}
