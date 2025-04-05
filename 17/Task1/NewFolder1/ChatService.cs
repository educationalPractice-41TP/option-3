using System;
using System.IO;
using System.IO.Pipes;

namespace StudentDiary
{
    public class ChatService
    {
        private const string PipeName = "StudentTeacherChat";

        public static void SendMessage(string message)
        {
            using (var client = new NamedPipeClientStream(".", PipeName, PipeDirection.Out))
            {
                client.Connect();
                using (var writer = new StreamWriter(client))
                {
                    writer.WriteLine(message);
                    writer.Flush();
                }
            }
        }

        public static void StartChatServer(Action<string> onMessageReceived)
        {
            // Запускается в отдельном потоке
            using (var server = new NamedPipeServerStream(PipeName, PipeDirection.In))
            {
                server.WaitForConnection();
                using (var reader = new StreamReader(server))
                {
                    while (!reader.EndOfStream)
                    {
                        string msg = reader.ReadLine();
                        onMessageReceived?.Invoke(msg);
                    }
                }
            }
        }
    }
}
