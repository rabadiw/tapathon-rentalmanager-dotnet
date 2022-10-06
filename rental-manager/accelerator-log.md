# Accelerator Log

## Options
```json
{
  "applicationName" : "RentalManager",
  "projectName" : "rental-manager"
}
```
## Log
```
┏ engine (Chain)
┃  Info Running Chain(GeneratorValidationTransform, UniquePath)
┃ ┏ ┏ engine.transformations[0].validated (Combo)
┃ ┃ ┃  Info Combo running as Chain(Merge(merge), UniquePath(UseLast))
┃ ┃ ┃ engine.transformations[0].validated.merge (Chain)
┃ ┃ ┃  Info Running Chain(Merge, UniquePath)
┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0] (Merge)
┃ ┃ ┃ ┃  Info Running Merge(Combo, Combo, Combo)
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[0] (Combo)
┃ ┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Exclude, Chain(chain))
┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.merge.transformations[0].sources[0].<combo> (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, Exclude, Chain)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[0].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃  Info Will include [**]
┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Controllers/WeatherForecastController.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug LICENSE matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Program.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Properties/launchSettings.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug README.md matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Sample.csproj matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug StaticFiles/index.html matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Tiltfile matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug WeatherForecast.cs matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug app.config matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.Development.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┗ Debug global.json matched [**] -> included
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[0].<combo>.transformations[1] (Exclude)
┃ ┃ ┃ ┃ ┃ ┃  Info Will exclude [README.md, Sample.csproj, config/**, catalog/**]
┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Controllers/WeatherForecastController.cs didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug LICENSE didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Program.cs didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Properties/launchSettings.json didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug README.md matched [README.md, Sample.csproj, config/**, catalog/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Sample.csproj matched [README.md, Sample.csproj, config/**, catalog/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug StaticFiles/index.html didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Tiltfile didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug WeatherForecast.cs didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug app.config didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.Development.json didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.json didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [README.md, Sample.csproj, config/**, catalog/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml matched [README.md, Sample.csproj, config/**, catalog/**] -> excluded
┃ ┃ ┃ ┃ ┃ ┗ Debug global.json didn't match [README.md, Sample.csproj, config/**, catalog/**] -> included
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[0].<combo>.transformations[2] (Chain)
┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[0].<combo>.transformations[2].transformations[0] (ReplaceText)
┃ ┃ ┃ ┃ ┗ ┗ ┗  Info Will replace [Sample->RentalManager]
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[1] (Combo)
┃ ┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Chain(chain))
┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.merge.transformations[0].sources[1].<combo> (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, Chain)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[1].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃  Info Will include [Sample.csproj]
┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Controllers/WeatherForecastController.cs didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug LICENSE didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Program.cs didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Properties/launchSettings.json didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug README.md didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Sample.csproj matched [Sample.csproj] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug StaticFiles/index.html didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Tiltfile didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug WeatherForecast.cs didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug app.config didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.Development.json didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.json didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┗ Debug global.json didn't match [Sample.csproj] -> excluded
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[1].<combo>.transformations[1] (Chain)
┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(RewritePath)
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[1].<combo>.transformations[1].transformations[0] (RewritePath)
┃ ┃ ┃ ┃ ┗ ┗ ┗ Debug Path 'Sample.csproj' matched '^(?<folder>.*/)?(?<filename>([^/]+?|)(?=(?<ext>\.[^/.]*)?)$)' with groups {ext=.csproj, folder=null, filename=Sample.csproj, g0=Sample.csproj, g1=null, g2=Sample.csproj, g3=Sample.csproj, g4=.csproj} and was rewritten to 'RentalManager.csproj'
┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[2] (Combo)
┃ ┃ ┃ ┃ ┃  Info Combo running as Chain(Include, Chain(chain))
┃ ┃ ┃ ┃ ┃ engine.transformations[0].validated.merge.transformations[0].sources[2].<combo> (Chain)
┃ ┃ ┃ ┃ ┃  Info Running Chain(Include, Chain)
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[2].<combo>.transformations[0] (Include)
┃ ┃ ┃ ┃ ┃ ┃  Info Will include [README.md, config/*.yaml, catalog/*.yaml]
┃ ┃ ┃ ┃ ┃ ┃ Debug .gitignore didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Controllers/WeatherForecastController.cs didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug LICENSE didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Program.cs didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Properties/launchSettings.json didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug README.md matched [README.md, config/*.yaml, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug Sample.csproj didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug StaticFiles/index.html didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug Tiltfile didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug WeatherForecast.cs didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug app.config didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.Development.json didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug appsettings.json didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┃ Debug catalog/catalog-info.yaml matched [README.md, config/*.yaml, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ ┃ Debug config/workload.yaml matched [README.md, config/*.yaml, catalog/*.yaml] -> included
┃ ┃ ┃ ┃ ┃ ┗ Debug global.json didn't match [README.md, config/*.yaml, catalog/*.yaml] -> excluded
┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[2].<combo>.transformations[1] (Chain)
┃ ┃ ┃ ┃ ┃ ┃  Info Running Chain(ReplaceText)
┃ ┃ ┃ ┃ ┃ ┃ ┏ engine.transformations[0].validated.merge.transformations[0].sources[2].<combo>.transformations[1].transformations[0] (ReplaceText)
┃ ┃ ┃ ┗ ┗ ┗ ┗  Info Will replace [Sample->RentalManager, sample-app->rental-manager]
┃ ┗ ┗ ╺ engine.transformations[0].validated.merge.transformations[1] (UniquePath)
┗ ╺ engine.transformations[1] (UniquePath)
```
