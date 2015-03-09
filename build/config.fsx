#load "../.quicksilver/QuickSilver/tools/settings.fsx"
open QuickSilver

let settings = 
    settings 
    |> build (fun p -> 
        {p with solutions = ["src\MyWebsite\MyWebsite.sln"]; restorePackagesPriorToBuild = true}
    )
    |> nunit (fun p ->
        {p with nunitTests = [@"**\bin\@buildMode@\*Tests.dll"]}
    )
    |> websites (fun p ->
        {p with projFiles = [@"**\MyWebsite.csproj"]}
    )
    |> websitesCIPublishRoot "\\networkshare\publish"
    
