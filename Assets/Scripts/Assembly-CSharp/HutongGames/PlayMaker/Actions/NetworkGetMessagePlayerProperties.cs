using HutongGames.PlayMaker;

namespace HutongGames.PlayMaker.Actions
{
	public class NetworkGetMessagePlayerProperties : FsmStateAction
	{
		public FsmString IpAddress;
		public FsmInt port;
		public FsmString guid;
		public FsmString externalIPAddress;
		public FsmInt externalPort;
	}
}