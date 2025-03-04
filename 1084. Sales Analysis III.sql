-- Aggregate function solution
SELECT p.product_id, p.product_name
FROM product p JOIN sales s ON p.product_id = s.product_id
GROUP BY s.product_id
HAVING MIN(s.sale_date) >= "2019-01-01"
AND MAX(s.sale_date) <= "2019-03-31";

-- Multi-table solution
SELECT product_id, product_name
FROM product
WHERE product_id IN (
    SELECT product_id
    FROM sales
    WHERE sale_date >= "2019-01-01"
    AND sale_date <= "2019-03-31"
)
AND product_id NOT IN (
    SELECT product_id
    FROM sales
    WHERE sale_date < "2019-01-01"
    OR sale_date > "2019-03-31"
);
