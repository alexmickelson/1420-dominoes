public static class Lobby
{
  public static List<Game> Games { get; } = new List<Game>();
  public static event Action? GameListChanged;

  public static void RunGameListChangedEvent()
  {
    GameListChanged?.Invoke();
  }
}