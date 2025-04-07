using System;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace StudentDiary
{
    public class NotificationService
    {
        private const string MapName = "NewAssignmentNotification";

        public static void SendNotification(string message)
        {
            using (var mmf = MemoryMappedFile.CreateOrOpen(MapName, 1024))
            using (var accessor = mmf.CreateViewAccessor())
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                accessor.WriteArray(0, data, 0, data.Length);
            }
        }

        public static string ReceiveNotification()
        {
            using (var mmf = MemoryMappedFile.OpenExisting(MapName))
            using (var accessor = mmf.CreateViewAccessor())
            {
                byte[] data = new byte[1024];
                accessor.ReadArray(0, data, 0, data.Length);
                return Encoding.UTF8.GetString(data).TrimEnd('\0');
            }
        }
    }
}
