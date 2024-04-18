CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(30),
    LastName VARCHAR(50),
    Address1 VARCHAR(100)
);

CREATE TABLE Managers (
    ManagerID INT PRIMARY KEY,
    EmployeeID INT,
    AnnualSalary DECIMAL(10, 2),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

CREATE TABLE Supervisors (
    SupervisorID INT PRIMARY KEY,
    EmployeeID INT,
    AnnualSalary DECIMAL(10, 2),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

CREATE TABLE EmployeeDetails (
    EmployeeID INT PRIMARY KEY,
    PayPerHour DECIMAL(5, 2),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

CREATE TABLE BusinessExpenses (
    ExpenseID INT PRIMARY KEY,
    ManagerID INT,
    MaxExpenseAmount DECIMAL(10, 2),
    FOREIGN KEY (ManagerID) REFERENCES Managers(ManagerID)
);
