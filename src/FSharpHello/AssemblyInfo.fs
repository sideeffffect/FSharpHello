namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharpHello")>]
[<assembly: AssemblyProductAttribute("FSharpHello")>]
[<assembly: AssemblyDescriptionAttribute("F# hello world")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
