using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryManager
{
    public class JSONStorage
    {


            public Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

            public Dictionary<string, dynamic> all()
            {
                return objects;
            }
            public void New(obj)
            {
                try
                {
                    objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
                }
                catch (Exeption)
                {
                    Console.WriteLine("provide Class Instance That Inhirit from BaseClass");
                }
            }
            public void Save()
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string fileName = "../../../../storage/inventory_manager.json";
                string jsonString = JsonSerializer.Serialize(objects, options);
                File.WriteAllText(fileName, jsonString);
            }
            public void Load()
            {
                string fileName = "../../../../storage/inventory_manager.json";
                string jsonString = File.ReadAllText(fileName);
                objects = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
            }
    }

}