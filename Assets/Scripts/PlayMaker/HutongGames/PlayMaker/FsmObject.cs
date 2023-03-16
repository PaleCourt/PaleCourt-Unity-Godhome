using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmObject : NamedVariable
	{
		[SerializeField]
		private string typeName;
		[SerializeField]
		private Object value;
	}
}
