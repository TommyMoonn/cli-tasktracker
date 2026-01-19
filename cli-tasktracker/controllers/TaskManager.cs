using System;
using System.Collections.Generic;
using System.Text;
using cli_tasktracker.models;

namespace cli_tasktracker.controllers
{
    internal class TaskManager
    {
        private List<models.Task> tasks;

        public TaskManager()
        {
            tasks = new List<models.Task>();
        }

        public void Add(models.Task task)
        {
            if (FindById(task.id) != null)
            {
                throw new InvalidOperationException("Task with the same ID already exists.");
            }
            tasks.Add(task);
        }

        public void Remove(models.Task task)
        {
            tasks.Remove(task);
        }

        public void Update(models.Task task)
        {
            var existingTask = FindById(task.id);
            if (existingTask == null)
            {
                throw new InvalidOperationException("Task not found.");
            } 
            else
            {
                var index = tasks.IndexOf(existingTask);
                tasks[index] = task;
            }
        }

        public models.Task FindById(string id)
        {
            models.Task task = tasks.Find(t => t.id == id);
            return task;
        }
    }
}
