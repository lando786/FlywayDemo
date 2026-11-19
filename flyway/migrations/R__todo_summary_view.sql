CREATE OR ALTER VIEW dbo.TodoSummary AS
SELECT COUNT(*) AS Total,
       SUM(CASE WHEN IsComplete = 1 THEN 1 ELSE 0 END) AS Completed
FROM dbo.Todo;
