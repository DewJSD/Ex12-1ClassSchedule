namespace ClassSchedule.Models
{
    public class ClassScheduleUnitOfWork : IClassScheduleUnitOfWork
    {
        private ClassScheduleContext context { get; set; }
        public ClassScheduleUnitOfWork(ClassScheduleContext context)
        {
            this.context = context;
        }

        private Repository<Class> ClassData;
        public Repository<Class> Classes
        {
            get
            {
                if (ClassData == null)
                    ClassData = new Repository<Class>(context);
                return ClassData;
            }
        }

        private Repository<Teacher> TeacherData;
        public Repository<Teacher> Teachers
        {   
            get
            {
                if (TeacherData == null)
                    TeacherData = new Repository<Teacher>(context);
                return TeacherData;
            }
        }


        private Repository<Day> DayData;
        public Repository<Day> Days
        {
            get
            {
                if (DayData == null)
                    DayData = new Repository<Day>(context);
                return DayData;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
