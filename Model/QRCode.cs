using System;
using Model;
using utils;

namespace Model
{
	public class QRCode
	{
		public String message;

		public Mask mask;

		public Encoding encoding;

		public QRVersion version;

		public ErrorCorrectionLvL correctionLvL;

		public int[][] bitArray;

	}

}

