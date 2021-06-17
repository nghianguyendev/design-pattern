# Proxy
- Provide a surrogate for another object to control access to it
- Looks like it is similar to Adapter, Bridge, Mediator but they are different.

# When to use: 
- Need to provide a contact point for a resource that should not be accessed by the client directly. 

# Diagram
- ProxyInternetAccess will be the imdediate for RealInternetAccess but it's filterring sites that user can access.

![ProxyDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Proxy/Proxy.png?raw=true)


# Comparision with others

|                                                                | Proxy | Adapter | Decorator | Bridge |
|----------------------------------------------------------------|-------|---------|-----------|--------|
| Implement same interface with pre-existing object              | Yes   | No      | No        |        |
| Change the data of pre-existing object                         | No    | Yes     | No        |        |
| Must be implemented before the application is designed         |       | No      |           | Yes    |
| Add more functionality to existing object without  changing it |       |         | Yes       |        |
