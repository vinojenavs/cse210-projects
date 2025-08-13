using System;
class MathAssignment : Assignment
{
    private string _section;
    private string _problem;
    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    {
        _section = section;
        _problem = problem;
    }
    public string GetHomeworkList()
    {
        return $"Section {_section} Probblems {_problem}";
    } 
}