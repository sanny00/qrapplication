using System;
using qr_app.Model;
using qr_app.utils;

namespace qr_app.Model
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

