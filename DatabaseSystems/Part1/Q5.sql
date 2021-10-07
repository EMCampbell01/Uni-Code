SELECT AVG(quantity)
FROM orders
JOIN order_item ON order_item.order_id = orders.id;
