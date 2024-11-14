using FluentAssertions;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void OppositeTilesAreEqual()
    {
        var t1 = new Tile(1, 2);
        var t2 = new Tile(2, 1);
        t1.Equals(t2).Should().BeTrue();
    }

    [Fact]
    public void GameNotOverOnCreation()
    {
        Game testGame = new Game();

        testGame.IsGameOver.Should().Be(false);
    }

    [Fact]
    public void NewGameIsNotPlayable()
    {
        Game testGame = new Game();

        testGame.IsPlayable.Should().Be(false);
    }

    [Fact]
    public void APlayerCanJoin()
    {
        Game testGame = new Game();
        Player anotherPlayer = new Player("test player 1");
        testGame.Join(anotherPlayer);
        testGame.IsPlayable.Should().Be(false);
    }

    [Fact]
    public void TwoPlayersCanJoin()
    {
        Game testGame = new Game();
        Player firstPlayer = new Player("first player");
        Player secondPlayer = new Player("second player");
        testGame.Join(firstPlayer);
        testGame.Join(secondPlayer);
        testGame.IsPlayable.Should().Be(true);
    }
}
