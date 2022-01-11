
public class Command 
{
    public virtual void execute(Player player) { }
}

public class FireCommand : Command {

    override
    public  void execute(Player player) {
        player.fire();
    }

}

public class MoveCommand : Command
{

    override
    public void execute(Player player)
    {
        player.move();
    }

}