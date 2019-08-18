#r "/Users/terje/Projects/OsxStocks/packages/FSharp.Data.3.1.1/lib/net45/FSharp.Data.dll"
//#r "/Users/terje/.nuget/packages/fsharp.data/3.1.1/lib/net45/FSharp.Data.dll"

open FSharp.Data
open System

 type Csv = CsvProvider<"/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv">
 type Stats = Csv.Row
 let stats = Csv.Load("/Users/terje/Documents/GitHub/FSharpTest/FSharpTest/data.csv")

 let firstRow :Stats = stats.Rows |> Seq.head
 let lastDate = firstRow.Siste
 let lastOpen = firstRow.OBX

