public class EuaDimissalProcess : DismissalProcess
{
    public override string Title => "employee dismissal";

    public override void Apply(DismissalArgs args)
    {
        args.Company.Money -= 2*args.Employe.Wage;
    }
}

public class EuaPaymentProcess : WagePaymentProcess
{
    public override string Title => "Salary payment";

    public override void Apply(WagePaymentArgs args)
    {
        args.Company.Money -= args.Employe.Wage;
    }
}

public class EuaProcessFactory : IProcessFactory
{
    public DismissalProcess CreateDismissalProcess() 
        => new EuaDimissalProcess();

    public WagePaymentProcess CreateWagePaymentProcess() 
        => new EuaPaymentProcess();
}