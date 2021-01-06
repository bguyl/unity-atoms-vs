using UnityEngine;
using UnityAtoms;
using UnityAtoms.BaseAtoms;

// Set the icon you will see in the editor
[EditorIcon("atom-icon-sand")]

// Set the path in the asset creation menu
[CreateAssetMenu(menuName = "Unity Atoms/Conditions/Int/MultipleOf", fileName = "MultipleOf")]

public class MultipleOf : FloatCondition
{
	// Can be set via the Inspector
	public int multiple;

	public override bool Call(float value)
	{
		// The condition implementation must return a boolean value

		return value % multiple == 0;
	}
}