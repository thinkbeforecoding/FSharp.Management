module FSharp.Management.Tests.FileSystemProviderTests

open FSharp.Management
open NUnit.Framework
open FsUnit

type Users = FileSystem<"C:\\Users\\">

[<Test>] 
let ``Can create type for users path``() = 
    Users.Path |> should equal @"C:\Users\"

[<Test>] 
let ``Can access the default users path``() = 
    Users.Default.Path |> should equal @"C:\Users\Default"


// Access relative path
RelativePath.Bin.Path |> ignore

// access a file
RelativePath.``WMI.Tests.fs`` |> ignore

// access parent
RelativePath.Parent.Path |> ignore