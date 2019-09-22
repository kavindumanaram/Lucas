# Lucas
dotnet core api project to act as backend to one of pet platform

steps
---

1. to create inital models [db first method]

`Scaffold-DbContext "server=DESKTOP-EK0IL6Q\SQLEXPRESS; database=Lucas;user id=sa;password=RoseJ; Integrated Security=true; MultipleActiveResultSets=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models`

2. to update models forcefully

`Scaffold-DbContext "server=DESKTOP-EK0IL6Q\SQLEXPRESS; database=Lucas;user id=sa;password=RoseJ; Integrated Security=true; MultipleActiveResultSets=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -force`




