module FSharpHello.Tests

open FSharpHello
open NUnit.Framework
open FsUnit

[<Test>]
let ``hello returns 42`` () =
  Library.hello 42 |> should equal 42