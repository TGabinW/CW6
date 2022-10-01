Class Work project

```mermaid
classDiagram
    IAnimal<|..Animal
    IAnimal: + Speak()
   
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
![image](https://user-images.githubusercontent.com/111113016/193410453-668bba80-7758-47d1-ad3f-4841d9010383.png)
