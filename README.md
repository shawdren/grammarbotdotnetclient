# grammarbotdotnetclient
grammarbot dot net core console client


## Documentation

Please refer to the official docs at [grammarbot.io/quickstart](https://www.grammarbot.io/quickstart)

## Dev Environment
1. VS2019
2. Notcore 3.0.100

## Installation

```csharp
Add reference to your project
```


## Methods

### 1. grammarBot.CheckAsync(text)

## Usage

```csharp
GrammarBotClient.GrammarBot grammarBot = new GrammarBotClient.GrammarBot(new GrammarBotClient.ApiConfig());
var grammar = await grammarBot.CheckAsync(Console.ReadLine());
```
1. Open the solution in VS2019
2. Set the project of GrammarBotDotNetCoreClient as default project
3. Run up the console application
4. Write something on the command line
5. The response message will display on the console.


## License

This npm package is available under the terms of the [MIT License](http://opensource.org/licenses/MIT).

