using Newtonsoft.Json;
using StefaniniCore.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Entities
{
    public class Task : ValueObjectBase
    {
        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool IsActive { get; private set; }

        public virtual IList<ProfileTypeTask> ProfileTypeTask { get; set; }

        private Task() { }

        public Task(string name, string description) : base()
        {
            this.Name = name.Trim();
            this.Description = description;
            this.IsActive = true;
            this.ProfileTypeTask = new List<ProfileTypeTask>();
        }

        public void Update(string name, string description)
        {
            this.Name = name.Trim();
            this.Description = description;
            RefreshDateUpdated();
        }
    }
}
