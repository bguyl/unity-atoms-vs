[UnityEngine.CreateAssetMenuAttribute(menuName = "Unity Atoms/Examples/Health Logger")]
public class HealthLogger : UnityAtoms.BaseAtoms.IntAction
{
	public override void Do(int health)
	{
		UnityEngine.Debug.Log("<3: " + health);
	}
}