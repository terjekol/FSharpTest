open System
open FSharp.Data

type Csv = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">
let rawItems = Csv.Load("/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv")
type Stats = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">.Row
let x  :Stats = {
    OBX = 5
    Siste = 7
}
type DayStats =
    { LocalHigh : decimal
      LocalLow : decimal
      Index : decimal
      Date : DateTime }

let statsFromRaw (current:DayStatsRaw) previous =
    { LocalLow = min current.Siste previous.Index
      LocalHigh = max current.Siste previous.Index
      Index = current.Siste
      Date = current.OBX }

let stats = 
    printf "Stats"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    stats
    0 // return an integer exit code

