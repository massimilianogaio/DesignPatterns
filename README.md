# Introduction 
This repository aims to be a practical Unity3D application of the concepts expressed in the book "Design Patterns: Elements of Reusable Object-Oriented Software".
The repository is an open to improvements exercise and is not intended to be exhaustive. Further patterns will be implemented in the future.
Each pattern is implemented in a different Unity scene with a demo example.
## Patterns implemented
- Abstract Factory Pattern (Creational);
- Factory Method Pattern (Creational);
- Singleton Pattern (Creational);
- Command Pattern (Behavioral);
- Observer Pattern (Behavioral);
- State Pattern (Behavioral);
- Strategy Pattern (Behavioral)
### Other Implementations
 - Composition over inheritance.

## Abstract Factory Pattern
### Pattern Goal
Provide an interface for creating families of related or dependent objects without their concrete classes.
### Structure
![abstractFactoryUML drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/28f42390-83b2-497e-ac05-89c0aa648648)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/096f3ace-88ce-4a66-9ea1-57f6f4f706fa

## Factory Method Pattern
### Pattern Goal
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
### Structure
See Composition over Inheritance Structure section.

## Singleton
#### Pattern Goal
Ensure a class only has one instance, and provide a global point of access to it.
### Structure
See Command Pattern Structure section. 

## Command Pattern
### Pattern Goal
Encapsulate a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
### Structure
![command drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/e734339c-f36f-426f-82c6-b9858c01e19e)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/9bda8ff2-da00-490d-b5d8-bba637090318

## Observer Pattern
### Pattern Goal
Define a one-to-many dependency between objects so that when one object state, all its dependents are notified and updated automatically.
### Structure
![obs drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/a88fbb2c-477e-418f-97d0-3b1827c40d9c)

### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/807f7d09-0745-438a-bcd8-c982753a5b27

## State Pattern
### Pattern Goal
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
### Structure
![state drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/fe2c7e90-fd80-4710-b78c-661df96df34b)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/a590505b-2176-4fdc-87c7-30dc97a8808e

## Strategy Pattern
### Pattern Goal
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
### Structure
![strat](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/ec9d82d2-0101-40b8-bcfc-7fedc6f00a75)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/15cd7b68-656f-46c0-9320-fe59ffab03af

## Composition over Inheritance
### Pattern Goal
Building flexible and maintainable software by favoring the assembly of smaller, specialized components over rigidly inheriting behavior from complex parent classes.
### Structure
![oc (1) drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/006d6d95-fefb-49ad-b251-6192512350d4)

### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/42cf14e9-7b69-4715-b8f6-7a524d2e8098

# Third-party assets
- https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-series-free-103633
- https://assetstore.unity.com/packages/3d/props/tools/dice-d6-game-ready-pbr-200151#asset_quality
- https://assetstore.unity.com/packages/3d/props/low-poly-chess-pack-50405
- https://assetstore.unity.com/packages/3d/characters/animals/5-animated-voxel-animals-145754
- https://assetstore.unity.com/packages/3d/characters/animals/fantasy-bee-135487
- https://assetstore.unity.com/packages/3d/characters/toony-tiny-people-demo-113188)https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-series-free-103633
- https://assetstore.unity.com/packages/3d/props/tools/dice-d6-game-ready-pbr-200151#asset_quality
- https://assetstore.unity.com/packages/3d/props/low-poly-chess-pack-50405
- https://assetstore.unity.com/packages/3d/characters/animals/5-animated-voxel-animals-145754
- https://assetstore.unity.com/packages/3d/characters/animals/fantasy-bee-135487
- https://assetstore.unity.com/packages/3d/characters/toony-tiny-people-demo-113188
