Mono.Data.OdbcCore
ODBC for .Net Core is based on old version of Mono prior to Mono including parts from of .Net Reference source.

A better implementation would be based on the .NET Framework Reference Source.

Update 04/22/2017 - please see .NET Core FX repo - someone has ported Microsoft's System.Data.Odbc to .Net Core
https://github.com/dotnet/corefx/issues/13035
https://github.com/dotnet/corefx/tree/master/src/System.Data.Odbc

.Net Core Data Access
https://blogs.msdn.microsoft.com/dotnet/2016/11/09/net-core-data-access/

Right now, Mono.Data.OdbcCore works on .Net Core on Windows.  I need to platform invoke into libraries on other platforms like Linux by using 
a different shared library name.  Example: Windows has  foo.dll while Linux has libfoo.so and Mac has libfoo.dynlib
