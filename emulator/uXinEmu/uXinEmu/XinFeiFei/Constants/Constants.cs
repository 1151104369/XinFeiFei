﻿// ReSharper disable ConvertToConstant.Global

namespace uXinEmu.XinFeiFei
{
	//TODO: Put these settings in INI files, XML files and/or database.
	public static class Constants
	{
		//TODO: Make a table with allowed versions in the database.
		public const byte MainVersion = 2;
		public const byte MajorVersion = 1;
		public const ushort MinorVersion = 327;

		public static uint Version
		{
			get { return MainVersion << 24 | MajorVersion << 16 | MinorVersion; }
		}

		public const int DatabaseUpdateInterval = 10000;

		public const double TimeoutSeconds = 15;

		public const uint ServerId = 1337;

		public static readonly bool CharacterCreationEnabled = true;
		public static readonly int LogLevel = 1;

		public static readonly byte[] InventorySlots = new byte[]
		                                               {
			                                               0x0D, 0x07, 0x2F, 0x05, 0x06, 0x04, 0x0A, 0x02, 0x01, 0x2E,
			                                               0x30, 0x2C, 0x42, 0x00, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13,
			                                               0x14, 0x15, 0x16, 0x17, 0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D,
			                                               0x1E, 0x1F, 0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x27,
			                                               0x28, 0x29, 0x2A, 0x2B, 0x03, 0x2D, 0x0C, 0x08, 0x0B, 0x31,
			                                               0x32, 0x33, 0x37, 0x35, 0x36, 0x09, 0x38, 0x39, 0x3A, 0x3B,
			                                               0x3C, 0x3D, 0x3E, 0x3F, 0x40, 0x41, 0x34, 0x43, 0x44, 0x45,
			                                               0x46, 0x47, 0x48
		                                               };

		public static readonly byte[] QuestSlots = new byte[]
		                                           {
			                                           0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B,
			                                           0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16, 0x17,
													   0x18, 0x19, 0x1A, 0x1B, 0x1C, 0x1D, 0x1E, 0x1F, 0x20, 0x21, 0x22, 0x23,
													   0x24, 0x25, 0x26, 0x27, 0x28, 0x29
		                                           };

		public static readonly bool DeleteItemOnDrop = true;
	}
}