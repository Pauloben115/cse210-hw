public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
            score += goals[index].GetPoints();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetStatus()} {goals[i].GetType().Name}: {goals[i].ToString()}");
        }
    }

    public int GetScore() => score;
}
