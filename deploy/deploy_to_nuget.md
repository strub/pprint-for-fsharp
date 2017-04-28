
Follow the simple flow outlined in https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package. 

1. Build the project. 

2. There is already a nuspec file in `deploy\pprint.nuspec`. You can edit it if you need to. 

3. cd to `pprint`, and copy up the file from `deploy`: `cp ../deploy/pprint.nuspec. Run `nuget pack pprint.nuspec`. (Ensure `FSharp.PPrint.dll` is accessible from `pprint`.)

  This creates a `FSharpForPPrint.$version.nupkg`, a zip with the dll and various meta-data in it. 

4. Log on to `nuget.org`, get your API key. Publish the package 
```
       nuget push PPrintForFSharp.0.0.$x.nupkg $api_key -Source https://www.nuget.org/api/v2/package
```

5. Check it all works by pulling in the package into a F*/F# project. 

