using System;

namespace StefaniniCore.Domain.ValueObject
{
    public abstract class ValueObjectBase
    {
        public int Id { get; private set; }

        public DateTime Date_Created { get; private set; }

        public DateTime Date_Updated { get; private set; }

        protected ValueObjectBase()
        {
            var currentDateTime = DateTime.Now;
            this.Date_Created = currentDateTime;
            this.Date_Updated = currentDateTime;
        }

        protected void RefreshDateUpdated()
        {
            this.Date_Updated = DateTime.Now;
        }
    }
}
