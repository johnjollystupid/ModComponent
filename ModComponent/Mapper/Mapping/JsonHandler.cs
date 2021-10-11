﻿using System.Collections.Generic;
using System.IO;

namespace ModComponent.Mapper
{
	internal enum JsonType
	{
		Automapped,
		Blueprint
	}
	internal static class JsonHandler
	{
		private static Dictionary<string, string> itemJsons = new Dictionary<string, string>();
		internal static Dictionary<string, string> blueprintJsons = new Dictionary<string, string>();

		public static void RegisterItemJson(string itemName, string path)
		{
			string data = File.ReadAllText(path);
			if (string.IsNullOrEmpty(data)) return;

			if (itemJsons.ContainsKey(itemName))
			{
				Logger.Log("Overwriting path for {0}", itemName);
				itemJsons[itemName] = data;
			}
			else
			{
				itemJsons.Add(itemName, data);
			}
		}
		public static void RegisterJsonText(string itemName, string fullPath, string text, JsonType jsonType)
		{
			if (string.IsNullOrEmpty(text)) return;

			switch (jsonType)
			{
				case JsonType.Automapped:
					if (itemJsons.ContainsKey(itemName))
					{
						Logger.Log("Overwriting data for {0}", itemName);
						itemJsons[itemName] = text;
					}
					else itemJsons.Add(itemName, text);
					break;
				case JsonType.Blueprint:
					if (!blueprintJsons.ContainsKey(fullPath)) blueprintJsons.Add(fullPath, text);
					break;
			}
		}
		public static string GetJsonText(string itemName)
		{
			if (itemJsons.ContainsKey(itemName.ToLower()))
			{
				return itemJsons[itemName.ToLower()];
			}
			else
			{
				Logger.Log("Could not find {0} in json dictionary", itemName);
				return null;
			}
		}
		public static void RegisterDirectory(string directory)
		{
			if (!Directory.Exists(directory))
			{
				return;
			}
			string[] directories = Directory.GetDirectories(directory);
			foreach (string eachDirectory in directories)
			{
				RegisterDirectory(eachDirectory);
			}

			string[] files = Directory.GetFiles(directory);
			foreach (string eachFile in files)
			{
				string name = ModComponent.AssetLoader.ModAssetBundleManager.GetAssetName(eachFile);
				if (eachFile.ToLower().EndsWith(".json"))
				{
					Logger.Log("Found '{0}'", eachFile);
					RegisterItemJson(name, eachFile);
					continue;
				}

			}
		}
		internal static void LogDirectoryContents()
		{
			foreach (string key in itemJsons.Keys)
			{
				Logger.Log("Key: '{0}', Entry: '{1}'", key, itemJsons[key]);
			}
		}
	}
}
