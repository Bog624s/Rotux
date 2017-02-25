﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

public class Settings
{
    public Dictionary<string, string> data = new Dictionary<string, string>();
    private string file;
    public void Edit()
    {
        Process.Start("notepad.exe",file);
    }
    public Settings(string file)
    {
        this.file = Directory.GetCurrentDirectory() + @"\" + file;
        Load();
    }
    public void Load()
    {
        data.Clear();
        foreach (string line in File.ReadAllLines(file))
        {
            if (line.Length > 0)
                if (line.Split('=').Length == 2)
                {
                    data.Add(line.Split('=')[0], line.Split('=')[1]);
                }
                else
                {
                    if (!line.StartsWith("#"))
                        throw new Exception("Invalid settings!");
                }
        }
    }
}