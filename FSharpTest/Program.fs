open FSharp.Data
open System

type Csv = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">
type Stats = Csv.Row
type StatsX = {IndexValue: decimal; Date: DateTime; DayNo: int; LocalMin: decimal; LocalMax: decimal}

let firstRow :Stats = 
    let stats = Csv.Load("/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv")
    stats.Rows |> Seq.head

let createStat (s:Stats) (i:int) = 
    {IndexValue= s.Siste; Date= DateTime.Now; DayNo= i; LocalMin= 0m; LocalMax= 0m}

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let row = firstRow
    printf "%A" row
    0 // return an integer exit code

