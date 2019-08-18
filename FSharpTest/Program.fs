open FSharp.Data
open System

type Csv = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">
type Stats = Csv.Row

let firstRow :Stats = 
    let stats = Csv.Load("/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv")
    stats.Rows |> Seq.head

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let row = firstRow
    printf "%A" row
    0 // return an integer exit code

