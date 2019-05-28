#r @"C:\Users\tforkmann\Documents\1_Programming\1_test\ExcelProvider\packages\ExcelProvider\lib\netstandard2.0\ExcelProvider.Runtime.dll"
#r "netstandard"
open FSharp.Interop.Excel

type BmDme = ExcelFile<"Monatswerte_2018_06_05_0830_DE9999990921200000000000101011698.xls",Range="A8:U1000">

let file =  BmDme()
let rows = file.Data |> Seq.toArray
let header = rows.[0]
let value = rows.[1..999]