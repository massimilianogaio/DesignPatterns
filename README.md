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
![abstractFactoryUML drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/0bf1ef58-ab0a-40ed-af00-2313732910e3)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/6a84e913-2c53-42f3-9c11-f28eb025d7af

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
![command drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/4caff146-9639-4afa-9b14-9501bef6c8e7)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/37f424e6-0ab5-4f68-b9b3-b35eeed1dc70

## Observer Pattern
### Pattern Goal
Define a one-to-many dependency between objects so that when one object state, all its dependents are notified and updated automatically.
### Structure
![obs drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/a001ce92-2117-432b-b033-9262e48a7c9d)

### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/24be07ad-2699-4e31-b7d4-c5385f04a82f

## State Pattern
### Pattern Goal
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
### Structure
![state drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/50a11e2f-2793-41ee-8958-f7f8919a163e)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/9cea7020-167e-4e76-821a-0420b184b037

## Strategy Pattern
### Pattern Goal
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
### Structure
![strat](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/a27a61cd-492c-46f9-a988-6608221ebea2)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/fa304c1a-1605-4b4e-bfd1-16f22733aff7

## Composition over Inheritance
### Pattern Goal
Building flexible and maintainable software by favoring the assembly of smaller, specialized components over rigidly inheriting behavior from complex parent classes.
### Structure
![oc (1) drawio](https://github.com/massimilianogaio/DesignPatterns/assets/52246963/1e951d1b-8d40-4d55-94ce-659dc39fcebf)
### Demo Scene
https://github.com/massimilianogaio/DesignPatterns/assets/52246963/6e338940-b125-43ca-8071-b3e4c6f49038

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
