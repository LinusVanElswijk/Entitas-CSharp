﻿using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CustomObject {
    public string name;

    public CustomObject(string name) {
        this.name = name;
    }
}

public class MonoBehaviourSubClass : MonoBehaviour {
}

public class MonoBehaviourSubClassComponent : IComponent {
    public MonoBehaviourSubClass monoBehaviour;
}

public class CustomObjectComponent : IComponent {
    public CustomObject customObject;
}

public class SystemObjectComponent : IComponent {
    public System.Object systemObject;
}

public class DateTimeComponent : IComponent {
    public DateTime date;
}

public class AnArrayComponent : IComponent {
    public string[] array;
}

public class Array2DComponent : IComponent {
    public string[,] array2d;
}

public class Array3DComponent : IComponent {
    public string[,,] array3d;
}

public class JaggedArrayComponent : IComponent {
    public string[][] jaggedArray;
}

public class ListArrayComponent : IComponent {
    public List<string>[] listArray;
}

public class ListComponent : IComponent {
    public List<string> list;
}

public class DictionaryComponent : IComponent {
    public Dictionary<string, string> dict;
}

public class DictArrayComponent : IComponent {
    public Dictionary<int, string[]> dict;
    public Dictionary<int, string[]>[] dictArray;
}

public class HashSetComponent : IComponent {
    public HashSet<string> hashset;
}

public class UnsupportedObject {
    public string name;

    public UnsupportedObject(string name) {
        this.name = name;
    }
}

public class UnsupportedObjectComponent : IComponent {
    public UnsupportedObject unsupportedObject;
}

public class PropertyComponent : IComponent {
    public string value { get; set; }
}

