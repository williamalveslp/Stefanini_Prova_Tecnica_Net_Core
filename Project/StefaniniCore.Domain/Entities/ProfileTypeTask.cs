namespace StefaniniCore.Domain.Entities
{
    public class ProfileTypeTask
    {
        public virtual int Id { get; private set; }
        public virtual int TaskId { get; private set; }
        public virtual int ProfileTypeId { get; private set; }

        public virtual ProfileType ProfileType { get; private set; }
        public virtual Task Task { get; private set; }

        protected ProfileTypeTask() { }

        public ProfileTypeTask(int taskId, int profileId) : base()
        {
            this.TaskId = taskId;
            this.ProfileTypeId = profileId;
        }
    }
}
