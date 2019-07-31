#r "/Users/terje/.nuget/packages/fsharp.data/3.1.1/lib/net45/FSharp.Data.dll"
open FSharp.Data

let items = CsvProvider<"C:\\Users\\terje\\Source\\Repos\\FSharpTest\\FSharpTest\\data.csv">.GetSample()
