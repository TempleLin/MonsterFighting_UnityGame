# MonsterFighting(Tentative)

A Unity fighting game currently under heavy development.

## Getting Started



### Prerequisites

Make sure you meet these requirements before starting to participate:

```
Install the correct version of Unity (Currently installed version: 2020.3.8f1)
Understand the structure of the code
```

### Installing

Download the Zip file from this repository and decompress it or clone it through git to start participating in the project.

```
Git clone: https://github.com/TempleLo/MonsterFighting_UnityGame.git
```


## Project Coding Structure

Structure of the coding in this Unity project in a nutshell.

```
@There are three types of commanders: Player1, Player2, and AI.
@MF_GameSettings are the settings given by Commanders.
@LocalManager and NetworkManager gameobjects with be the ones setting MF_InfoStation through MF_GameSettings.
@Players or AI prefab are spawned by LocalManager and NetworkManager.
@Information the commanders can get are accessed through MF_InfoStation, not MF_GameSettings.
@MF_CommanderInfo is the only info in spawned prefab that receives information set by Manager.
@MF_SignInCompleteCheckCentral is a design pattern that acts as a central for components to inherit MF_ISignInCompleteCheck interface
and sign in to this central on code start, and can know when other component that have signed this interface has completed its code
by accessing this central.

"_Controlled" in the end of method name means it gets called from class that ends with "Control". "pas" means it gets called from other gameObjects.
```

## Packages used

* [Cinemachine](https://github.com/Unity-Technologies/com.unity.cinemachine) - (Already in Package Manager)
* [Input System](https://github.com/Unity-Technologies/InputSystem) - (Already in Package Manager)
* [Parrel Sync](https://github.com/VeriorPies/ParrelSync) - For easier multiplayer development
* [Github](https://unity.github.com/) - Easier version control within Unity


## Versioning

Stay tuned.

## Authors

* **Temple Lin 林天牧** - *Initial work and lead programmer* - [Temple Lin](https://github.com/TempleLo)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is a closed source proprietary software. 

## Acknowledgments

* Heavily inspired to ECS code design. Hope to be redesigned to ECS code in the future.
