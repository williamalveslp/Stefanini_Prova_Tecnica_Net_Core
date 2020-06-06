namespace StefaniniCore.Domain.Entities
{
    public class ProfileTypeTask
    {
        public int Id { get; private set; }
        public int TaskId { get; private set; }
        public int ProfileTypeId { get; private set; }

        public virtual ProfileType ProfileType { get; private set; }
        public virtual Task Task { get; private set; }

        private ProfileTypeTask() { }

        public ProfileTypeTask(int taskId, int profileId) : base()
        {
            this.TaskId = taskId;
            this.ProfileTypeId = profileId;
        }
    }
}
