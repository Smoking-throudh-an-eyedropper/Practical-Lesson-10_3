using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5
{
    public enum Status
    {
        Active,
        Completed
    } 
    class Task
    {
        public string Text
        {
            get { return Text; }
            set { Text = value; }
        }
        public Status status
        {
            get { return status; }
            set { status = value; }
        }
        public Task(string name,Status status)
        {
            Text = name;
            this.status = status;
        }
    }
}
