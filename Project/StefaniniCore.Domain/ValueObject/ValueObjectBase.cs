using System;

namespace StefaniniCore.Domain.ValueObject
{
    public abstract class ValueObjectBase
    {
        private ValueObjectBase()
        {
            var currentDateTime = new DateTime();
            this.Date_Created = currentDateTime;
            this.Date_Updated = currentDateTime;
        }

        protected int Id { get; private set; }

        protected DateTime Date_Created { get; private set; }

        protected DateTime Date_Updated { get; private set; }

        protected void RefreshDateUpdated()
        {
            this.Date_Updated = new DateTime();
        }
    }
}
