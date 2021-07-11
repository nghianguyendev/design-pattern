# ChainOFResponsibility
- GOF: Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects 
  and pass the request along the chain until an object handles it
- A simple example is Exeption handling: messages are passed along levels of Exeption handlers

# When to use: add new functionality to
- You have more than one handler for a message
- The appropriate handler is not known to the sender
- The set of handlers can be dynamically defined

# Diagram
- BaseApprover is the abstract class which defined actions of Approver
- TeamLeadApprover, ProjectManagerApprover, DeliveryManagerApprover, CEOManagerApprover are the approvers that can handle a specific submit leaves 

![ChainOfReponsibilityDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/ChainOfResponsibility/ChainOfResponsibility.png?raw=true)
