using System;
namespace Structs 
{
    public record class Programmer(string name);
    public record class Accountant(string name);

    public class Employees 
    {
        public List<Programmer> programmers = new List<Programmer>();
        public List<Accountant> accountants = new List<Accountant>();
        
    }
}