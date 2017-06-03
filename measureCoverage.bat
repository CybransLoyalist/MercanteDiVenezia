packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:runtests.bat -register:user -filter:+[MercanteDiVenezia]* -excludebyattribute:*.ExcludeFromCoverage* -excludebyfile:*\*g.cs;*\*Designer.cs
packages\ReportGenerator.2.5.8\tools\ReportGenerator.exe -reports:results.xml -targetdir:coverage 
pause

