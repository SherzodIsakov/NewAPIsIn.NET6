using Microsoft.Win32.SafeHandles;
using System.Text;

// В .NET 6 представлен новый низкоуровневый API для чтения и записи файлов без FileStream.
// Новый тип, RandomAccess, предоставляет API-интерфейсы на основе смещения для чтения и записи файлов потокобезопасным способом.
using SafeFileHandle handle = 
	File.OpenHandle("file.txt", access: FileAccess.ReadWrite);

// Write to file
byte[] strBytes = Encoding.UTF8.GetBytes("Hello world");
ReadOnlyMemory<byte> buffer1 = new(strBytes);
await RandomAccess.WriteAsync(handle, buffer1, 0);

// Get file length
long length = RandomAccess.GetLength(handle);

// Read from file
Memory<byte> buffer2 = new(new byte[length]);
await RandomAccess.ReadAsync(handle, buffer2, 0);
string content = Encoding.UTF8.GetString(buffer2.ToArray());
Console.WriteLine(content); // Hello world

Console.ReadKey();
