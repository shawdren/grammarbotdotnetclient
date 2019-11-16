# grammarbotdotnetclient
grammarbot dot net core console client


## Documentation

Please refer to the official docs at [grammarbot.io/quickstart](https://www.grammarbot.io/quickstart)


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


## License

This npm package is available under the terms of the [MIT License](http://opensource.org/licenses/MIT).

