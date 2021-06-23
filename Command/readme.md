# Command
- A request is wrapped under an object as command and passed to invoker object. Invoker object looks for the appropriate object which can handle this command 
  and passes the command to the corresponding object which executes the command.
  
# Benefit
- Decouple the classes that invokes operations from the classes that perform these operations.
- It's easy to add new commands, because you don't have to modify existing classes.

# When to use: 
- You want to parameterize objects by an action to perform.
- You specify, queue, and execute requests at different times.
- You must support undo, logging, or transactions

This is a simple pattern with many useful applications; actions become objects, and thus can be sorted, logged, queued, and so forth. 

The quintessential example of Command is for GUI actions, such as cut and paste. For example, the CutCommand's execute method does a cut, and its undo method reverses the cut. The CutCommand will also retain the data necessary to perform the undo. All the GUI commands can be kept in a history stack, so that they can be popped in turn, and each undone.

Another common use of Command is for server - side request handling. When a server object receives a (remote) message, it creates a Command object for that request, and hands it off to a CommandProcesser [BMRSS96], which can queue. log, prioritize, and execute the commands.

# Diagram

![ChainOfReponsibilityDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Command/Command.png?raw=true)
