SELECT name
FROM food_item
WHERE food_item.price < (SELECT food_item.price FROM food_item WHERE food_item.name = 'Gnocchi alla Sorrentina')
AND food_item.price > (SELECT food_item.price FROM food_item WHERE food_item.name = 'Grilled Tamarind Duck Breast')
