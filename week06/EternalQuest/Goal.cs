using System;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int points;
    protected bool completed;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
        this.completed = false;
    }

    public abstract int RecordEvent();

    public virtual string GetStatus()
    {
        return completed ? "[X]" : "[ ]";
    }

    public bool IsComplete()
    {
        return completed;
    }

    public string GetName()
    {
        return name;
    }

    public string GetDescription()
    {
        return description;
    }

    public int GetPoints()
    {
        return points;
    }
}
