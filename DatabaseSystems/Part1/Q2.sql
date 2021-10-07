SELECT COUNT (payment_method_id), name
FROM orders LEFT JOIN payment_method ON orders.payment_method_id = payment_method.id
GROUP BY name
