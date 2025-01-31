SELECT user_id, email
FROM Users
WHERE email REGEXP '^[0-9a-zA-Z_]+@[A-Za-z]+\\.com'
ORDER BY user_id
