using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class RectTransformSetLocalRotation : FsmStateActionAdvanced
	{
		public FsmOwnerDefault gameObject;
		public FsmVector3 rotation;
		public FsmFloat x;
		public FsmFloat y;
		public FsmFloat z;
	}
}
