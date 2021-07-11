# Strategy
- Allow clients to choose an algorithm from a family of algorithms at run time.

# When to use
- Many related classes differ only in their behaviour.
- You need different variants of an algorithm
- Eliminate large conditional statements

  A class defines many behaviours appear as multiple conditional statements in its operation.
  Instead of many conditional statements, move related conditional branches into their own stratefy class.
   
# Diagram
- Switch turnOn, turnOff the light. Each action have a specific behavior regarding its state
 
![StrategyDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Strategy/Strategy.png?raw=true)
