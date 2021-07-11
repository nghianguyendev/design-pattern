# Visitor
- Add extra behavior to existing classes without modyfying it at design time.

# When to use
- Visitor pattern is often advisable to be used when many unique and unrelated operations need to be performed on objects without “polluting” their classes with these operations.
  
# Benefit
- Double dispatch: is a trick that allows using dynamic binding alongside with overloaded methods.
 Reference https://refactoring.guru/design-patterns/visitor-double-dispatch
 
# Diagram
- ExportVisitor is a visitor that can export an employee without modifying it.
 
![VisitorDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Visitor/Visotor.png?raw=true)
