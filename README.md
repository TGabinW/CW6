Class Work project

```mermaid
classDiagram
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Cow
    Animal: + IAnimal
    class Dog{
        + IAnimal Speak(Woof)
    }
    class Cat{
        + IAnimal Speak(Mew)
    }
    class Cow{
        + IAnimal Speak(Moo)
    }
```
