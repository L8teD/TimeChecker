namespace TimeChecker.Types
{
    public static class TypeConverter
    {
        public static WorkPeriods DateTimeToPeriods(DateTime date)
        {
            WorkPeriods period = (WorkPeriods)date.Month;

            if (date.Day >= 20)
                period = (WorkPeriods)(((int)period) + 1);

            return period;
        }
    }
}
