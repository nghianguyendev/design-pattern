# Decorator
- Support OCP by adding functions to existing objects dynamically
- Alternative to sub classing

# When to use: add new functionality to
- Legacy system
- Sealed classed

# Diagram
- LegacyOldCarDecorator class is wrapped by LegacyOldCar
- LegacyOldCarWithNewIndicator is added new indicator to legacyOldCar
- LegacyOldCarWithNewIndicatorAndWheel is added new indicator and wheel to legacyOldCar

![CompositeDesignPattern](https://github.com/nghianguyendev/design-pattern/blob/master/Decorator/Decorator.png?raw=true)
