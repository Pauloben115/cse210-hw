public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override int RecordEvent()
    {
        if (!completed)
        {
            completed = true;
            return points;
        }
        return 0;
    }
}
