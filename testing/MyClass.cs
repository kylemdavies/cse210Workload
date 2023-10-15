using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

[Serializable]
public class MyClass
{
    public int ID { get; set; }
    public string Name { get; set; }

    public MyClass(int id, string name)
    {
        ID = id;
        Name = name;
    }

    public MyClass()
    {
        // Default constructor is required for serialization
    }
}

public class ListFileHandler<T> where T : class
{
    public static void SaveListToFile(string filePath, List<T> list)
    {
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, list);
            }
            Console.WriteLine("List saved to " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while saving list to file: " + ex.Message);
        }
    }

    public static List<T> LoadListFromFile(string filePath)
    {
        List<T> list = new List<T>();
        try
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextReader reader = new StreamReader(filePath))
            {
                list = (List<T>)serializer.Deserialize(reader);
            }
            Console.WriteLine("List loaded from " + filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while loading list from file: " + ex.Message);
        }

        return list;
    }
}
