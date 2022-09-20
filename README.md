Class Work project

```mermaid
classDiagram
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Cow
    + IAnimal
    class Dog{
        + Ianimal Speak(Woof)
    }
    class Cat{
        + IAnimal Speak(Mew)
    }
    class Cow{
        + IAnimal Speak(Moo)
    }
```
