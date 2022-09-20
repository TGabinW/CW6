Class Work project

```mermaid
classDiagram
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Cow
    Animal ..|> IAnimal()
    class Dog{
    IAnimal Speak(Woof) ..|> Dog
    }
    class Cat{
    IAnimal Speak(Mew) ..|> Cat
    }
    class Cow{
    IAnimal Speak(Moo) ..|> Cow
    }
```
