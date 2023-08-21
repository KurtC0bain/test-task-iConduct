
# Test Task iConduct


The project is a WCF application, that works with Employees data.

To handle requests exists an `EmployeeService` that has two methods

- `GetEmployeeById` - returns an Employee in a tree structure
- `EnableEmployee` - changes ‘Enable’ flag for the Employee

*Requirement:* not to use EntityFramework, only ADO.NET

*Note:* despite the name and description for method `GetEmployeeById` given in test task file, it has `bool` return type defined by default. 

Thats fine, but if you want to see an actual Employee returned please debug the program (breakpoints was also provided beforhand).
## API Reference

#### Get Employee By Id 

```http
  GET /Infrastructure/Services/Implementation/EmployeeService.svc/GetEmployeeById?id={2}
```

| Query parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `id` | `int` | Employee ID |


#### Enable Employee

```http
  PUT /Infrastructure/Services/Implementation/EmployeeService.svc/EnableEmployee?id={id}
```

| Query parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `id` | `int` | Employee ID |


| Body parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `enable` | `int` | value of enablement - 0 or 1 


## NB

I used default connection string that was provided in test task


```
Data Source=(local);Initial Catalog=Test;User ID=sa;Password=**********;

```
In case of any problem with connection to the database please ensure that your database has name `Test` and table `Employee` in it. 