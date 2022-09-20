Class Work project

```mermaid
classDiagram
    IAnimal<|..Animal
    Animal: + Speak()
   
    Animal <|-- Dog
    Animal <|-- Cat
    Animal <|-- Cow
    class Dog{
        +  Speak(Woof)
    }
    class Cat{
        + Speak(Mew)
    }
    class Cow{
        + Speak(Moo)
    }
```
