﻿using MelonLoader.TinyJSON;
using ModComponent.Utils;
using UnhollowerBaseLib.Attributes;
using UnityEngine;

namespace ModComponent.API.Behaviours
{
	[MelonLoader.RegisterTypeInIl2Cpp]
	public class ModRepairableBehaviour : MonoBehaviour
	{
		/// <summary>
		/// The audio to play while repairing.
		/// </summary>
		public string Audio;

		/// <summary>
		/// How many in-game minutes does it take to repair this item?
		/// </summary>
		public int Minutes;

		/// <summary>
		/// How much condition does repairing restore?
		/// </summary>
		public int Condition;

		/// <summary>
		/// The name of the tools suitable for repair. At least one of those will be required for repairing.<br/>
		/// Leave empty, if this item should be repairable without tools.
		/// </summary>
		public string[] RequiredTools;

		/// <summary>
		/// The name of the materials required for repair.
		/// </summary>
		public string[] MaterialNames;

		/// <summary>
		/// The number of the materials required for repair.
		/// </summary>
		public int[] MaterialCounts;

		public ModRepairableBehaviour(System.IntPtr intPtr) : base(intPtr) { }

		[HideFromIl2Cpp]
		internal void InitializeBehaviour(ProxyObject dict, string className = "ModRepairableBehaviour")
		{
			this.Audio = dict[className]["Audio"];
			this.Minutes = dict[className]["Minutes"];
			this.Condition = dict[className]["Condition"];
			this.RequiredTools = JsonUtils.MakeStringArray(dict[className]["RequiredTools"] as ProxyArray);
			this.MaterialNames = JsonUtils.MakeStringArray(dict[className]["MaterialNames"] as ProxyArray);
			this.MaterialCounts = JsonUtils.MakeIntArray(dict[className]["MaterialCounts"] as ProxyArray);
		}
	}
}