module FSharpHello.Tests

open FSharpHello
open NUnit.Framework
open FsUnit
open FsCheck.NUnit

[<Test>]
let ``hello returns 42`` () =
  Library.hello 42 |> should equal 42

[<Property>]
let ``hello always returns 42``(x:int) =
  Library.hello x = 42
