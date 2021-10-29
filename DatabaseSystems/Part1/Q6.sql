SELECT users.first_name, users.last_name, COUNT(rider.id)
FROM orders 
JOIN rider 
ON orders.rider_id = rider.id
JOIN users 
ON users.id = rider.user_id
GROUP BY users.first_name, users.last_name
ORDER BY COUNT(rider.id) DESC
LIMIT 3
