using System;

namespace InternetSpeedTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new SpeedTest.SpeedTestClient();
			var server = new SpeedTest.Models.Server();

			// Server list: https://c.speedtest.net/speedtest-servers-static.php
			server.Url = "http://speedtest3.vtn.com.vn:8080/speedtest/upload.php"; // Ho Chi Minh, VNPT

			var download = client.TestDownloadSpeed(server);
			var upload = client.TestUploadSpeed(server);

			Console.WriteLine($"Download: {download}");
			Console.WriteLine($"Upload: {upload}");
		}
	}
}
