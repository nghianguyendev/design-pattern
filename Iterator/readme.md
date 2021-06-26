# Iterator
- Iterate over a collection without knowing how is the collection is structured.
- Each step of iterating the collection could be calculated.
  
# Benefit
- Can provide filters, transformations, and projections on the data. (For example: just get working days of the week)
- More memory efficient that List as Iterator is not nessessary associated to an in-memory datastructure containing all the values to be yielded.
 
# When to use: 
- When there are multiple traversals of objects need to be supported in the collection.
- When you want to access a collection of objects without exposing its internal representation

# Note:
- Yield is a special keyword in C# that can be used only in the context of iterators. It instructs the compiler to convert this regular code to a state machine (an enumerator). The auto-generated code keeps track of where you are in the collection and it implements methods such as MoveNext and Current.

Yeah! that means we can write less and do more

# Diagram

![IteratorDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Iterator/Iterator.png?raw=true)
