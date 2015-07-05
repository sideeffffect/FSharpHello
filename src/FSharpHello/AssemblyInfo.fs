namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FSharpHello")>]
[<assembly: AssemblyProductAttribute("FSharpHello")>]
[<assembly: AssemblyDescriptionAttribute("F# hello world")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
