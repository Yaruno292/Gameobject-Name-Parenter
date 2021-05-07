# Gameobject-Name-Parenter
Parents 2 selected gameobjects into eachother

## Reason
I created this script to make it easier  
and less time consuming to put 2 armatures together.

You have to do this for custom clothes for your avatar
in VRChat.

## Functions
It reparents the "oldParent's" children into the "newParent" by matching the names.  
If the names don't match it puts it into the parent above it.

## How to use
Simply drag in the prefab named: ScriptRunner  
Select the 2 GameObjects you want to parent into eachother.

New Parent: This is the GameObject you are going to use in the end. aka the result.  
Old Parent: This is the GameObject you want to put the children into the other GameObject. (Clothes armature)

Press the "Combine" button to merge the GameObjects.  
Press the "Revert" button to get rid of the current merge.  
Press the "Done" button if you are sure the merge was succesfull.  

## Warning
Be sure to make backups before pressing "Done".  
The changes can not be reverted by the script after that.
