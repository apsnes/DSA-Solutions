SELECT u.name,
if(SUM(r.distance) IS null, 0, SUM(r.distance)) AS travelled_distance
FROM Users u LEFT JOIN Rides r
ON u.id = r.user_id
GROUP BY user_id
ORDER BY travelled_distance DESC, u.name
