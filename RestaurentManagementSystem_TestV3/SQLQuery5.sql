SELECT * FROM orders

SELECT SUM(prod_price) FROM orders WHERE customer_id = 1

SELECT * FROM products WHERE prod_id = 1

SELECT MAX(customer_id) FROM customers

ALTER TABLE products
ALTER COLUMN prod_id VARCHAR(50) NOT NULL;

ALTER TABLE orders
ALTER COLUMN prod_id VARCHAR(50) NOT NULL;

SELECT * FROM customers

ALTER TABLE customers
ADD amount FLOAT NULL

ALTER TABLE customers
ADD change FLOAT NULL

SELECT COUNT(id) FROM customers