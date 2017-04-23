Mono.Data.OdbcCore  
  
ODBC for .Net Core is based on old version of Mono prior to Mono including parts from the .Net Reference source.  
  
A better implementation would be based on the .NET Framework Reference Source.  
  
Update 04/22/2017 - please see .NET Core FX repo - someone has ported Microsoft's System.Data.Odbc to .Net Core  
https://github.com/dotnet/corefx/issues/13035  
https://github.com/dotnet/corefx/tree/master/src/System.Data.Odbc  
  
Update 04/23/2017 - converted Visual Studio solution/project to Visual Studio 2017 and add compiler define for libodbc.cs  
  
To enable this to work on a particular platform, define this in libodbc.cs  
  ODBC_WINDOWS to define Windows to use "odbc32.dll"   
  ODBC_LINUX to define Linux to use "libodbc.so"  
  ODBC_MAC to define Mac OS to use "libodbc.dynlib"  
  
Example:  
#define ODBC_WINDOWS  
  
Right now, Mono.Data.OdbcCore works on .Net Core on Windows.  I need to platform invoke into libraries on other platforms like Linux by using 
a different shared library name.  Example: Windows has  foo.dll while Linux has libfoo.so and Mac has libfoo.dynlib  
  
.Net Core Data Access  
https://blogs.msdn.microsoft.com/dotnet/2016/11/09/net-core-data-access/  
