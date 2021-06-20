# ChainOFResponsibility
- A request is wrapped under an object as command and passed to invoker object. Invoker object looks for the appropriate object which can handle this command 
  and passes the command to the corresponding object which executes the command.
  
# Benefit
- Separates the object that invokes the operation from the one that knows how to perform it.
- It's easy to add new commands, because you don't have to change existing classes.

# When to use: add new functionality to
- You want to parameterize objects by an action to perform.
- You specify, queue, and execute requests at different times.
- You must support undo, logging, or transactions

# Diagram

![ChainOfReponsibilityDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Command/Command.png?raw=true)
