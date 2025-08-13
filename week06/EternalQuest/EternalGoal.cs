public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points) {}

    public override int RecordEvent()
    {
        // Eternal goal never completes, always gives points
        return points;
    }

    public override string GetStatus()
    {
        return "[∞]"; // Symbol for never-ending goal
    }
}
