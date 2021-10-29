SELECT COUNT(rider.user_id)
FROM rider INNER JOIN employee ON rider.user_id = employee.user_id
WHERE rider.end_date IS NULL AND employee.end_date IS NULL
