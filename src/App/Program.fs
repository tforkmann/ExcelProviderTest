// Learn more about F# at http://fsharp.org

open System.IO

open FSharp.Interop.Excel
open System
open System.Collections.Generic
open System.Text
// let folder = "../../src/App/files/Monatswerte_2018_06_05_0830_DE9999990921200000000000101011698.xls"
// let path = Path.GetFullPath folder
// // printfn "folder %A" Folder
// printfn "CurrentFolder %A" (Directory.GetCurrentDirectory())

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
type BmDme = ExcelFile<"Book.xlsx",Range="A8:U1000">

// let file =  BmDme()
// let rows = file.Data |> Seq.toArray
// let header = rows.[0]
// let value = rows.[1..999]

[<EntryPoint>]
let main argv =
    printfn "values %A" "blub"
    0 // return an integer exit code
