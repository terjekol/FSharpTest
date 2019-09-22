#r "/Users/terje/Projects/OsxStocks/packages/FSharp.Data.3.1.1/lib/net45/FSharp.Data.dll"
//#r "/Users/terje/.nuget/packages/fsharp.data/3.1.1/lib/net45/FSharp.Data.dll"

open FSharp.Data
open System

type Csv = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">
type Stats = Csv.Row
let statsRaw = Csv.Load("/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv")
type StatsX = {IndexValue: decimal; Date: DateTime; DayNo: int; LocalMin: decimal; LocalMax: decimal}
let createStat (s:Stats) (i:int) = 
    let sx = {IndexValue= s.Siste; Date= DateTime.Now; DayNo= i; LocalMin= 0m; LocalMax= 0m}
    sx

let stats = statsRaw.Rows |> Seq.rev |> Seq.map(createStat)


 //let firstRow :Stats = stats.Rows |> Seq.head
 //let lastRow :Stats = stats.Rows |> Seq.rev |> Seq.head
 //let lastDate = firstRow.Siste
 //let lastOpen = firstRow.OBX

