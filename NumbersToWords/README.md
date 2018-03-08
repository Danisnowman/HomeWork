# Numbers to Words

The following is my university assignment on making a porgram that asks the user for three things. The first is a year, the second one is a month and the third is a day. Every input is entered as numbers and then the program outputs the date in the format DD/MM/YY. Where MM is written in words representing the number that the user entered (i.e. 1 is January, 2 February etc.).

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. Please see the prerequisites and notes to be able to try it.

### Prerequisites

What things you need to run the program?

```
dotnet 
```
```
dotnet-sdk 
```


### Installing

Pleaser refer to [.NET core Installation](https://github.com/dotnet/core/blob/master/release-notes/download-archives/2.0.3.md)

Also if using macOS and you have [Homebrew](https://brew.sh) installed, you can install dotnet by using homebrew:
``` 
brew cask install dotnet dotnet-sdk 
```
Then you'll want to create a new project under the name "Numbers To Words" with your terminal emulator using the command as follows:
``` 
dotnet new console -n "Numbers to Words" 
```
Then you'll wither want to replace Program.cs from your newly created project with the one from this repo, or just copy and paste de code.


## Running the tests

Run on your terminal emulator:
UNIX:
```
dotnet build && dotnet run
```

Powershell:
```
dotnet build; dotnet run
```


## Built With

* [VisualCode](https://code.visualstudio.com) - IDE used
* [.NET](https://www.microsoft.com/net/) - Framework used


## Authors

* **Daniel Hernández** - [webpage](https://www.danisnowman.com)  [Contact](mailto>danielernesto@ufm.edu)


## License

This project is licensed under the GPL License - see the [LICENSE.md](LICENSE.md) file for details

