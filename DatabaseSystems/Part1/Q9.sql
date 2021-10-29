SELECT restaurant.name, food_item.name
FROM food_item 
LEFT JOIN order_item ON food_item.id = order_item.food_item_id
JOIN restaurant ON food_item.restaurant_id = restaurant.id
WHERE order_item.order_id IS NULL
