Atoms nodes for Visual Scripting 
================================

[![openupm](https://img.shields.io/npm/v/me.guyl.atoms-vs?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/me.guyl.atoms-vs/)

*A.K.A Bolt Addons for Atoms*

----------------------------------------------------------------------------------------

Add new Visual Scripting (previously [Bolt](https://assetstore.unity.com/packages/tools/visual-scripting/bolt-163802))
nodes for a better [Unity Atoms](https://github.com/AdamRamberg/unity-atoms) integration.
Improve your workflow with scriptable object architecture and visual scripting !

## Summary

* [Available Nodes](https://github.com/bguyl/unity-atoms-vs#available-nodes)
* [Installation](https://github.com/bguyl/unity-atoms-vs#installation)
    

## Available Nodes

### Atoms Events

![Nodes atoms events](Documentation~/nodes-atoms-events.jpg)

- AtomBaseVariable Event
- Bool Event
- BoolPair Event 
- Collider2D Event
- Collider2DPair Event
- Collider Event 
- ColliderPair Event
- Collision2D Event
- Collision2DPair Event
- Collision Event
- CollisionPair Event
- Color Event
- ColorPair Event
- Double Event
- DoublePair Event
- Float Event
- FloatPair Event
- GameObject Event
- GameObjectPair Event
- Int Event
- IntPair Event
- Quaternion Event
- QuaternionPair Event
- String Event
- StringPair Event
- Vector2 Event
- Vector2Pair Event
- Vector3 Event
- Vector3Pair Event
- Void Event

## Installation

### 1. Add the package to the project 

The preferred way to install this package is via [openupm-cli](https://github.com/openupm/openupm-cli)

````
openupm add me.guyl.atoms-vs@2.0.0-preview.1
````

This way, it will automatically download all the dependencies

Otherwise, you will have to manually install the following packages:

- [Unity Visual Scripting](https://docs.unity3d.com/bolt/1.4/manual/index.html) (from package manager)
- [Unity Atoms Core (4.4.2 or greater)](https://github.com/unity-atoms/unity-atoms)
- [Unity Atoms Base Atoms (4.4.2 or greater)](https://github.com/unity-atoms/unity-atoms)
- [LinkMerge (1.0.0 or greater)](https://github.com/RealityStop/Unity.CustomPackage.LinkMerge)

Then click on `Next` and `Generate`

----------------------------------------------------------------------------------------

Congrats, you're now good to go 🎉
