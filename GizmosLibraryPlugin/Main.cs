using BepInEx;
using UnityEngine;

namespace GizmosLibraryPlugin
{
	[BepInPlugin(BuildInfo.GUID, BuildInfo.Name, BuildInfo.Version)]
	public class Main : BaseUnityPlugin
    {
    }
	public static class BuildInfo
	{
		public const string GUID = "locochoco.plugins.GizmosLibraryPlugin";

		public const string Name = "Gizmos Library Plugin";

		public const string Version = "0.1.0";
	}
}
