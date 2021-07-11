# Adapter
- Support communication between two incompatible interfaces by acting as a bridge
- Like universal charger is the adapter between power source with the charger

# When to use: 
- Communication between a new and a existing/ legacy system which are indepedent of each other

# Diagram
- MessageResource is legacy system
- MessageProvider is the adapter which get messages from MessageResourse, do some changes and publish to others

![AdapterDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Adapter/Adapter.png?raw=true)
