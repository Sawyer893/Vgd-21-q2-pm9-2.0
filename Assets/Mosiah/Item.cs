﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
   public enum ItemType
    {
       Meat,
       Flufball,
       Fabric,
       Rope,
       Snowball,
       Stick,
       Bone,
    }
    public ItemType itemType;
    public int amount;
}