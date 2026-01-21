using System;
using System.Collections.Generic;
using System.Text;

namespace cli_tasktracker.models
{
    enum TaskStatus // Enum to represent the task status
    {
        Pending,
        InProgress,
        Completed,
        OnHold,
        Cancelled
    }

    enum TaskPriority // Enum to represent the task priority
    {
        Low,
        Medium,
        High
    }

    class Task
    {
        public string id { get; } // TaskID is read-only, can't be changed after creation 
        public string name { get; set; }
        public string description { get; set; } 
        public TaskStatus status { get; set; }
        public TaskPriority priority { get; set; }
        
        public Task(string id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.status = TaskStatus.Pending;
            this.priority = TaskPriority.Low;
        }
    }
}
