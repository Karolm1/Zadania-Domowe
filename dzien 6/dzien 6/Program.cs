Employee employee1 = new Employee("Adam", "Nowak", 32);
Employee employee2 = new Employee("Weronika", "Górska", 29);
Employee employee3 = new Employee("Dominik", "Weszyński", 38);

employee1.AddScore(6);
employee1.AddScore(8);
employee1.AddScore(4);
employee1.AddScore(2);
employee1.AddScore(4);

employee2.AddScore(4);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(5);
employee2.AddScore(3);

employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(6);
employee3.AddScore(3);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>()
{
  employee1, employee2, employee3
};

int maxResult = -1;

Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employeeWithMaxResult.Result;
    }
}

var name = employeeWithMaxResult.name;
var lastname = employeeWithMaxResult.lastname;
var age = employeeWithMaxResult.age;
var result = employeeWithMaxResult.Result;

Console.WriteLine

("Pracownik z największą liczbą punktów:" + name + " " + lastname + ", " + age + "lat," + result + " punktów.");       