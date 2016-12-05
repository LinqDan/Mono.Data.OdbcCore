a# Mono.Data.OdbcCore
ODBC for .Net Core based on old version of Mono prior to its inclusion of .Net Reference source

A better implementation would be based on the .NET Framework Reference Source

.Net Core Data Access
https://blogs.msdn.microsoft.com/dotnet/2016/11/09/net-core-data-access/

Right now, it works on .Net Core on Windows.  I need to platform invoke into libraries on other platforms like Linux by using 
a different shared library name.  Example: Windows has  foo.dll while Linux has libfoo.so and Mac has libfoo.dynlib
