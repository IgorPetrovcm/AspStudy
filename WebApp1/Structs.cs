using System;
namespace Structs 
{
    public record class Programmer(string name);
    public record class Accountant(string name);

    public class Employees 
    {
        List<Programmer> programmers = new List<Programmer>();
        List<Accountant> accountants = new List<Accountant>();
        
    }
}