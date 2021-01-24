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

### Atoms Variables

![Nodes atoms variables](Documentation~/nodes-atoms-variables.jpg)

- Bool Variable
- Collider2D Variable
- Collider Variable
- Color Variable
- Float Variable
- GameObject Variable
- Int Variable
- Quaternion Variable
- String Variable
- Vector2 Variable
- Vector3 Variable

## Installation

### 1. Requirements

This package required [Bolt (1.4.13 or greater)](https://assetstore.unity.com/packages/tools/visual-scripting/bolt-163802) to be already installed

### 2. Add the package to the project 

The preferred way to install this package is via [openupm-cli](https://github.com/openupm/openupm-cli)

````
openupm add me.guyl.atoms-vs
````

This way, it will automatically download all the dependencies

Otherwise, you will have to manually install the following packages:

- [Unity Atoms Core (4.4.2 or greater)](https://github.com/unity-atoms/unity-atoms)
- [Unity Atoms Base Atoms (4.4.2 or greater)](https://github.com/unity-atoms/unity-atoms)
- [LinkMerge (1.0.0 or greater)](https://github.com/RealityStop/Unity.CustomPackage.LinkMerge)

### 3. Configure Bolt

#### The automatic way (events node only)

`Build Unit Options` to make the units available for your project.

![Bolt Unit Wizard](Documentation~/bolt-build-units.jpg)

#### Adding package assembly (add variable nodes)

Open the Unit Options Wizard

![Bolt Unit Wizard](Documentation~/bolt-unit-wizard.jpg)

Add `Guyl.AtomsVS.Runtime` in the Assembly Options

![Bolt Assembly  Options](Documentation~/bolt-assembly-options.jpg)

Then click on `Next` and `Generate`

----------------------------------------------------------------------------------------

Congrats, you're now good to go 🎉
