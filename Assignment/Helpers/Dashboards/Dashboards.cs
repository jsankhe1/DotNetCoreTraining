using Assignment.Helpers.Enums;

namespace Assignment.Helpers.Dashboards;

public class PrimeDashboard : GenericDashboard<PrimeAssignment>
{
    public PrimeDashboard() : base(MenuHandler.MenuPrimeSelection)
    {
    }
}


public class AssignmentOneDashboard : GenericDashboard<AssignmentOneTasks>
{
    public AssignmentOneDashboard() : base(MenuHandler.MenuOneSelection)
    {
    }
}

public class AssignmentTwoDashboard : GenericDashboard<AssignmentTwoTasks>
{
    public AssignmentTwoDashboard() : base(MenuHandler.MenuTwoSelection)
    {
    }
}

public class AssignmentThreeDashboard : GenericDashboard<AssignmentThreeTasks>
{
    public AssignmentThreeDashboard() : base(MenuHandler.MenuThreeSelection)
    {
    }
}