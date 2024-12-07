SELECT euni.unique_id, e.name
FROM Employees e LEFT JOIN EmployeeUNI euni on e.id = euni.id
