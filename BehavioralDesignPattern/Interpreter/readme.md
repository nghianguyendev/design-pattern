# Interpreter
- The Interpreter Design Pattern Provides a way to evaluate language grammar or expression. This pattern is used in SQL parsing, symbol processing engine, etc.

# When to use: 
The Interpreter Design Pattern should be used when there is a language to interpret. The interpreter pattern works best when

- Grammar is simple
- Efficiency is not a critical concern

The best example of this pattern is C# Compiler (CSC) that interprets the C# Source code into byte code that is understood by CLR. Google Translator is an example of the interpreter design pattern where the input can be in any language and we get the output in another language.

# Diagram
- Context contain a date and expression that is the format of the date.
- YearExpression, MonthExpression, DayExpression are translator that translate date to a text following expression format

![InterpreterDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/BehavioralDesignPattern/Interpreter/Interpreter.png)
