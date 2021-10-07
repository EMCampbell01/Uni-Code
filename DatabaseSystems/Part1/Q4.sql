SELECT name
FROM food_item
WHERE price >
 (SELECT price
  FROM food_item
  WHERE name = 'Grilled Tamarind Duck')
AND price <
 (SELECT price
  FROM food_item
  WHERE name = 'Gnocchi alla Sorrentina');
