SELECT name AS NAME, SUM(amount) AS BALANCE
FROM Users, Transactions
WHERE Users.account = Transactions.Account
GROUP BY Users.account HAVING BALANCE > 10000;
