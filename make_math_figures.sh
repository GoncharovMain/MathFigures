
dotnet new sln -n MathFiguresSolution

dotnet new classlib -o MathFigures
dotnet new classlib -o MathFigures.Tests

dotnet sln MathFiguresSolution.sln add MathFigures/MathFigures.csproj
dotnet sln MathFiguresSolution.sln add MathFigures.Tests/MathFigures.Tests.csproj

cd MathFigures.Tests

dotnet add package xunit

dotnet add reference ../MathFigures/MathFigures.csproj

cd ..

dotnet test -t

dotnet test --filter IndexViewDataMessage
# or all test "dotnet test"
