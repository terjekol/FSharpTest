#r "/Users/terje/Projects/OsxStocks/packages/FSharp.Data.3.1.1/lib/net45/FSharp.Data.dll"
//#r "/Users/terje/.nuget/packages/fsharp.data/3.1.1/lib/net45/FSharp.Data.dll"

open FSharp.Data
open System

//let items = CsvProvider<"C:\\Users\\terje\\Source\\Repos\\FSharpTest\\FSharpTest\\data.csv">.GetSample()
type DayStatsRaw = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">
let items = DayStatsRaw.GetSample()

type DayStats =
    { LocalHigh : decimal
      LocalLow : decimal
      Index : decimal
      Date : DateTime }

let StatsFromRaw (current:DayStatsRaw) previous =
    { LocalLow = min current.Siste previous.Index
      LocalHigh = max current.Siste previous.Index
      Index = current.Siste
      Date = current.OBX }
