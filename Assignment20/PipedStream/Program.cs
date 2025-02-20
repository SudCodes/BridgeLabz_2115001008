using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamCommunication
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8, leaveOpen: true))
            {
                writer.AutoFlush = true;
                string[] messages = { "Hello", "This is inter-thread communication", "Using PipeStream in C#", "End" };

                foreach (string message in messages)
                {
                    Console.WriteLine($"[Writer] Writing: {message}");
                    writer.WriteLine(message);
                    Thread.Sleep(500); // Simulate delay
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"[Writer] Error: {ex.Message}");
        }
    }

    static void ReadFromPipe(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"[Reader] Received: {message}");
                    if (message == "End") break;
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"[Reader] Error: {ex.Message}");
        }
    }
}
