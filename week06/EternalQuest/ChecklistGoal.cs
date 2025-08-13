public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
        this.bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (!completed)
        {
            currentCount++;
            if (currentCount >= targetCount)
            {
                completed = true;
                return points + bonusPoints;
            }
            return points;
        }
        return 0;
    }

    public override string GetStatus()
    {
        return completed ? $"[X] Completed {currentCount}/{targetCount}" : $"[ ] Completed {currentCount}/{targetCount}";
    }
}
