/* Write your T-SQL query statement below */
SELECT MAX(Salary) AS SecondHighestSalary 
FROM Employee
WHERE Employee.Salary < (SELECT MAX(Salary) FROM Employee)