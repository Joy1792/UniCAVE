﻿/*
 * Interface that provides the methods for the various tools which the wand will use
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITool 
{
    string ToolName { get; }
    void init(); 
    void shutDown();
    void ButtonClick(TrackerButton buttonNum, Vector3 origin, Vector3 direction);
    void Analog(double x, double y);
    void ButtonDrag(RaycastHit hit, Vector3 offset, Vector3 origin, Vector3 direction);
}
