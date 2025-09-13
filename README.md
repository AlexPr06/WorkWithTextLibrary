# TextOperations Library

## Overview

`TextOperations` is a simple C# library for text analysis. It provides tools to count vowels and capitalize words in a string. The library can be easily integrated into console applications or other .NET projects.

The console application demonstrates using the library and serializing analysis results to JSON using **Newtonsoft.Json**.

---

## Features

- `TextAnalyzer.CountVowels(string input)`  
  Counts all vowels in the input string. Supports **English, Ukrainian, and Russian** vowels.

- `TextAnalyzer.CapitalizeWords(string input)`  
  Capitalizes the first letter of each word in the input string.

- Console application example:
  - Accepts user input
  - Analyzes text using `TextAnalyzer`
  - Serializes results to JSON
  - Prints JSON and processed text
