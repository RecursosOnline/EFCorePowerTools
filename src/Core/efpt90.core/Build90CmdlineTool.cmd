
dotnet publish -o bin\Release\net8.0\publish -f net8.0 -c Release --no-self-contained

del bin\Release\net8.0\publish\efpt.exe

"C:\Program Files\7-Zip\7z.exe" a efpt90.exe.zip .\bin\Release\net8.0\publish\efpt.*

move /Y efpt90.exe.zip ..\..\GUI\lib\

pause
