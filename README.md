
# Dotnet Stryker Demo

### Installation

`dotnet restore`

`dotnet tool restore`

### Ensure tests pass

`dotnet test`

### Run Stryker

`cd Tests` 

`dotnet strkyer`

### Output

In the Tests dir a directory `StrykerOutput` should appear with the report.
Open the Report in your favorite Browser and have a look at the mutations. 

You can add the --open-report flag to the command to open the report right after Stryker is done.