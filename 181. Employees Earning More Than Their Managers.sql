SELECT employee2.name as Employee
FROM employee employee1
INNER JOIN employee employee2 ON employee1.id = employee2.managerID
WHERE employee1.salary < employee2.salary

