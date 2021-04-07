SELECT p.ProductName, SUM(od.UnitPrice*ISNULL(od.Quantity,0)*(1-od.Discount)) AS TotalAmount 
FROM [Order Details] AS od
INNER JOIN Orders AS o ON od.OrderID = o.OrderID
INNER JOIN Products AS p ON od.ProductID = p.ProductID
GROUP BY p.ProductName
ORDER BY ProductName


SELECT P.ProductName, SUM(OD.UnitPrice*ISNULL(OD.Quantity,0)*(1-OD.Discount)) AS TotalAmount  
FROM Products AS P INNER JOIN [Order Details] AS OD
ON OD.ProductID = P.ProductID INNER JOIN Orders  AS O
ON OD.OrderID = O.OrderID
GROUP BY P.ProductName
ORDER BY ProductName




