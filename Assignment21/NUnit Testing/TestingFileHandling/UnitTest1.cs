using System;
using System.IO;
using NUnit.Framework;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
            throw new IOException("File not found");

        return File.ReadAllText(filename);
    }
}

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor _fileProcessor;
    private string _testFile;

    [SetUp]
    public void Setup()
    {
        _fileProcessor = new FileProcessor();
        _testFile = "testfile.txt";
    }

    [Test]
    public void WriteToFile_ShouldCreateFileWithContent()
    {
        string content = "Hello, World!";
        _fileProcessor.WriteToFile(_testFile, content);

        Assert.IsTrue(File.Exists(_testFile));
        Assert.AreEqual(content, File.ReadAllText(_testFile));
    }

    [Test]
    public void ReadFromFile_ShouldReturnCorrectContent()
    {
        string content = "Sample text";
        File.WriteAllText(_testFile, content);

        string result = _fileProcessor.ReadFromFile(_testFile);
        Assert.AreEqual(content, result);
    }

    [Test]
    public void ReadFromFile_ShouldThrowIOException_WhenFileDoesNotExist()
    {
        Assert.Throws<IOException>(() => _fileProcessor.ReadFromFile("nonexistent.txt"));
    }

    [TearDown]
    public void Teardown()
    {
        if (File.Exists(_testFile))
        {
            File.Delete(_testFile);
        }
    }
}
